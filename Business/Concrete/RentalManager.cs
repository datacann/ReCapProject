using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aotufac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        private ICustomerService _customerService;
        private ICarService _carService;
        public RentalManager(IRentalDal rentalDal, ICarService carService, ICustomerService customerService)
        {
            _rentalDal = rentalDal;
            
            _carService = carService;
            _customerService = customerService;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        private IResult CheckIfCarRented(Rental rental)
        {
            var result = _rentalDal.GetAll(
                r => r.CarId == rental.CarId &&
                (r.ReturnDate == null || r.ReturnDate < DateTime.Now)
                ).Any();

            if (result)
            {
                return new ErrorResult(Messages.CarAlreadyRented);
            }

            return new SuccessResult();
        }


        private IResult FindexPointCheck(int customerId, int carId)
        {
            var customer = _customerService.GetById(customerId).Data;

            if (customer.CustomerFindexPoint == 0)
            {
                return new ErrorResult(Messages.CustomerFindexPointIsZero);
            }

            var car = _carService.GetById(carId).Data;

            if (customer.CustomerFindexPoint < car.CarFindexPoint)
            {
                return new ErrorResult(Messages.CustomerScoreInvalid);
            }

            customer.CustomerFindexPoint = (car.CarFindexPoint / 2) + customer.CustomerFindexPoint;

            _customerService.Update(customer);
            return new SuccessResult();
        }
    }
}

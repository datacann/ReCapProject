using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aotufac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        [SecuredOperation("brand.add,admin")]
        public IResult Add(Brand brand)
        {

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }
        [SecuredOperation("brand.delete,admin")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);

            //}
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id));
        }

        [ValidationAspect(typeof(BrandValidator))]
        [SecuredOperation("brand.update,admin")]
        public IResult Update(Brand brand)
        {

            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}

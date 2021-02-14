using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join cus in context.Customers
                             on re.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarId = ca.CarId,
                                 RentDate = re.RentDate,
                                 UserName = us.FirstName + " " + us.LastName

                             };
                return result.ToList();

            }
        }
    }
}

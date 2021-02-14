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
    public class EFCustomerDal : EfEntityRepositoryBase<Customer, CarRentContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users on customer.UserId equals user.Id
                             select new CustomerDetailDto()
                             {
                                 CustomerId = customer.Id,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}

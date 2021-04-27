using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : EfEntityRepositoryBase<Customer, CarRentContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from cs in filter == null ? context.Customers : context.Customers.Where(filter)
                             join u in context.Users
                             on cs.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = cs.Id,
                                 UserId = u.Id,
                                 CompanyName = cs.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status,

                             };
                return result.ToList();
            }
        }

        public CustomerDetailDto GetByEmail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from cs in context.Customers
                             join u in context.Users
                             on cs.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = cs.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = cs.CompanyName,
                                 FindexPoint = cs.CustomerFindexPoint
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}

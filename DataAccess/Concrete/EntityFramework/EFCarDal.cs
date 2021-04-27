using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in filter==null?context.Cars:context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             //join ci in context.CarImages
                             //on c.CarId equals ci.CarId
                             select new CarDetailDto
                             {
                                 Id = c.CarId,
                                // CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CarFindexPoint = c.CarFindexPoint,
                                 ImagePath = (from carImage in context.CarImages where carImage.CarId == c.CarId select carImage.ImagePath).FirstOrDefault(),
                             };



                return result.ToList();
            }
        }
    }
}

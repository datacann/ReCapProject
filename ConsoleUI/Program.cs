using Business.Concrete;
using DataAccess.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EFCarDal());
            //Car car1 = new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = "2013", Description = "öğretmenden temiz" };
            //Car car2 = new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 0, ModelYear = "2013", Description = "a" };

            //carManager.Add(car1);
            //carManager.Add(car2);

            //Console.WriteLine(carManager);


            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());




            //Car car1 = new Car { CarId = 6, Description = "aaaa", BrandId = 5, ColorId = 5, DailyPrice = 32, ModelYear = "1999" };
            //carmanager.Add(car1);
            //foreach (var car in carmanager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //CarManager carManager = new CarManager(new EFCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId);
            //}


            
            {
                Rental rental2 = new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now };
                RentalManager rentalManager = new RentalManager(new EFRentalDal());

                rentalManager.Add(rental2);
            }

        }
    }


}
    


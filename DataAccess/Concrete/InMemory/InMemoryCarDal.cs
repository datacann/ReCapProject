using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ CarId = 1, BrandId = "ford", ColorId = "black", DailyPrice = 100000 , ModelYear="2013", Description ="öğretmenden temiz" },
            new Car{ CarId = 2, BrandId = "renault", ColorId = "gray", DailyPrice = 85000 , ModelYear="2013", Description ="ağır hasar kayıtlı" },
            new Car{ CarId = 3, BrandId = "opel", ColorId = "brown", DailyPrice = 150000 , ModelYear="2013", Description = "doktordan az kullanılmış"},
            new Car{ CarId = 4, BrandId = "tesla", ColorId = "black", DailyPrice = 600000 , ModelYear="2013", Description ="10000 km de boyasız hasarsız" },
            new Car{ CarId = 5, BrandId = "fiat", ColorId = "green", DailyPrice = 110000 , ModelYear="2013", Description ="boyalı hasar kayıtlı 65000 km de" }

        };
        }
        public void Add(Car car)
        {

            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}

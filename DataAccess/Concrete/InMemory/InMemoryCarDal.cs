using DataAccess.Abstract;
using Entities1.Concrete;
using Entities1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
        public class InMemoryCarDal : ICarDal
        {
            List<Car> _car;
            public InMemoryCarDal(Car car)
            {
                _car = new List<Car> {
                new Car{Id=1, BrandId=1,CarName = "BMW", ColorId=1, ModelYear=2018, DailyPrice=65000, Description="Çizik yok"},
                new Car{Id=2, BrandId=2,CarName = "Fiat", ColorId=1, ModelYear=2009, DailyPrice=85300, Description="Efsane"},
                new Car{Id=3, BrandId=3,CarName = "BMW", ColorId=1, ModelYear=2011, DailyPrice=25000, Description="İkinci el"},
                new Car{Id=4, BrandId=3,CarName = "Fiat", ColorId=2, ModelYear=2015, DailyPrice=50000, Description="Acil araç satışı"},
                new Car{Id=5, BrandId=3,CarName = "Fiat", ColorId=3, ModelYear=2020, DailyPrice=180000, Description="Nakit"}
            };
            }
            public List<Car> GetById(int id)
            {
                return _car.Where(c => c.Id == id).ToList();
            }
            public List<Car> GetAll()
            {
                return _car;
            }
            public void Add(Car car)
            {
                _car.Add(car);
            }
            public void Update(Car car)
            {
                Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
            public void Delete(Car car)
            {
                Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
                _car.Remove(carToDelete);
            }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsDto(Expression<Func<Car, bool>> filter = null)
        {
            return GetCarDetailsDto();
        }
    }
}

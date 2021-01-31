﻿using DataAccess1.Abstract
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess1.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal(Car car)
        {
            _car = new List<Car> { 
                new Car{Id=1, BrandId="A", ColoId="Black", ModelYear=2018, DailyPrice=65000, Description="Çizik yok"},
                new Car{Id=2, BrandId="B", ColoId="White", ModelYear=2009, DailyPrice=85300, Description="Efsane"},
                new Car{Id=3, BrandId="C", ColoId="Blue", ModelYear=2011, DailyPrice=25000, Description="İkinci el"},
                new Car{Id=4, BrandId="D", ColoId="Red", ModelYear=2015, DailyPrice=50000, Description="Acil araç satışı"},
                new Car{Id=5, BrandId="E", ColoId="Orange", ModelYear=2020, DailyPrice=180000, Description="Nakit"}
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
            Car carToUpdate = _car.SingleOrDefault(c=>c.Id == car.Id);
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
    }
}

using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByDailyPrice();
        List<Car> GetCarsByCarName();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int id);
    }
}

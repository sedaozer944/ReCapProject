using Business1.Abstract;
using DataAccess.Abstract;
using Entities1.Concrete;
using Entities1.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
             _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            _iCarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            return _iCarDal.GetCarDetailsDto();
        }

        public List<CarDetailDto> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetCarDetailsDto(b=>b.BrandId == id);
        }

        public List<CarDetailDto> GetCarsByColorId(int id)
        {
            return _iCarDal.GetCarDetailsDto(c=>c.ColorId == id);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}

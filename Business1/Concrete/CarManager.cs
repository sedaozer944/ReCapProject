using Business1.Abstract;
using Business1.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

           _iCarDal.Add(car);

            return new SuccessResult("Araba eklendi");
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);

            return new SuccessResult("Araba Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return  new SuccessDataResult<List<Car>>(_iCarDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetailsDto());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            return new  SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetailsDto(b=>b.BrandId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetailsDto(c=>c.ColorId == id));
        }

        public IResult Update(Car car)
        {
           
            _iCarDal.Update(car);

            return new SuccessResult("Araba Güncellendi");
        }
    }
}

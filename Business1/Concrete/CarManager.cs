using Business1.Abstract;
using DataAccess1.Abstract;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
                return _iCarDal.GetAll();
        }
    }
}

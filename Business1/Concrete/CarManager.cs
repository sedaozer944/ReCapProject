using Business1.Abstract;
using DataAccess1.Abstract;
using Entities1.Concrete;
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

=======
>>>>>>> a90801a741536ceac8c538b836c04c1336197318
        public List<Car> GetAll()
        {
                return _iCarDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _iCarDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByCarName()
        {
            return _iCarDal.GetAll(p => p.CarName.Length >= 2);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetCarsByDailyPrice()
        {
            return _iCarDal.GetAll(p => p.DailyPrice > 0);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}

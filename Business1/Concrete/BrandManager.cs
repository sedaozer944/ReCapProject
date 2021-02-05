using Business1.Abstract;
using DataAccess1.Abstract;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetBrandsByBrandName()
        {
            return _brandDal.GetAll(b=>b.BrandName.Length >= 2);
        }

        public List<Brand> GetByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}

using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandsByBrandName();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetByBrandId(int id);
    }
}

using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}

using Core.Utilities.Results;
using Entities1.Concrete;
using Entities1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business1.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailDto();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}

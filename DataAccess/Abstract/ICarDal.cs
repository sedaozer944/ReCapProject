using Core.DataAccess;
using Entities1.Concrete;
using Entities1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetailsDto(Expression<Func<Car, bool>> filter = null);
    }
}

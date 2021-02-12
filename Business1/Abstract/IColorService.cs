using Core.Utilities.Results;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business1.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetColors();
    }
}

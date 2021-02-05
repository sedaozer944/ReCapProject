using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetColorsByColorName();
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetByColorId(int id);
    }
}

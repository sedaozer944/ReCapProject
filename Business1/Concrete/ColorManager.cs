using Business1.Abstract;
using DataAccess1.Abstract;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int id)
        {
            return _colorDal.GetAll(c=>c.ColorId == id);
        }

        public List<Color> GetColorsByColorName()
        {
            return _colorDal.GetAll(c=>c.ColorName.Length >= 2);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}

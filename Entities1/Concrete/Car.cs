using Entities1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.Concrete
{
    class Car:IEntity
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

    }
}

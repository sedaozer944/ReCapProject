using Entities1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.Concrete
{
    public class Brand : IEntity
    {
        public string  BrandName { get; set; }
        public int BrandId { get; set; }
    }
}

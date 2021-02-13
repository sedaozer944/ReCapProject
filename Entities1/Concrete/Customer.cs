using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.Concrete
{
    public class Customer : IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    } 
}

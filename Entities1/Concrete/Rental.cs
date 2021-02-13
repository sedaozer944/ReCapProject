using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int RentDate { get; set; }
        public int ReturnDate { get; set; }
    }
}

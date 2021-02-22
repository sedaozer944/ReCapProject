using Entities1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.ValidationRules.FluentValidation
{
    public class RentalValidator  : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).GreaterThan(0);
            RuleFor(r=> r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).NotEmpty();
        }
    }
}

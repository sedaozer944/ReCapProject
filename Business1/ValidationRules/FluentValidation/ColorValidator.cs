using Entities1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).MinimumLength(2);
            RuleFor(c => c.ColorName).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ColorId).GreaterThan(0); ;
        }
    }
}

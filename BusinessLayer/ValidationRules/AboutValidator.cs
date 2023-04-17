using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty...");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter at least 50 characters");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please select image.");
        }
    }
}

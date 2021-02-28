using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator: AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(ı => ı.CarId).NotEmpty().WithMessage("Fotoğrafa ait araç numarası boş bırakılamaz");
            RuleFor(ı => ı.ImagePath).NotEmpty();
            RuleFor(ı => ı.ImagePath).NotNull();
        }
    }
}

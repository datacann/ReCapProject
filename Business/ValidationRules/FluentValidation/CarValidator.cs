﻿using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            

            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
          //  RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.Description).MinimumLength(2);

            RuleFor(c => c.CarFindexPoint).GreaterThanOrEqualTo(0);
            RuleFor(c => c.CarFindexPoint).LessThanOrEqualTo(1900);

        }

    }
}


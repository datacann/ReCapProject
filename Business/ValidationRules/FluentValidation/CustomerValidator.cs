using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.UserId).NotEmpty();
            RuleFor(cu => cu.Id).NotEmpty();
            RuleFor(cu => cu.CompanyName).NotEmpty();
            RuleFor(customer => customer.CustomerFindexPoint).GreaterThan(0);
            RuleFor(customer => customer.CustomerFindexPoint).LessThanOrEqualTo(1900);
        }
    }
}

using FluentValidation;
using Group15.EventManager.Application.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.Validation.Accounts
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {
        public RegisterValidator()
        {
            RuleFor(reg => reg.Email).EmailAddress().NotEmpty();
            RuleFor(reg => reg.Password).NotEmpty().MinimumLength(8);
            RuleFor(reg => reg.FirstName).NotEmpty().MaximumLength(50);
            RuleFor(reg => reg.LastName).NotEmpty().MaximumLength(50);
            RuleFor(reg => reg.PhoneNumber).NotEmpty().MinimumLength(8);
        }
    }
}

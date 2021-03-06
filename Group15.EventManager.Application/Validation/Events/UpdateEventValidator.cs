﻿using FluentValidation;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;

namespace Group15.EventManager.ApplicationLayer.Validation.Events
{
    public class UpdateEventValidator : AbstractValidator<UpdateEventViewModel>
    {
        public UpdateEventValidator()
        {
            RuleFor(e => e.Name).NotEmpty().MaximumLength(350);
            RuleFor(e => e.Price).GreaterThan(0).LessThan(999999);
            RuleFor(e => e.EventDate).NotEmpty().GreaterThan(DateTime.Today);
        }
    }
}

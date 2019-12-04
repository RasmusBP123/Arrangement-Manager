using FluentValidation;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;

namespace Group15.EventManager.Application.Validation.Events
{
    public class CreateEventValidator : AbstractValidator<CreateEventViewModel>
    {
        public CreateEventValidator()
        {
            RuleFor(e => e.Name).NotEmpty().MaximumLength(350);
            RuleFor(e => e.Price).GreaterThan(0).LessThan(999999);
            RuleFor(e => e.EventDate).NotEmpty().GreaterThan(DateTime.Today);
            RuleFor(e => e.LastBookingDate).NotEmpty().LessThan(e => e.EventDate);
        }
    }
}

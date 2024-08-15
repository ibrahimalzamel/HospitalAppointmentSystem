using Application.Features.Appointments.Commands.Add;
using FluentValidation;

namespace Application.Features.Appointments.Validations
{
    public class AddAppointmentCommandValidator : AbstractValidator<AddAppointmentCommand>
    {
        public AddAppointmentCommandValidator()
        {
            RuleFor(x => x.AppointmentIntervalId).NotEmpty();
            RuleFor(x => x.PatientId).NotEmpty();
        }
    }
}

using Application.Features.Appointments.Queries.GetPaginatedAppointmentsByPatient;
using Core.Persistence.Paging;

namespace Application.Features.Appointments.Queries.GetPaginatedPatientById
{
    public class GetPaginatedAppointmentsPatientByIdResponse
    {
        public IPaginate<AppointmentPatientDto> Appointments
        {
            get; set;
        }
    }
}

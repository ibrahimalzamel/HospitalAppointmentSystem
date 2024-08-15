using Application.Features.Appointments.Queries.GetPaginatedAppointmentsByPatient;
using Core.Persistence.Paging;

namespace Application.Features.Appointments.Queries.GetPaginatedPatientByDoctorId
{
    public class GetPaginatedAppointmentsByPatientAndAuthDoctorResponse
    {
        public IPaginate<AppointmentPatientDto> Appointments { get; set; }
    }
}

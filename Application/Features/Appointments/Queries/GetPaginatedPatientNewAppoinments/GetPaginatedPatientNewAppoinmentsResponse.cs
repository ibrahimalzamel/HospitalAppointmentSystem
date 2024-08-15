using Application.Features.Appointments.Queries.GetPaginatedPatientAppoinments;
using Core.Persistence.Paging;

namespace Application.Features.Appointments.Queries.GetPaginatedPatientNewAppoinments
{
    public class GetPaginatedPatientNewAppoinmentsResponse
    {
        public IPaginate<PatientAppointmentDto> PatientAppointments { get; set; }
    }
}

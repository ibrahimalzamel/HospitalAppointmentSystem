using Application.Features.Appointments.Queries.GetPaginatedPatientAppoinments;
using Core.Persistence.Paging;

namespace Application.Features.Appointments.Queries.GetPaginatedPatientOldAppoinments
{
    public class GetPaginatedPatientOldAppoinmentsResponse
    {
        public IPaginate<PatientAppointmentDto> PatientAppointments { get; set; }
    }
}

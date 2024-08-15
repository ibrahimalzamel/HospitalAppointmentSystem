using Core.Domain;

namespace Application.Features.Appointments.Dtos
{
    public class AppointmentDto : IEntity
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime IntervalDate { get; set; }
        public string AppointmentStatus { get; set; }
    }
}

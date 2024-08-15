using Core.Domain;

namespace Application.Features.Appointments.Dtos
{
    public class DoctorAppointmentDto : IEntity
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public short BranchId { get; set; }
        public string BranchName { get; set; }
        public string AppointmentStatus { get; set; }
        public DateTime IntervalDate { get; set; }

    }
}

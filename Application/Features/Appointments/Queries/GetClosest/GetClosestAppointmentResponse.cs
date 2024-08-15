namespace Application.Features.Appointments.Queries.GetClosest
{
    public class GetClosestAppointmentResponse
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

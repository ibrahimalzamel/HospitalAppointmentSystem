namespace Application.Features.Appointments.Queries.GetPatientDashboardModel
{
    public class GetPatientDashboardModelResponse
    {
        public int TotalAppointment { get; set; }
        public int CanceledAppointment { get; set; }
        public int CompletedAppointment { get; set; }
        public int WaitinAppointment { get; set; }
    }
}

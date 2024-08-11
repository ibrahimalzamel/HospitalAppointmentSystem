using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class AppointmentSystemContext : DbContext
    {
        public AppointmentSystemContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentInterval> AppointmentIntervals { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<DoctorSchedule> DoctorSchedules { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Domain.Entities.OperationClaim> OperationClaims { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Domain.Entities.UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<VerificationCode> VerificationCodes { get; set; }
        public DbSet<CodeType> CodeTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
    }
}

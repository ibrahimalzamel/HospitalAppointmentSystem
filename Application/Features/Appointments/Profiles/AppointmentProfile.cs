using Application.Features.Appointments.Commands.Add;
using Application.Features.Appointments.Dtos;
using Application.Features.Appointments.Queries.GetAppointmentsForCurrentDayByDoctor;
using Application.Features.Appointments.Queries.GetClosest;
using AutoMapper;

namespace Application.Features.Appointments.Profiles
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Domain.Entities.Appointment, AddAppointmentCommand>().ReverseMap();
            CreateMap<Domain.Entities.Appointment, AddAppointmentResponse>().ReverseMap();

            CreateMap<Domain.Entities.Appointment, AppointmentDto>()
           .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.Patient.Id))
           .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.FirstName + " " + src.Patient.LastName))
           .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate))
           .ForMember(dest => dest.AppointmentStatus, opt => opt.MapFrom(src => src.AppointmentStatus.Name)); // Appointment tablosundaki status


            CreateMap<Domain.Entities.Appointment, AppointmentPatientDto>()
            .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Id))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.FirstName + " " + src.AppointmentInterval.Doctor.LastName))
            .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Id))
            .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Name))
            .ForMember(dest => dest.TitleId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Title.Id))
            .ForMember(dest => dest.TitleName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Title.Name))
            .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate))
            .ForMember(dest => dest.AppointmentStatus, opt => opt.MapFrom(src => src.AppointmentStatus.Name)); // Appointment tablosundaki status

            CreateMap<Domain.Entities.Appointment, DoctorAppointmentDto>()
            .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Id))
           .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Title.Name + " " + src.AppointmentInterval.Doctor.FirstName + " " + src.AppointmentInterval.Doctor.LastName))
           .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Id))
           .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Name))
           .ForMember(dest => dest.AppointmentStatus, opt => opt.MapFrom(src => src.AppointmentStatus.Name))
           .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate));

            CreateMap<Domain.Entities.Appointment, PatientAppointmentDto>()
           .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Id))
           .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Title.Name + " " + src.AppointmentInterval.Doctor.FirstName + " " + src.AppointmentInterval.Doctor.LastName))
           .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Id))
           .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Name))
           .ForMember(dest => dest.AppointmentStatus, opt => opt.MapFrom(src => src.AppointmentStatus.Name))
           .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate));

            CreateMap<Domain.Entities.Appointment, GetClosestAppointmentResponse>()
            .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Id))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Title.Name + " " + src.AppointmentInterval.Doctor.FirstName + " " + src.AppointmentInterval.Doctor.LastName))
            .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Id))
            .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.AppointmentInterval.Doctor.Branch.Name))
            .ForMember(dest => dest.AppointmentStatus, opt => opt.MapFrom(src => src.AppointmentStatus.Name))
          .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate));

            CreateMap<Domain.Entities.Appointment, GetAppointmentsForCurrentDayByDoctorResponse>()
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.FirstName + " " + src.Patient.LastName))
                .ForMember(dest => dest.IntervalDate, opt => opt.MapFrom(src => src.AppointmentInterval.IntervalDate))
                .ForMember(dest => dest.AppointmentStatusName, opt => opt.MapFrom(src => src.AppointmentStatus.Name));
        }
    }
}

using Application.Features.Appointments.Commands.Add;
using Application.Features.Appointments.Commands.AvailableByDoctor;
using Application.Features.Appointments.Commands.CancelByDoctor;
using Application.Features.Appointments.Commands.CancelByPatient;
using Application.Features.Appointments.Commands.CompleteByDoctor;
using Application.Features.Appointments.Queries.GetAdminDashboardModel;
using Application.Features.Appointments.Queries.GetAppointmentsForCurrentDayByDoctor;
using Application.Features.Appointments.Queries.GetClosest;
using Application.Features.Appointments.Queries.GetDoctorDashboardModel;
using Application.Features.Appointments.Queries.GetMonthlyAppointmentsByDoctor;
using Application.Features.Appointments.Queries.GetMonthlyAppointmentsByPatientId;
using Application.Features.Appointments.Queries.GetPaginatedAppointmentsByDoctor;
using Application.Features.Appointments.Queries.GetPaginatedAppointmentsByPatient;
using Application.Features.Appointments.Queries.GetPaginatedDoctorAppointments;
using Application.Features.Appointments.Queries.GetPaginatedPatientAppoinments;
using Application.Features.Appointments.Queries.GetPaginatedPatientByDoctorId;
using Application.Features.Appointments.Queries.GetPaginatedPatientNewAppoinments;
using Application.Features.Appointments.Queries.GetPaginatedPatientOldAppoinments;
using Application.Features.Appointments.Queries.GetPatientDashboardModel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class AppointmentController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddAppointmentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaginatedAppointmentsByDoctor([FromQuery] GetPaginatedAppointmentsByDoctorQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaginatedAppointmentsByPatient([FromQuery] GetPaginatedAppointmentsByPatientQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetPaginatedAppointmentsByPatientAndAuthDoctor([FromQuery] GetPaginatedAppointmentsByPatientAndAuthDoctorQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CancelAppointmentByPatient([FromQuery] CancelAppointmentByPatientCommand command)
        {

            var result = await _mediator.Send(command);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AvailableAppointmentByDoctor([FromBody] AvailableAppointmentByDoctorCommand command)
        {

            var result = await _mediator.Send(command);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CompleteAppointmentByDoctor([FromBody] CompleteAppointmentByDoctorCommand command)
        {

            var result = await _mediator.Send(command);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CancelAppointmentByDoctor([FromBody] CancelAppointmentByDoctorCommand command)
        {

            var result = await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetPaginatedPatientAppointments([FromQuery] GetPaginatedPatientAppointmentsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaginatedDoctorAppointments([FromQuery] GetPaginatedDoctorAppointmentsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetClosestAppointmentPatient([FromQuery] GetClosestAppointmentQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetPaginatedPatientNewAppoinments([FromQuery] GetPaginatedPatientNewAppoinmentsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetPaginatedPatientOldAppoinments([FromQuery] GetPaginatedPatientOldAppoinmentsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetMonthlyAppointmentsByPatient([FromQuery] GetMonthlyAppointmentsByPatientQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetMonthlyAppointmentsByDoctor([FromQuery] GetMonthlyAppointmentsByDoctorQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetPatientDashboardModel([FromQuery] GetPatientDashboardModelQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAdminDashboardModel([FromQuery] GetAdminDashboardModelQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetDoctorDashboardModel([FromQuery] GetDoctorDashboardModelQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAppointmentsForCurrentDayByDoctor([FromQuery] GetAppointmentsForCurrentDayByDoctorQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

    }

}

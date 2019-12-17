using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Attendances;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceApplicationService _attendanceApplicationService;

        public AttendanceController(IAttendanceApplicationService attendanceApplicationService)
        {
            _attendanceApplicationService = attendanceApplicationService;
        }

        [HttpPost]
        [Route("{eventId}/create")]
        public async Task<IActionResult> SubmitAttendanceAfterEvent([FromBody] CreateAttendanceViewModel attendanceViewModel)
        {
            await _attendanceApplicationService.SubmitAttendanceAfterEvent(attendanceViewModel);
            return Created("", attendanceViewModel);
        }
    }
}

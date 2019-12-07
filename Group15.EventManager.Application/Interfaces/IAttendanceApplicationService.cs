using Group15.EventManager.ApplicationLayer.ViewModels.Attendances;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IAttendanceApplicationService : IDisposable
    {
        Task SubmitAttendanceAfterEvent(CreateAttendanceViewModel attendance);
    }
}

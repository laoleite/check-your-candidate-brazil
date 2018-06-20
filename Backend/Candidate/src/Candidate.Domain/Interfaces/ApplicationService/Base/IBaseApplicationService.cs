using System.Collections.Generic;
using FluentValidator;

namespace Candidate.Domain.Interfaces.ApplicationService.Base
{
    public interface IBaseApplicationService
    {
        IEnumerable<Notification> ListNotifications();

        bool Commit();
    }
}
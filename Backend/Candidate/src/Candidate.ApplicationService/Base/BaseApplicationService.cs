using System.Collections.Generic;
using System.Linq;
using Candidate.Domain.Interfaces.ApplicationService.Base;
using Candidate.Domain.Interfaces.UnitOfWork;
using Candidate.Domain.Resources;
using FluentValidator;

namespace Candidate.ApplicationService.Base
{
    public class BaseApplicationService : Notifiable, IBaseApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        protected BaseApplicationService(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        public IEnumerable<Notification> ListNotifications()
            => Notifications;

        public bool Commit()
        {
            if (Notifications.Any())
                return false;

            var respose = _unitOfWork.Commit();

            if (respose.Success)
                return true;

            AddNotification("Commit", Messages.ERROR_COMMIT);

            return false;
        }
    }
}

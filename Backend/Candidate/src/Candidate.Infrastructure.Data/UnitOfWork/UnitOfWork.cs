using System;
using Candidate.Domain;
using Candidate.Domain.Interfaces.UnitOfWork;

namespace Candidate.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ActionResponse Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

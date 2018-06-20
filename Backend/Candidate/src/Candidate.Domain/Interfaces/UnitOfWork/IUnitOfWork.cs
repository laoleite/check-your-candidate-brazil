using System;

namespace Candidate.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ActionResponse Commit();
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}

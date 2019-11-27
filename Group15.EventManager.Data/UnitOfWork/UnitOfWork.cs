using Group15.EventManager.Data.Context;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Group15.EventManager.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlContext _context;

        public UnitOfWork(SqlContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

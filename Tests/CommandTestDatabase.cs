using Group15.EventManager.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class CommandTestDatabase : IDisposable
    {

        public CommandTestDatabase()
        {
            Context = DbContextApplicationFactory.Create();
        }

        public SqlContext Context { get; }

        public void Dispose()
        {
            DbContextApplicationFactory.Destroy(Context);
        }
    }
}

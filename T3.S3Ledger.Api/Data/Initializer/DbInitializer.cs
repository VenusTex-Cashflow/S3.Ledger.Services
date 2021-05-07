using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace T3.S3Ledger.Api.Data.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _dbContext;

        public DbInitializer(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            if (_dbContext.Database.GetPendingMigrations().Count() > 0)
            {
                try
                {
                    _dbContext.Database.AutoTransactionsEnabled = true;
                    _dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    //_dbContext.Database.RollbackTransaction();
                }
            }
        }
    }
}

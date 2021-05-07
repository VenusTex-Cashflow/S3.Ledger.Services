using T3.S3Ledger.Api.Data.Entities;
using T3.S3Ledger.Api.Data.Repository.Interface;

namespace T3.S3Ledger.Api.Data.Repository
{
    public class OrganizationRepository : Repository<Organization>, IOrganizationRepository
    {
        private readonly AppDbContext _dbContext;

        public OrganizationRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


    }
}

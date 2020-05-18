using TRASH.ApplicationServices.Ports.Gateways.Database;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Repositories
{
    public class DbTRASHRepository : IReadOnlyTRASHRepository,
                                     IRTRASHRepository
    {
        private readonly ITRASHDatabaseGateway _databaseGateway;

        public DbTRASHRepository(ITRASHDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<DomainObjects.TRASH> GetTRASH(long id)
            => await _databaseGateway.GetTRASH(id);

        public async Task<IEnumerable<DomainObjects.TRASH>> GetAllTRASH()
            => await _databaseGateway.GetAllTRASH();

        public async Task<IEnumerable<DomainObjects.TRASH>> QueryTRASH(ICriteria<DomainObjects.TRASH> criteria)
            => await _databaseGateway.QueryTRASH(criteria.Filter);

        public async Task AddTRASH(DomainObjects.TRASH trash)
            => await _databaseGateway.AddTRASH(trash);

        public async Task RemoveTRASH(DomainObjects.TRASH trash)
            => await _databaseGateway.RemoveTRASH(trash);

        public async Task UpdateTRASH(DomainObjects.TRASH trash)
            => await _databaseGateway.UpdateTRASH(trash);
    }
}

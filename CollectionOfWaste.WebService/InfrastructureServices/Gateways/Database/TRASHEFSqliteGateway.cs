using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using TRASH.ApplicationServices.Ports.Gateways.Database;

namespace TRASH.InfrastructureServices.Gateways.Database
{
    public class TRASHEFSqliteGateway : ITRASHDatabaseGateway
    {
        private readonly TRASHContext _trashContext;

        public TRASHEFSqliteGateway(TRASHContext trashContext)
            => _trashContext = trashContext;

        public async Task<DomainObjects.TRASH> GetTRASH(long id)
           => await _trashContext.TRASHs.FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.TRASH>> GetAllTRASH()
            => await _trashContext.TRASHs.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.TRASH>> QueryTRASH(Expression<Func<DomainObjects.TRASH, bool>> filter)
            => await _trashContext.TRASHs.Where(filter).ToListAsync();

        public async Task AddTRASH(DomainObjects.TRASH trash)
        {
            _trashContext.TRASHs.Add(trash);
            await _trashContext.SaveChangesAsync();
        }

        public async Task UpdateTRASH(DomainObjects.TRASH trash)
        {
            _trashContext.Entry(trash).State = EntityState.Modified;
            await _trashContext.SaveChangesAsync();
        }

        public async Task RemoveTRASH(DomainObjects.TRASH trash)
        {
            _trashContext.TRASHs.Remove(trash);
            await _trashContext.SaveChangesAsync();
        }


       
    }
}

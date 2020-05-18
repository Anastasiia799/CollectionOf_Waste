using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Ports.Gateways.Database
{
    public interface ITRASHDatabaseGateway
    {
        Task AddTRASH(DomainObjects.TRASH trash);

        Task RemoveTRASH(DomainObjects.TRASH trash);

        Task UpdateTRASH(DomainObjects.TRASH trash);

        Task<DomainObjects.TRASH> GetTRASH(long id);

        Task<IEnumerable<DomainObjects.TRASH>> GetAllTRASH();

        Task<IEnumerable<DomainObjects.TRASH>> QueryTRASH(Expression<Func<DomainObjects.TRASH, bool>> filter);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TRASH.DomainObjects.Ports
{
    public interface IReadOnlyTRASHRepository
    {
        Task<TRASH> GetTRASH(long id);

        Task<IEnumerable<TRASH>> GetAllTRASH();

        Task<IEnumerable<TRASH>> QueryTRASH(ICriteria<TRASH> criteria);

    }

    public interface IRTRASHRepository
    {
        Task AddTRASH(TRASH trash);

        Task RemoveTRASH(TRASH trash);

        Task UpdateTRASH(TRASH trash);
    }
}

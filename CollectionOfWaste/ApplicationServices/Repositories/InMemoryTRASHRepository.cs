using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Repositories
{
    public class InMemoryTRASHRepository : IReadOnlyTRASHRepository,
                                             IRTRASHRepository 
    {
        private readonly List<DomainObjects.TRASH> _trashs = new List<DomainObjects.TRASH>();

        public InMemoryTRASHRepository(IEnumerable<DomainObjects.TRASH> trashs = null)
        {
            if (trashs != null)
            {
                _trashs.AddRange(trashs);
            }
        }

        public Task AddTRASH(DomainObjects.TRASH trash)
        {
            _trashs.Add(trash);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<DomainObjects.TRASH>> GetAllTRASH()
        {
            return Task.FromResult(_trashs.AsEnumerable());
        }

        public Task<DomainObjects.TRASH> GetTRASH(long id)
        {
            return Task.FromResult(_trashs.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<DomainObjects.TRASH>> QueryTRASH(ICriteria<DomainObjects.TRASH> criteria)
        {
            return Task.FromResult(_trashs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveTRASH(DomainObjects.TRASH trash)
        {
            _trashs.Remove(trash);
            return Task.CompletedTask;
        }

        public Task UpdateTRASH(DomainObjects.TRASH trash)
        {
            var foundTRASH = GetTRASH(trash.Id).Result;
            if (foundTRASH == null)
            {
                AddTRASH(trash);
            }
            else
            {
                if (foundTRASH != trash)
                {
                    _trashs.Remove(foundTRASH);
                    _trashs.Add(trash);
                }
            }
            return Task.CompletedTask;
        }
    }
}

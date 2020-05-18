using System.Threading.Tasks;
using System.Collections.Generic;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using TRASH.ApplicationServices.Ports;

namespace TRASH.ApplicationServices.GetTRASHListUseCase
{
    public class GetTRASHListUseCase : IGetTRASHListUseCase
    {
        private readonly IReadOnlyTRASHRepository _readOnlyTRASHRepository;

        public GetTRASHListUseCase(IReadOnlyTRASHRepository readOnlyTRASHRepository) 
            => _readOnlyTRASHRepository = readOnlyTRASHRepository;

        public async Task<bool> Handle(GetTRASHListUseCaseRequest request, IOutputPort<GetTRASHListUseCaseResponse> outputPort)
        {
            IEnumerable<DomainObjects.TRASH> trashs = null;
            if (request.TRASHId != null)
            {
                var trash = await _readOnlyTRASHRepository.GetTRASH(request.TRASHId.Value);
                trashs = (trash != null) ? new List<DomainObjects.TRASH>() { trash } : new List<DomainObjects.TRASH>();
                
            }
            else if (request.TypeArea != null)
            {
                trashs = await _readOnlyTRASHRepository.QueryTRASH(new TypeAreaCriteria(request.TypeArea));
            }
            else
            {
                trashs = await _readOnlyTRASHRepository.GetAllTRASH();
            }
            outputPort.Handle(new GetTRASHListUseCaseResponse(trashs));
            return true;
        }
    }
}

using TRASH.DomainObjects;
using TRASH.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.ApplicationServices.GetTRASHListUseCase
{
    public class GetTRASHListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<DomainObjects.TRASH> TRASH { get; }

        public GetTRASHListUseCaseResponse(IEnumerable<DomainObjects.TRASH> trash) => TRASH = trash;
    }
}

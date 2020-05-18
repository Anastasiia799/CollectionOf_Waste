using TRASH.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.ApplicationServices.GetTRASHListUseCase
{
    public class GetTRASHListUseCaseRequest : IUseCaseRequest<GetTRASHListUseCaseResponse>
    {
        public string TypeArea { get; private set; }
        public long? TRASHId { get; private set; }

        private GetTRASHListUseCaseRequest()
        { }

        public static GetTRASHListUseCaseRequest CreateAllTRASHRequest()
        {
            return new GetTRASHListUseCaseRequest();
        }

        public static GetTRASHListUseCaseRequest CreateTRASHRequest(long trashId)
        {
            return new GetTRASHListUseCaseRequest() { TRASHId = trashId };
        }
        public static GetTRASHListUseCaseRequest CreateTypeAreaTRASHRequest(string trashs)
        {
            return new GetTRASHListUseCaseRequest() { TypeArea = trashs };
        }
    }
}

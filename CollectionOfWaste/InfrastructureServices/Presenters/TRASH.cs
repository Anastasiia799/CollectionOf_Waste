using TRASH.ApplicationServices.GetTRASHListUseCase;
using System.Net;
using Newtonsoft.Json;
using TRASH.ApplicationServices.Ports;

namespace TRASH.InfrastructureServices.Presenters
{
    public class TRASHListPresenter : IOutputPort<GetTRASHListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public TRASHListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetTRASHListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.TRASH) : JsonConvert.SerializeObject(response.Message);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TRASH.ApplicationServices.GetTRASHListUseCase;
using TRASH.InfrastructureServices.Presenters;

namespace TRASH.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TRASHController : ControllerBase
    {
        private readonly ILogger<TRASHController> _logger;
        private readonly IGetTRASHListUseCase _getTRASHListUseCase;

        public TRASHController(ILogger<TRASHController> logger,
                                IGetTRASHListUseCase getTRASHListUseCase)
        {
            _logger = logger;
            _getTRASHListUseCase = getTRASHListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTRASH()
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateAllTRASHRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{trashId}")]
        public async Task<ActionResult> GetTRASH(long trashId)
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateTRASHRequest(trashId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("TypeAreas/{typeArea}")]
        public async Task<ActionResult> GetTypeAreaFilter(string typeArea)
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateTypeAreaTRASHRequest(typeArea), presenter);
            return presenter.ContentResult;
        }
    }
}

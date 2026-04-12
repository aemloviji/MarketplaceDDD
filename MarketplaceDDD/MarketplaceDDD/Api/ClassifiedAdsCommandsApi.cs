using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketplaceDDD.Api
{
    [ApiController]
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : ControllerBase
    {
        private readonly ClassifiedAdsApplicationService _applicationService;

        public ClassifiedAdsCommandsApi(ClassifiedAdsApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Contracts.ClassifiedAds.V1.Create request)
        {
            _applicationService.Handle(request);

            return Ok();
        }
    }
}

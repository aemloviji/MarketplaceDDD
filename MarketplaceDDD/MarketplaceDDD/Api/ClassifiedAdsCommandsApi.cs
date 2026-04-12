using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketplaceDDD.Api
{
    [ApiController]
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(Contracts.ClassifiedAds.V1.Create request)
        {
            return Ok();
        }
    }
}

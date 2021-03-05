using System.Threading.Tasks;
using LiteArch.Lab.Apps.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LiteArch.Lab.Apps.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeedController: ControllerBase
    {
        private readonly ISeedService _seedService;

        public SeedController(ISeedService seedService)
        {
            _seedService = seedService;
        }

        [HttpPost]
        public async Task Post(SeedRequest request)
        {
            await _seedService.Seed(request.Key);
        }
    }
}
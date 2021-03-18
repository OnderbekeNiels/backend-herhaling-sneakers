using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Models;
using backend_herhaling_sneakers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend_herhaling_sneakers.Controllers
{
    [ApiController]
    [Route("api")]
    public class SneakerController : ControllerBase
    {
        private readonly ILogger<SneakerController> _logger;

        private ISneakerService _sneakerService;
        

        public SneakerController(ILogger<SneakerController> logger, ISneakerService sneakerService, IBlobStrorageService blobStorageService)
        {
            _logger = logger;
            _sneakerService = sneakerService;
        }

        [HttpGet]
        [Route("brands")]
        public async Task<ActionResult<List<Brand>>> GetBrands()
        {
            return await _sneakerService.GetBrands();
        }

        [HttpGet]
        [Route("occasions")]
        public async Task<ActionResult<List<Occasion>>> GetOccasions()
        {
            return await _sneakerService.GetOccasions();
        }

        [HttpPost]
        [Route("sneaker")]
        public async Task<ActionResult<Sneaker>> AddSneaker(Sneaker sneaker)
        {
            if (sneaker != null)
            {
                return await _sneakerService.AddSneaker(sneaker);
            }
            else
            {
                return new BadRequestResult();
            }

        }

        [HttpPost]
        [Route("sneaker/image/{sneakerId}")]
        public async Task<ActionResult<int>> AddSneaker(IFormFile image, Guid sneakerId)
        {
            await _sneakerService.AddSneakerImage(sneakerId, image);
            return 1;
        }
    }
}

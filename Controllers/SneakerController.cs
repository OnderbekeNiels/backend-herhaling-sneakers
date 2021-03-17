using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Models;
using backend_herhaling_sneakers.Services;
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

        public SneakerController(ILogger<SneakerController> logger, ISneakerService sneakerService)
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
    }
}

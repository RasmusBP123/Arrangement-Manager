using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionApplicationService _regionApplicationService;

        public RegionsController(IRegionApplicationService regionApplicationService)
        {
            _regionApplicationService = regionApplicationService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await _regionApplicationService.GetAllRegions();
            if (regions == null) return BadRequest();
            return Ok(regions);
        }

        [HttpGet]
        [Route("{regionId}")]
        public async Task<IActionResult> GetSingleRegion(Guid regionId)
        {
            var region = await _regionApplicationService.GetSingleRegion(regionId);
            if (region == null) return BadRequest();
            return Ok(region);
        }
    }
}
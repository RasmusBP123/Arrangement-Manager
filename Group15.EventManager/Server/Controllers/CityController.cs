using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityApplicationService _cityApplicationService;

        public CityController(ICityApplicationService cityApplicationService)
        {
            _cityApplicationService = cityApplicationService;
        }

        [HttpGet]
        [Route("{cityId}")]
        public async Task<IActionResult> GetSingleCity(Guid cityId)
        {
            var city = await _cityApplicationService.GetSingleCity(cityId);
            return Ok(city);
        }
    }
}
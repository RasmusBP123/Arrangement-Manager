using Group15.EventManager.ApplicationLayer;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreApplicationService _storeApplicationService;

        public StoreController(IStoreApplicationService storeApplicationService)
        {
            _storeApplicationService = storeApplicationService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateStore(CreateStoreViewModel storeViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _storeApplicationService.CreateStore(storeViewModel);
            return Ok();
        }
    }
}
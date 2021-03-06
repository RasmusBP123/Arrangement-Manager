﻿using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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

        [HttpGet()]
        public async Task<IActionResult> GetAllStores()
        {
            var stores = await _storeApplicationService.GetAllStores();
            return Ok(stores);
        }

        [HttpGet]
        [Route("{storeId}")]
        public async Task<IActionResult> GetSingleStore([FromRoute] Guid storeId)
        {
            var store = await _storeApplicationService.GetSingleStore(storeId);
            return Ok(store);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateStore(CreateStoreViewModel storeViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _storeApplicationService.CreateStore(storeViewModel);
            return Created("api/store/create", storeViewModel);
        }
    }
}
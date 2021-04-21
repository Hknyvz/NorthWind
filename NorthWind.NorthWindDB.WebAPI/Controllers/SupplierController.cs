using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using NorthWind.NorthWindDB.WebAPI.NorthWindApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        NorthWindApiService northWindApiService;
        public SupplierController(NorthWindApiService northWindApiService)
        {
            this.northWindApiService = northWindApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                var responses = await northWindApiService.GetEntitiesAsync<Suppliers>(id);
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Suppliers>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Suppliers supplier)
        {
            return Ok(await northWindApiService.AddEntityAsync(supplier));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] Suppliers supplier)
        {
            return Ok(await northWindApiService.UpdateEntityAsync(supplier));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await northWindApiService.DeleteEntityAsync<Suppliers>(id));
        }
    }
}

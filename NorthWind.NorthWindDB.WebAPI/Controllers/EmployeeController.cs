using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using NorthWind.NorthWindDB.WebAPI.NorthWindApi;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        NorthWindApiService northWindApiService;
        public EmployeeController(NorthWindApiService northWindApiService)
        {
            this.northWindApiService = northWindApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                var responses = await northWindApiService.GetEntitiesAsync<Employess>(id);
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Employess>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Employess employee)
        {
            return Ok(await northWindApiService.AddEntityAsync(employee));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] Employess employee)
        {
            return Ok(await northWindApiService.UpdateEntityAsync(employee));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await northWindApiService.DeleteEntityAsync<Employess>(id));
        }
    }
}

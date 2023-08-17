using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Domain.DTO;
using RestaurantAPI.Services;
using System.Data;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientsController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientCreateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var returnObj = await _clientService.Create(postModel);
                if (!returnObj.Success)
                    return BadRequest(returnObj.Message);
                else
                    return Ok(returnObj);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageQueryRequest filterRequest)
        {
            var returnObj = await _clientService.GetAll(filterRequest);

            if (returnObj.Success)
                return Ok(returnObj);
            else
                return BadRequest(returnObj);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var returnObj = await _clientService.GetById(id);

            if (returnObj.Success)
                return Ok(returnObj.ReturnObject);
            else
                return NotFound(returnObj);
        }
    }
}

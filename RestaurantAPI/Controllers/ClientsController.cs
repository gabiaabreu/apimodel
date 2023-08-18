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
                var response = await _clientService.Create(postModel);
                if (!response.Success)
                    return BadRequest(response.Message);
                else
                    return Ok(response.ReturnObject);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageQueryRequest filterRequest)
        {
            var response = await _clientService.GetAll(filterRequest);

            if (response.Success)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _clientService.GetById(id);

            if (response.Success)
                return Ok(response.ReturnObject);
            else
                return NotFound(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClientUpdateRequest putModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.Update(id, putModel);
                if (!response.Success)
                    return NotFound(response.Message);
                return Ok(response.ReturnObject);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("status/{id}")]
        public async Task<IActionResult> PutStatus(int id)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.SwitchStatus(id);
                if (!response.Success)
                    return NotFound(response.Message);
                return Ok(response.ReturnObject);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}

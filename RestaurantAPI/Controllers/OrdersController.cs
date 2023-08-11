using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Services;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersService orderService;
        public OrdersController(OrdersService orderService)
        {
            this.orderService = orderService;
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] OrderCreateRequest postModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var returnObj = orderService.Create(postModel);
        //        if (!returnObj.Success)
        //            return BadRequest(returnObj.Message);
        //        else
        //            return Ok(returnObj);
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState);
        //    }

        //}
    }
}

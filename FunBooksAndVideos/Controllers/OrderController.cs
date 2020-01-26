using System;
using FunBooksAndVideos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunBooksAndVideos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // POST: api/Order
        [HttpPost("ProcessOrder")]
        public ActionResult ProcessOrder([FromBody] PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    purchaseOrder.ProcessOrder();
                    return StatusCode(StatusCodes.Status200OK);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

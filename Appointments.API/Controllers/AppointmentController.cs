using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Appointments.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
       

        [HttpGet]
        public IActionResult GetAppt()
        {
            if (1==1) {
                return Ok(new
                {
                    Time = DateTime.Now
                });
            }
            else if (1==2)
            {
                
                return BadRequest();
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddAppt(sReqDate)
        {
            if (1 == 1)
            {
                return Ok(new
                {
                    Time = DateTime.Now
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
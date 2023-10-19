using Microsoft.AspNetCore.Mvc;
using TddApp;
using TddWebApp.Models;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiceaLogicController : ControllerBase
    {
        public LiceaLogicController(){}

        [HttpGet(Name = "LiceaLogicController")]
        public IActionResult Get(int a, int b, int c, int d)
        {
            var logicService = new LiceaService();
            var result=  logicService.MySuperLogic(a, b, c, d);
            var response = new JsonResponseDto
            {
                message="",
                data=result
            };
            return Ok(response);
        }
    }
}
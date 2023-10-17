using Microsoft.AspNetCore.Mvc;
using TddApp;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("[API]")]
    public class VenturaLogicController : ControllerBase
    {

        private int _result;

        public VenturaLogicController(){}

        [HttpGet("{num1}/{num2}/{num3}/{num4}")]
        public IActionResult Get(int num1,int num2, int num3 int num4)
        {
            try
            {
                var venturaService = new VenturaService();
                int result = venturaService.MySuperLogic(a, b, c, d);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
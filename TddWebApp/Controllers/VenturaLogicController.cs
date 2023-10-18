using Microsoft.AspNetCore.Mvc;
using TddApp;
using TddWebApp.Models;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("api")]
    public class VenturaLogicController : ControllerBase
    {

        private readonly VenturaService _venturaService;

        private ResponseModel _responseModel;

        public VenturaLogicController()
        {
            _venturaService = new VenturaService();
            _responseModel = new ResponseModel();
        }

        [HttpGet("{num1}/{num2}/{num3}/{num4}")]
        public ActionResult<ResponseModel> Get(int num1, int num2, int num3 , int num4)
        {
            try
            {
                var result = _venturaService.MySuperLogic(num1, num2, num3, num4);
                _responseModel.Result = result;
                return Ok(_responseModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TddApp;
using TddWebApp.Models;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //MODO NORMAAL
    public class DiazLogicController : ControllerBase
    {
        private readonly IDiazService _diazService;

        public DiazLogicController(IDiazService diazService)
        {
            _diazService = diazService;
        }

        [HttpGet(Name = "DiazLogicController")]
        public ResponseModel Get(int a,int b, int c, int d)
        {
            return _diazService.MySuperLogic(a,b,c,d);
        }
    }
}
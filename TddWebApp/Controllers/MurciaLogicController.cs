using Microsoft.AspNetCore.Mvc;
using TddApp;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MurciaLogicController : ControllerBase
    {

        public MurciaLogicController(){}

        [HttpGet(Name = "MurciaLogicController")]
        public int Get(int a,int b, int c, int d)
        {
            //var logicService = new LogicService();
            //return logicService.MySuperLogic(a,b,c,d);
            return 1;
        }
    }
}
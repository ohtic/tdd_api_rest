using Microsoft.AspNetCore.Mvc;
using TddApp;

namespace TddWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EsteveLogicController : ControllerBase
    {

        public EsteveLogicController(){}

        [HttpGet(Name = "EsteveLogicController")]
        public int Get(int a,int b, int c, int d)
        {
            //var logicService = new LogicService();
            //return logicService.MySuperLogic(a,b,c,d);
            return 1;
        }
    }
}
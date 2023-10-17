using System.Net;

namespace TddWebApp.Exceptions
{
    public class ApiException:Exception
    {
        public ApiException(string message,HttpStatusCode httpStatus):base(message) { }
        
    }
}

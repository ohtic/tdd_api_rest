using System.Net;
using System.Net.Mail;

namespace TddWebApp.Exceptions
{
    public class ApiException : Exception
    {
        public int HttpStatus { get; }

        public ApiException(int httpStatus, string message) : base(message)
        {
            HttpStatus = httpStatus;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace YourNamespace.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string path = "errors.txt"; // writes to root folder
            File.AppendAllText(path, $"{DateTime.Now}: {context.Exception.Message}\n");

            context.Result = new ObjectResult("Internal server error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}

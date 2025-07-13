using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab3_CustomModelFilters.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionMessage = $"Exception: {context.Exception.Message}";
            File.AppendAllText("logs.txt", exceptionMessage + Environment.NewLine);

            context.Result = new ObjectResult("An error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}

using System;
using System.Web.Http.Filters;

namespace Poc.Docker.OrderApi.Filter
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Console.WriteLine(actionExecutedContext.Exception);

            base.OnException(actionExecutedContext);
        }
    }
}
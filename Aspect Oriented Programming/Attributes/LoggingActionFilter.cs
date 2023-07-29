using Microsoft.AspNetCore.Mvc.Filters;

namespace Aspect_Oriented_Programming.Attributes
{
    public class LoggingActionFilter : ActionFilterAttribute
    {
        private readonly ILogger _logger;
        public LoggingActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("LoggingActionFilter");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("ClassFilter OnActionExecuting");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("ClassFilter OnActionExecuted");
            base.OnActionExecuted(context);

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            _logger.LogInformation("ClassFilter OnResultExecuting");
            base.OnResultExecuting(context);

        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            _logger.LogInformation("ClassFilter OnResultExecuted");
            base.OnResultExecuted(context);
        }

    }
}

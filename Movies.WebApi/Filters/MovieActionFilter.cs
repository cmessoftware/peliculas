using Microsoft.AspNetCore.Mvc.Filters;

namespace Movies.Web.Filters
{
    public class MovieActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}

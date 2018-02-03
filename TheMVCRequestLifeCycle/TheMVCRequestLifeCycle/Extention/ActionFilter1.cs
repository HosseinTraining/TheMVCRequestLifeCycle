using System.Web;
using System.Web.Mvc;

namespace TheMVCRequestLifeCycle.Extention
{
    public class ActionFilter1 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 1 <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 1 <br/>";
        }
    }

    public class ActionFilter2 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 2 <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 2 <br/>";
        }
    }

    public class ActionFilter3 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 3 <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 3 <br/>";
        }
    }

    public class AuthorizationFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Authorize Attribute <br/>";
        }
    }
}
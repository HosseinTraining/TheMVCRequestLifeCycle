using System.Web;
using System.Web.Mvc;

namespace TheMVCRequestLifeCycle.Extention
{
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
}
using System.Web;
using System.Web.Mvc;

namespace TheMVCRequestLifeCycle.Extention
{
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
}
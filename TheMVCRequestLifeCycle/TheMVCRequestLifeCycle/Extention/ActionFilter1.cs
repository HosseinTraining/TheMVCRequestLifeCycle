﻿using System.Web;
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
}
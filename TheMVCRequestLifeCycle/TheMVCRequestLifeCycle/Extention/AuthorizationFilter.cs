using System.Web;
using System.Web.Mvc;

namespace TheMVCRequestLifeCycle.Extention
{
    public class AuthorizationFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Authorize Attribute <br/>";
        }
    }
}
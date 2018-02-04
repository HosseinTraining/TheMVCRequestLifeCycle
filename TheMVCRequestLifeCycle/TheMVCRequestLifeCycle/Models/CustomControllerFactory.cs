using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using TheMVCRequestLifeCycle.Controllers;

namespace TheMVCRequestLifeCycle.Models
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Custom")
            {
                return new CustomController(new Logger());
            }
            else
            {
                return new HomeController();
            }
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            
        }
    }
}
using System.Web.Mvc;
using System.Web.Routing;
using TheMVCRequestLifeCycle.Models;

namespace TheMVCRequestLifeCycle.Controllers
{
    public class CustomeController : IController
    {
        private ILogger _logger;
        public CustomeController(ILogger logger)
        {
            _logger = logger;
        }
        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write(@"<!DOCTYPE html><html><head></head><body style='color:red;'>test html page</body></html>");

        }
    }
}
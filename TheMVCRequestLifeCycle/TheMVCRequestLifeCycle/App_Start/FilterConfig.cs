using System.Web;
using System.Web.Mvc;
using TheMVCRequestLifeCycle.Extention;

namespace TheMVCRequestLifeCycle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionFilter3());
        }
    }
}

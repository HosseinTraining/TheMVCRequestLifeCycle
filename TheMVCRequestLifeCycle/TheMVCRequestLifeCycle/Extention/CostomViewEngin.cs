using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheMVCRequestLifeCycle.Extention
{
    public class CostomViewEngin : RazorViewEngine
    {
        public CostomViewEngin()
        {
            ViewLocationFormats = new string[] { "~/Theme/{1}/{0}.cshtml" };
            PartialViewLocationFormats = new string[] { "~/Theme/{1}/{0}.cshtml" };
        }
    }
}
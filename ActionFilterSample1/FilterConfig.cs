using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterSample1
{
    public class FilterConfigSample
    {
       public static void RegisterAction(GlobalFilterCollection fil)
        {
            fil.Add(new TestActionFilter());
        }
    }
}
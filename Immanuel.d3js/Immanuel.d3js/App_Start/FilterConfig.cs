﻿using System.Web;
using System.Web.Mvc;

namespace Immanuel.d3js
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

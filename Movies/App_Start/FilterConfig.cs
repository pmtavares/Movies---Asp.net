using System.Web;
using System.Web.Mvc;

namespace Movies
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //This filter is a general filter for the application
            filters.Add(new RequireHttpsAttribute()); //With this the application no longer will be availble on hhtp channel
        }
    }
}

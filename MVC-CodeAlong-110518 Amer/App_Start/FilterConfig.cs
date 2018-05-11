using System.Web;
using System.Web.Mvc;

namespace MVC_CodeAlong_110518_Amer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace PasajeDatosClase06Oct
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

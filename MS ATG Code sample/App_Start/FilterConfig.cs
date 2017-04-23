using System.Web;
using System.Web.Mvc;

namespace MS_ATG_Code_sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

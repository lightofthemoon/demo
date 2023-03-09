using System.Web;
using System.Web.Mvc;

namespace Chieu3_Tuan4_2011064460_NguyenTrongQuy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

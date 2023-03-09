using Chieu3_Tuan4_2011064460_NguyenTrongQuy.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Chieu3_Tuan4_2011064460_NguyenTrongQuy.Controllers
{
    public class HomeController : Controller
    {
        //phân trang
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index(int? page)
        {
            if(page == null)
            {
                page = 1;
            }
            var all_sach = (from ss in data.Saches select ss).OrderBy(m => m.masach);
            int pageSize = 3;//mỗi trang là 1 quyển
            int pageNum = page ?? 1;
            return View(all_sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
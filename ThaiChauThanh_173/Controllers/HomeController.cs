using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThaiChauThanh_173.Controllers
{
    public class HomeController : Controller
    {
        private Models.ModelThuephong dc = new Models.ModelThuephong();
        // GET: Home
        public ActionResult Index()
        {
            return View(dc.phongs.ToList());
        }
        public ActionResult xemChitiet(string id)
        {
            Models.phong p = dc.phongs.Find(id);
            return View(p);
        }
        //public ActionResult FormXoaPhong(string id)
        //{
        //    Models.phong p = dc.phongs.Find(id);
        //    ViewBag.Maphong = maphong;
        //    ViewBag.CoXoa = true;
        //    foreach (var a in dc.phongs.Where(x => x.maphong == id))
        //    {
        //        ViewBag.CoXoa = false;
        //        break;
        //    }
        //    return View();
        //}
        public ActionResult XoaPhong(string id)
        {
            Models.phong nsx = dc.phongs.Find(id);
            dc.phongs.Remove(nsx);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
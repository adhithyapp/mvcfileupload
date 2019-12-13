using fileupload2mvc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fileupload2mvc.Controllers
{
    public class AddController : Controller
    {

        DemoMVCEntities db = new DemoMVCEntities();
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tbl_add_user tu , HttpPostedFileBase file)
        {
            string myfile = file.FileName;
            tu.profile = myfile;
            var path = Path.Combine(Server.MapPath("~/upload/"), myfile);
            file.SaveAs(path);
            db.tbl_add_user.Add(tu);
            db.SaveChanges();
            return View();
        }
    }
}
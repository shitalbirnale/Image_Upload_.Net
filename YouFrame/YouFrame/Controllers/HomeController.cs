using BLL;

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.IO;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using BOL;

namespace YouFrame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Imagedb> img = ImageManager.GetAllImage();
            return View(img);
        }


        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase image)
        {
                bool status;
                string path = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                String imgpath= Path.GetFileName(image.FileName);
                image.SaveAs(path);

                status=ImageManager.insert(imgpath);
                return RedirectToAction("Index", "Home");
           
              
            
        }
       


       
    }
}
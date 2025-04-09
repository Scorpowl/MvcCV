using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;


namespace MvcCV.Controllers
    
{
    public class DefaultController : Controller
    {
        // GET: Default
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }public PartialViewResult Eğitimlerim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }public PartialViewResult Sertifikalar()
        {
            var sertifika = db.TblSertifikalarim.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(TblIletisim t)
        {
            db.TblIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphaneYonetim.Models.Entity;

namespace MvcKutuphaneYonetim.Controllers
{
    public class YazarController : Controller
    {
        DBKutuphaneYonetimEntities db = new DBKutuphaneYonetimEntities();

        // GET: Yazar
        public ActionResult Index()
        {
            var yazarlar = db.TableYazar.ToList();
            return View(yazarlar);
        }
        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(TableYazar y)
        {
            db.TableYazar.Add(y);
            db.SaveChanges();
            return View();
        }
    }
}
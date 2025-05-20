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

        public ActionResult YazarSil(int id)
        {
            var yazar = db.TableYazar.Find(id);
            db.TableYazar.Remove(yazar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarGuncelle(int id)
        {
            var yazar = db.TableYazar.Find(id);
            return View("YazarGuncelle" , yazar);
        }

        public ActionResult YazarKayitGuncelle(TableYazar yzr)
        {
            var yazar = db.TableYazar.Find(yzr.ID);

            yazar.AD = yzr.AD;
            yazar.SOYAD = yzr.SOYAD;
            yazar.DETAY = yzr.DETAY;
            db.SaveChanges();

            return RedirectToAction("Index");
            
        }

    }
}
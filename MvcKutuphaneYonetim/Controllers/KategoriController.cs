using MvcKutuphaneYonetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphaneYonetim.Controllers
{
    public class KategoriController : Controller
    {
        DBKutuphaneYonetimEntities db = new DBKutuphaneYonetimEntities();

        // GET: Kategori
        //[HttpGet]
        public ActionResult Index()
        {
            var kategoriler = db.TableKategori.ToList();
            return View(kategoriler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(TableKategori p) { 
            db.TableKategori.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult KategoriSil(int id) { 
            var kategori = db.TableKategori.Find(id);
            db.TableKategori.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGuncelle(int id) {
            var kategori = db.TableKategori.Find(id);
            return View("KategoriGuncelle",kategori);
        }

        public ActionResult KategoriKayitGuncelle(TableKategori p) {
            var kategori = db.TableKategori.Find(p.ID);
            kategori.AD = p.AD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
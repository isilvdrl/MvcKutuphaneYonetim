using MvcKutuphaneYonetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphaneYonetim.Controllers
{
    public class KitapController : Controller
    {
        DBKutuphaneYonetimEntities db=new DBKutuphaneYonetimEntities();

        // GET: Kitap
        public ActionResult Index()
        {   var kitaplar= db.TableKitap.ToList();
            return View(kitaplar);
        }
    }
}
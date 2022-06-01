using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class YeniController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            FormDB db = new FormDB();

            Kullanicilar model = new Kullanicilar();

            model.Sehir = form["Sehir"].Trim();

            model.Adi = form["Adi"].Trim();

            model.Soyadi = form["Soyadi"].Trim();

            db.Kullanicilar.Add(model);

            db.SaveChanges();

            return View();
        }

    }
}

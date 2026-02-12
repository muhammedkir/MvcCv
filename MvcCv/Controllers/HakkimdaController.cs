using MvcCv.Models;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkımda = repo.List();
            return View(hakkımda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            //TblHobilerim t = new TblHobilerim();
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
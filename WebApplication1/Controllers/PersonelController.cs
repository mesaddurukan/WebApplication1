using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(personel d)
        {
            c.Personels.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult PersonelSil(int id)
        {
            var per = c.Personels.Find(id);
            c.Personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult PersonelGetir(int id)
        {
            var personel = c.Personels.Find(id);
            return View("PersonelGetir", personel);
        }
        [HttpPost]
        public IActionResult PersonelGuncelle(personel d)
        {
            var per = c.Personels.Find(d.perid);
            per.ad = d.ad;
            per.soyad = d.soyad;
            per.sehir = d.sehir;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class departtController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.Departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
         
       }
        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departmanlars.Find(id);
            c.Departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Departmanlars.Find(id);
            return View("DepartmanGetir",depart);
            }
        [HttpPost]
        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c.Departmanlars.Find(d.id);
            dep.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        
    }
}

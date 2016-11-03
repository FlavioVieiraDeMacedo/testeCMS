using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCMS.Models;

namespace TesteCMS.Controllers
{
    public class HomeController : Controller
    {
        private TesteDbCmsEntities _context = new TesteDbCmsEntities();
        // GET: Home
        public ActionResult Home()
        {
            List<Textos> _lista = _context.Textos.ToList();
            return View(_lista);
        }
        [HttpGet]
        public ActionResult ConfiguraTxtHome()
        {
            var lista = new List<string>();
            lista.Add("Sobre");
            lista.Add("Quem Somos");
            lista.Add("Empresa");
            ViewBag.local = new SelectList(lista);
            return View();
        }
        [HttpPost]
        public ActionResult ConfiguraTxtHome(Textos t)
        {
            _context.Textos.Add(t);
            _context.SaveChanges();
            TempData["msg"] = "Texto Cadastrado";
            return RedirectToAction("ConfiguraTxtHome");
        }
    }
}
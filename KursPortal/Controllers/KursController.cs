using KursPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace KursPortal.Controllers
{
    public class KursController : Controller
    {

        private KursPortalDbContext CTX;


        public KursController(KursPortalDbContext ctx)
        {
            CTX = ctx;
        }

        public IActionResult Index()
        {
            var kurse = CTX.Kurse.Include(k => k.Lernziele).ToList();
            return View(kurse);
        }

        //public IActionResult Detail(int id)
        //{
        //    var kurs = CTX.Kurse.FirstOrDefault(k => k.ID == id);
        //    return View(kurs);
        //}
        public IActionResult Detail(int id)
        {
            var kurs = CTX.Kurse.Include(k => k.Lernziele).FirstOrDefault(k => k.ID == id);

            return View(kurs);

        }

        [HttpGet]


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                CTX.Kurse.Add(kurs);
                CTX.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(kurs);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var kurs = CTX.Kurse.FirstOrDefault(k => k.ID == id);
            return View(kurs);
        }

        [HttpPost]

        public ActionResult Edit(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                var kursDB = CTX.Kurse.FirstOrDefault(k => k.ID == kurs.ID);

                kursDB.KursName = kurs.KursName;
                kursDB.Dozent = kurs.Dozent;
                kursDB.AnzahlTeilnehmer = kurs.AnzahlTeilnehmer;
                kursDB.DauerInTagen = kurs.DauerInTagen;
                kursDB.Inhalt = kurs.Inhalt;
                kursDB.Beschreibung = kurs.Beschreibung;

                CTX.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kurs);
        }



        [HttpPost]

        public IActionResult Entfern(int id)
        {
            var kursDB = CTX.Kurse.FirstOrDefault(k => k.ID == id);

            CTX.Kurse.Remove(kursDB);
            CTX.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}

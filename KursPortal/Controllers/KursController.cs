using KursPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursPortal.Controllers
{
    public class KursController : Controller
    {

        private List<Kurs> kurse =
          [
              new Kurs
                {
                  
                  ID = 1,
                  KursName = "OOP C#",
                  Dozent = "Dennis Syntax",
                  AnzahlTeilnehmer = 1,
                  DauerInTagen = 1600,
                  Beschreibung = 
                  "In diesem Kurs lernst du die wichtigsten Grundlagen der objektorientierten Programmierung " +
                  "und wie du sie in echten Projekten einsetzen kannst.\r\n    " +
                  "Außerdem lernst du, warum dein Code gestern funktioniert hat, heute nicht mehr funktioniert " +
                  "und morgen plötzlich wieder funktioniert.",
                    
                  Inhalt =
                  "Du lernst, deinen Code sinnvoll zu strukturieren und wiederverwendbare " +
                  "Komponenten zu entwickeln. Und falls du am Ende 14 Klassen für eine einfache " +
                  "Taschenrechner-App erstellt hast: Keine Sorge, das nennt man Architektur.",

                  Lernziele = new() { "Klassen & Objekte", "Vererbung & Polymorphie", "Interfaces", "Exception Handling" }
                },

                new Kurs
                {
                    ID = 2,
                    KursName = "SQL",
                    Dozent = "Nico Query",
                    AnzahlTeilnehmer = 90,
                    DauerInTagen = 10,
                    Inhalt =
                 "Lerne, Daten zu speichern, abzurufen und mit beeindruckend komplizierten JOINs wiederzufinden. " +
                    "Keine Sorge: Irgendwann ergibt die Query schon Sinn."
                },

                new Kurs
                {
                    ID = 3,
                    KursName = "Web Development",
                    Dozent = "Pascal Overflow",
                    AnzahlTeilnehmer = 25,
                    DauerInTagen = 30,
                    Inhalt =
                 "HTML, CSS und JavaScript – die drei Säulen moderner Webentwicklung und der Grund, " +
                    "warum „bei mir funktioniert es“ kein akzeptierter Debugging-Ansatz ist."
                },
                new Kurs
                {
                      ID = 4,
                    KursName = "Software Testing",
                    Dozent = "David Debugger",
                    AnzahlTeilnehmer = 67,
                    DauerInTagen = 30,
                    Inhalt = "Finde heraus, ob dein Code funktioniert, bevor deine Nutzer es herausfinden."
                },
                new Kurs
                {
                      ID = 5,
                    KursName = "Git & Version Control",
                    Dozent = "Ben Branch",
                    AnzahlTeilnehmer = 420,
                    DauerInTagen = 45,
                    Inhalt = "Lerne, deine Änderungen zu versionieren, Branches zu erstellen und " +
                    "Merge-Konflikte so lange anzustarren, bis sie verschwinden."
                },
                new Kurs
                {
                      ID = 6,
                    KursName = "ASP.NET",
                    Dozent = "Chris Cache",
                    AnzahlTeilnehmer = 7,
                    DauerInTagen = 30,
                    Inhalt = "Entwickle moderne Webanwendungen mit ASP.NET. MVC inklusive, " +
                    "M für „Warum ist das Model hier?“ und C für „Keine Ahnung, frag den Controller“."
                }
                ];


        public IActionResult Index()
        {
            return View(kurse);
        }


        public IActionResult Detail(int id)
        {
            var kurs = kurse.FirstOrDefault(k => k.ID == id);
            return View(kurs);
        }

    }
}

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Moment1.Pages
{
    public class CoursesModel : PageModel
    {
        public List<string> Kurser { get; private set; }
        public DateTime Nu { get; private set; }
        public string Meddelande { get; private set; }

        public void OnGet()
        {
            // Lista med kurser
            Kurser = new List<string> { "dt057g, Webbutveckling I", "annanKurs, Kursnamn" };

            // Aktuellt datum och tid
            Nu = DateTime.Now;

            // Kontrollera om det är måndag
            Meddelande = Nu.DayOfWeek == DayOfWeek.Monday ? "Idag är det måndag" : "Idag är det inte måndag";
        }
    }
}

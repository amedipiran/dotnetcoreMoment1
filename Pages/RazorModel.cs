using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Moment1.Pages
{
    public class RazorModel : PageModel
    {
        public List<string> Courses { get; private set; }
        public DateTime Nu { get; private set; }
        public string Message { get; private set; }

        public void OnGet()
        {
            // Lista med kurser
            Courses = new List<string> { "DT057G, Webbutveckling I", "annanKurs, Kursnamn" };

            // Aktuellt datum och tid
            Nu = DateTime.Now;

            // Kontrollera om det är måndag
            Message = Nu.DayOfWeek == DayOfWeek.Monday ? "Idag är det måndag" : "Idag är det inte måndag";
        }
    }
}

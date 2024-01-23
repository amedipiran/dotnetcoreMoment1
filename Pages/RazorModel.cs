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
            Courses = new List<string> { "DT057G, Webbutveckling I", "DT093G, Webbutveckling II", "DT173G, Webbutveckling III", "DT084G, Introduktion till programmering i JavaScript", "DT200G, Grafisk teknik för Webb", "DT068G, Webbanvändbarhet", "DT003G, Databaser", "DT197G, Webbdesign för CMS", "IK60G, Projektledning", "DT193G, Fullstack-utveckling med ramverk", "DT162G, JavaScriptbaserad Webbutveckling", "DT071G, Programmering i C#.NET"  };

            // Aktuellt datum och tid
            Nu = DateTime.Now;

            // Kontrollera om det är måndag
            Message = Nu.DayOfWeek == DayOfWeek.Monday ? "Idag är det måndag" : "Idag är det inte måndag";
        }
    }
}

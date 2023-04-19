/*
    - Controller classes/files must end with the word Controller.
    - The class and method must be public to be accessed by the browser.
    - Controller page can be accessed via url https://localhost:44355/ComicBooks/Detail
                                                https://localhost:xxxxx/CntrlrName/MethodName
    - Controller methods are called actions.    


    - URL routing = url to controller action.
    - Many websites can be hosted on the same machine using different port numbers.


    - ActionResult is mom class of RedirectResult, ContentResult and ViewResult.
    - Controller base class provides methods Content(string) and Redirect(string)
        
        
    - View goes to folder Views/Shared/Detail.cshtml


    - Data is defined at the controller and sent to the view.
    - ViewBag provides is a dynamic for this communication.


    - ViewBag vs Strongly typed view
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   // System.Web.Mvc.Controller
using Comic_Book_Gallery.Models;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            return View(comicBook);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   // System.Web.Mvc.Controller

namespace Comic_Book_Gallery.Controllers
{
    /*
        - Controller classes/files must end with the word Controller.
        - The class and method must be public to be accessed by the browser.
        - Controller page can be accessed via url https://localhost:44355/ComicBooks/Detail
        -                                         https://localhost:xxxxx/CntrlrName/MethodName
     */
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "This is a test.\n I will be gone soon.\n Appriciate me while I'm here. \n Would you kindly?";
        }
    }
}
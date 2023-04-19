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
                                                  https://localhost:xxxxx/CntrlrName/MethodName
        - Controller methods are called actions.    


        - URL routing = url to controller action.
        - Many websites can be hosted on the same machine using different port numbers.


        - ActionResult is mom class of RedirectResult, ContentResult and ViewResult.
        - Controller base class provides methods Content(string) and Redirect(string)
        
        
        - View goes to folder Views/Shared/Detail.cshtml
     */
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();

        }
    }
}
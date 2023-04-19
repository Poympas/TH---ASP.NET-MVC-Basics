/*


    - Controller classes/files must end with the word Controller.
    - The class and method must be public to be accessed by the browser.
    - Controller page can be accessed via url https://localhost:44355/ComicBooks/Detail/Id
                                              https://localhost:xxxxx/CntrlrName/MthdName/Id (id is optional)
    - Controller methods are called actions.    


    - URL routing = url to controller action.
    - Many websites can be hosted on the same machine using different port numbers.
    - 


    - ActionResult is mom class of RedirectResult, ContentResult and ViewResult.
    - Controller base class provides methods Content(string) and Redirect(string)
        
        
    - View goes to folder Views/Shared/Detail.cshtml


    - Data is defined at the controller and sent to the view.
    - ViewBag provides is a dynamic for this communication.


    - ViewBag vs Strongly typed view.


    - int? makes int nullable.

    
    - HttpNotFound() returns an action result


    - Using the Debugger.
    - Step into/over/out.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   // System.Web.Mvc.Controller
using Comic_Book_Gallery.Data;
using Comic_Book_Gallery.Models;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);

        }
    }
}
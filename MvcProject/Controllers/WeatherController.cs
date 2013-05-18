using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Controllers;

namespace MvcProject.Controllers
{
    public class WeatherController : Controller
    {
        //
        // GET: /Weather/

        public ActionResult Index()
        {
            return View();
        }

        // Used to render the second window in the view
        public ViewResult RsvpForm()
        {
            return View();
        }

        
       
    }
}

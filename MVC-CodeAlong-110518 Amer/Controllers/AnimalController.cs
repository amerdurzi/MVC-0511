using MVC_CodeAlong_110518_Amer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CodeAlong_110518_Amer.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index()
        {
            return View(new Animal());
        }
        public ActionResult Details(Animal animal)
        {
            return View(animal);
        }
    }
}
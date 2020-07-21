using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVParte1.Models;
namespace MCVParte1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            Persona nuevaPersona = new Persona(30, "Sofia", "barreiro");


            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutenticacionPersonalizada.Models;
using AutenticacionPersonalizada.Utilidades;

namespace AutenticacionPersonalizada.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        PecesEntities db = new PecesEntities();

        // GET: Home
        public ActionResult Index()
        {
            var datos = db.Pez;
            return View(datos);
        }
    }
}
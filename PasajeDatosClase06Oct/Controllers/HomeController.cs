using Business;
using PasajeDatosClase06Oct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasajeDatosClase06Oct.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewData["Mensaje"] = "Bienvenidos a La Clase";

            ViewData["Edad"] = 30;

            ViewBag.MiMensaje = "Lo que yo quiera";

            ViewBag.MiEdad = 33;

            TempData["PasarInformacion"] = "Informacion";



            return RedirectToAction("About", new { id= 10 } );
        }

        public ActionResult About(int id)
        {
            if (Session["EmpleadoCliente"] != null)
            {
                EmpleadoClienteVM emvm = (EmpleadoClienteVM)Session["EmpleadoCliente"];
            }




            ViewBag.Message = "Your application description page.";

            string infor = TempData["PasarInformacion"].ToString();

            return View();
        }

        public ActionResult Frutas()
        {
            Fruta fruta1 = new Manzana();

            fruta1.MostrarColor();

            Fruta fruta2 = new Naranja();

            fruta2.MostrarColor();


            return View();



        }
    }
}
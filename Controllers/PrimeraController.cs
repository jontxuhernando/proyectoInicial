using hola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace hola2.Controllers
{
    public class PrimeraController : Controller
{





        public ActionResult VerClases()
        {
            Persona persona = new Persona("Pepe",20,"chico");
            ViewBag.Persona = persona;
            Persona persona1 = new Persona("Lucia",25,"chica");   
            ViewBag.Persona1 = persona1;
         

            return View();
        }


        public ActionResult VerDatosNuevos()
        {
          Profesor prof1 = new Profesor("Magisterio","Paco",58,"chico");
            ViewBag.Prof1 = prof1;
            Alumno al1 = new Alumno(8, "Carlos",18, "chico");
            ViewBag.Alumno1 = al1;


            return View();
        }







        public ActionResult Login()

    {
         
            Personas lista = new Personas();
            
            ViewBag.Persona=lista;

            //creo la lista de personas

            //  ViewBag.Persona






            ViewBag.lista = lista;
            ViewBag.Sexo = "chica";
            ViewBag.Nombre = "Maria";

            return View();
    }

    
        // GET: Primera
        public ActionResult Index()
        {
            return View();
        }

        

    }
}
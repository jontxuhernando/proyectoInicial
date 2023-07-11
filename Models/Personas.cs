using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hola2.Models
{
    public class Personas
    {
       private List<Personas> lista;
         
        public Personas(){



            this.lista = new List<Personas>();
            rellenar();


        }

        public void anadir(Personas p)
        {
            this.lista.Add(p); 
        }
        
        public void rellenar() {
        //p = new Persona("Jaime",20,"chico");
        }
    }


       /* public static Personas Buscar(String nombre)
    {
        foreach(Persona p in lista)
        {
            if(p.Nombre == nombre)
            {
                return p;
            }
        }*/
    





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hola2.Models
{
    public class Persona
    {
         String nombre;
         int edad;
         String sexo;

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = "";

        }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }


        public override string ToString()
        {
            return this.nombre + this.edad + this.sexo;
        }


    }

   

}
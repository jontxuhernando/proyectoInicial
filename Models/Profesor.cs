using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hola2.Models
{
    public class Profesor:Persona
    {
        String titulo;

        public Profesor():base() { 
        }


        public Profesor(string titulo, string nombre, int edad, string sexo) : base(nombre,edad,sexo)
        {
            this.titulo = titulo;   
        }

        public string Titulo { get => titulo; set => titulo = value; }
    }
}
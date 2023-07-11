using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hola2.Models
{
    public class Alumno: Persona
    {
        double notaMedia;

        public Alumno() : base()
        {
            this.notaMedia = 0.0;
        }
        public Alumno(double notaMedia,string nombre, int edad, string sexo ):base(nombre,edad,sexo)
        {
            this.notaMedia = notaMedia;
        }

        public double NotaMedia { get => notaMedia; set => notaMedia = value; }
    }
}
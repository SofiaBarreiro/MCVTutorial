using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCVParte1.Models
{
    public class Persona
    {

        private int edad;
        private string nombre;
        private string apellido;

        public Persona(int edad, string nombre, string apellido) {


            this.nombre = nombre;
            this.edad = edad;
            this.apellido = apellido;
        }


        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }



    }
}
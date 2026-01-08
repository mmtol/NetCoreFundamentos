using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }

        public Direccion() 
        {
            Debug.WriteLine("Constructor sin params");
        }

        public Direccion(string calle)
        {
            Calle = calle;
            Debug.WriteLine("Constructor con 1 param");
        }

        public Direccion(string calle, string ciudad)
        {
            Calle = calle;
            Ciudad = ciudad;
            Debug.WriteLine("Constructor con 2 params");
        }

        public Direccion(string calle, string ciudad, string codigoPostal)
        {
            Calle = calle;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor con 3 params");
        }
    }
}

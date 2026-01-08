using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        public Empleado()
        {
            Debug.WriteLine("Constructor Empleado vacio");
        }

        public Empleado(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

            Debug.WriteLine("Constructor Empleado con 2 param");
        }
    }
}

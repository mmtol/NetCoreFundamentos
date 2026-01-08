using System.Diagnostics;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }

        public Empleado()/*:base("pepe", "pepito")*/
        {
            SalarioMinimo = 1700;

            Debug.WriteLine("Constructor Empleado vacio");
        }

        public Empleado(string nombre, string apellido) : base(nombre, apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

            Debug.WriteLine("Constructor Empleado con 2 param");
        }

        public int getSalarioMinimo()
        {
            return SalarioMinimo;
        }

        public virtual int getVacaciones()
        {
            return 30;
        }
    }
}

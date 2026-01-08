using System.Diagnostics;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            SalarioMinimo = SalarioMinimo + 200;

            Debug.WriteLine("Constructor Director");
        }

        public override int getVacaciones()
        {
            int diasEmpleado = base.getVacaciones();
            return diasEmpleado + 8;
        }
    }
}

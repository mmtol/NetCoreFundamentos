using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        //solo tiene estructura de declaracion de elementos
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }
        void CalcularIVA() { }
        void OdiarHacienda(int cantidad) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public class FacturaEnero : IFactura
    {
        public int PrecioBase { get; set; }
        public int PrecioTotal { get; set; }

        public void CalcularIVA()
        {
            throw new NotImplementedException();
        }

        public void OdiarHacienda(int cantidad)
        {
           throw new NotImplementedException();
        }   
    }
}

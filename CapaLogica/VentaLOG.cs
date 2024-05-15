using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaLOG
    {
        VentaDAL _ventaDAL;

       public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int GuardarVenta(Ventas ventas)
        {
            _ventaDAL = new VentaDAL();

            return _ventaDAL.Guardar(ventas);
        }
    }
}

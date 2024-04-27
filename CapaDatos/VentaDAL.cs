using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        ContextoBD _db;

       public int Guardar(Ventas ventas, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;
            
            if(esActualizacion) 
            {
                ventas.VentaId = id;

                _db.Entry(ventas).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(ventas);
                _db.SaveChanges (); 
            }

            resultado = ventas.VentaId;

            return resultado;

        }

    }
}
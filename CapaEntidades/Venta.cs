using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventas
    {
        // Especifica que la propiedad VentaId es la clave primaria de la entidad.
        [Key]
        // Especifica que el valor de VentaId será generado automáticamente por la base de datos.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }

        // Especifica que la propiedad Fecha es requerida (no puede ser nula).
        [Required]
        public DateTime Fecha { get; set; }

        // Especifica que la propiedad Total es requerida (no puede ser nula).
        [Required]
        public decimal Total { get; set; }

        // Propiedad de navegación que representa la relación entre Venta y DetalleVenta.
        // Un objeto Venta puede tener una lista de objetos DetalleVenta asociados.
        public List<DetalleVenta> Detalles { get; set; }


    }
}

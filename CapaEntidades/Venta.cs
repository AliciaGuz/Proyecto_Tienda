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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Total { get; set; }

        // propiedad de navegación
        public List<DetalleVenta> Detalles { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CapaEntidades
{
    // Definición de la clase DetalleVenta en el espacio de nombres CapaEntidades
    public class DetalleVenta
    {
        // Identificador único del detalle de venta generado automáticamente por la base de datos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }

        // Cantidad de productos vendidos en este detalle (requerido)
        [Required]
        public int Cantidad { get; set; }

        // Precio unitario del producto vendido en este detalle (requerido)
        [Required]
        public decimal Precio { get; set; }

        // Identificador del producto vendido en este detalle (requerido)
        [Required]
        public int ProductoId { get; set; }

        // Relación con la clase Producto mediante la clave externa ProductoId
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }

        // Identificador de la venta a la que pertenece este detalle (requerido)
        [Required]
        public int VentaId { get; set; }

        // Relación con la clase Ventas mediante la clave externa VentaId.
        [ForeignKey("VentaId")]
        public Ventas Venta { get; set; }
    }
}

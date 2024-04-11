using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {

        [Key] // Indica que esta propiedad es la clave primaria de la entidad.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Especifica que el valor de la clave primaria se generará automáticamente por la base de datos.
        public int IdProducto { get; set; } // Propiedad que representa el identificador único de cada producto.

        [Required] // Indica que esta propiedad es obligatoria y no puede ser nula.
        [MaxLength(100)] // Establece la longitud máxima permitida para el campo de texto.
        public string Nombre { get; set; } // Propiedad que almacena el nombre del producto.

        [MaxLength(250)] 
        public string Descripcion { get; set; } // Propiedad que almacena la descripción del producto.

        [Required] 
        public decimal PrecioUnitario { get; set; } // Propiedad que almacena el precio unitario del producto.

        [Required] 
        public int Stock { get; set; } // Propiedad que almacena la cantidad de stock disponible del producto.

        [Required] 
        public bool Estado { get; set; } // Propiedad que indica el estado del producto, por ejemplo, si está disponible o no.


    }
}

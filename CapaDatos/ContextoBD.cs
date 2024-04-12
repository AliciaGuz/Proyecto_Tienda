using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoBD : DbContext
    {
        // Constructor de la clase ContextoBD que configura la cadena de conexión.
        public ContextoBD()
            : base("name=ContextoBD")
        {
        }

        // Método para configurar el modelo de datos.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        // Conjunto de entidades que representa la tabla de ventas en la base de datos.
        public virtual DbSet<Ventas> Ventas { get; set; }

        // Conjunto de entidades que representa la tabla de productos en la base de datos.
        public virtual DbSet<Producto> Productos { get; set; }

        // Conjunto de entidades que representa la tabla de detalles de venta en la base de datos.
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }



    }
}
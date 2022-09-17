using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControldeVentasIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //creamos las tablas de la base de datos, utilizando las clases
        //Primero creamos la tabla Ventas con la clase venta
        public DbSet<Venta> Ventas { get; set; }
    }
}
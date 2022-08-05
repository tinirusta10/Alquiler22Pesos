

using Alquiler22Pesos.Entidades;
using Alquiler22Pesos.Pages;
using Microsoft.EntityFrameworkCore;

namespace Alquiler22Pesos.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<Provincia> Provincia { get; set; }

        public DbSet<Departamento> Departamento { get; set; }

        public DbSet<TipoDocumento> TipoDocumento { get; set; }

        public DbSet<Localidad> Localidad { get; set; }





    }
}

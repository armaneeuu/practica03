using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simulacro_vite.Controllers;

namespace simulacro_vite.Models
{
    public class CompraContext : DbContext
    {
        // Entidades
        public DbSet<SolicitudCompra> SolicitudesCompra {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}

        // Constructor
        public CompraContext(DbContextOptions dco) : base(dco){

        }
    }
}
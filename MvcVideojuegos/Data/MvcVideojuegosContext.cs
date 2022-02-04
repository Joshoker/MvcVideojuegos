#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcVideojuegos.Models;

namespace MvcVideojuegos.Data
{
    public class MvcVideojuegosContext : DbContext
    {
        public MvcVideojuegosContext (DbContextOptions<MvcVideojuegosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcVideojuegos.Models.Videojuego> Videojuego { get; set; }
    }
}

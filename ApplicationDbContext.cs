using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjercicioProducto.Entities;
using Microsoft.EntityFrameworkCore;

namespace EjercicioProducto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Products { get; set; }


    }
}
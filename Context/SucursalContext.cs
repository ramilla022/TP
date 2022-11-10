using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Models;

namespace TP.Context
{
    public class SucursalContext : DbContext
    {
        public
       SucursalContext(DbContextOptions<SucursalContext> options): base(options)
        {
        }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Venta> ventas { get; set; }
        public DbSet<Cliente> clientes { get; set; }
    }
}

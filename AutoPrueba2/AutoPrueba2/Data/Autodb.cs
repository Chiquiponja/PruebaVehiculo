using AutoPrueba2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPrueba2.Data
{
    public class Conexionbd : DbContext
    {
        internal object Auto;
        public Conexionbd()
        {
        }
        public Conexionbd(DbContextOptions<Conexionbd> options)
                : base(options)
        { }

       

        public DbSet<Auto> Autos { get; set; }
    }

}

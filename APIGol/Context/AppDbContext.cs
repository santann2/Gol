using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGol.Models;
using Microsoft.EntityFrameworkCore;

namespace APIGol.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Airplane> Airplanes { get; set; }
    }
}

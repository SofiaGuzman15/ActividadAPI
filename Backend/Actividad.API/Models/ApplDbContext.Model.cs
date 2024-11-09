using Actividad.API.Services;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Actividad.API.Models
{
    public class AppDbContext
        : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }
    }
}
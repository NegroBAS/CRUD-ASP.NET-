using System;
using crudUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace crudUsuarios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

    }
}

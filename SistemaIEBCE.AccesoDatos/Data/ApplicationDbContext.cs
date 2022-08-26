using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaIEBCE.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Seccion> Seccion { get; set; }
        public DbSet<Bloque> Bloque { get; set; }
        public DbSet<Catedratico> Catedratico { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }


        public DbSet<IdentityUser> IdentityUser { get; set; }

    }
}

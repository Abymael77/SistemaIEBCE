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

        //mantenimineto basico
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Seccion> Seccion { get; set; }
        public DbSet<Bloque> Bloque { get; set; }
        public DbSet<Catedratico> Catedratico { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }

        //Asignaciones
        public DbSet<CicloEscolar> CicloEscolar { get; set; }
        public DbSet<AsigCurso> AsigCurso { get; set; }
        public DbSet<AsigEstudiante> AsigEstudiante { get; set; }
        public DbSet<BloqueAsigCurso> BloqueAsigCurso { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }

        //tesoreria
        public DbSet<Cuota> Cuota { get; set; }
        public DbSet<Gasto> Gasto { get; set; }
        public DbSet<Caja> Caja { get; set; }

        public DbSet<DetalleGasto> DetalleGasto { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }


        //log-in
        public DbSet<IdentityUser> IdentityUser { get; set; }

    }
}

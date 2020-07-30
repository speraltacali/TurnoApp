using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Entity.Entity;
using static TA.Application.ConnectionString.ConnectionString;

namespace TA.Infraestructure.Context
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> Option)
            : base(Option)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AcessConnection);
            }
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Domicilio> Domicilio { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Empresa_Domicilio> Empresa_Domicilio { get; set; }

        public DbSet<Localidad> Localidad { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<Perfil> Perfil { get; set; }

        public DbSet<Provincia> Provincia { get; set; }

        public DbSet<Reserva_Turno> Reserva_Turno { get; set; }

        public DbSet<Turno> Turno { get; set; }

        public DbSet<User_Cliente> User_Cliente { get; set; }

        public DbSet<User_Empresa> User_Empresa { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        
    }
}

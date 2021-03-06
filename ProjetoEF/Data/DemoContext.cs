﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.Storage.Shared.Protocol;
using ProjetoEF.Models;

namespace ProjetoEF.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        { 
            
        }

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                .Property(c => c.Id)
                .HasColumnName("EventoId");

            modelBuilder.Entity<Evento>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Descricao)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ListaTareas.Model.Models;

public partial class ToDoContext : DbContext
{
    public ToDoContext()
    {
    }

    public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarea> Tareas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.IdTarea).HasName("PK__Tarea__EADE9098EF178AEC");

            entity.ToTable("Tarea");

            entity.Property(e => e.NombreTarea).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

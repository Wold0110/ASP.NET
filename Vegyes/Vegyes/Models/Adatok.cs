using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vegyes.Models;

public partial class Adatok : DbContext
{
    public Adatok()
    {
    }

    public Adatok(DbContextOptions<Adatok> options)
        : base(options)
    {
    }

    public virtual DbSet<Kiadasok> Kiadasoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SESA646228\\source\\repos\\Vegyes\\DATABASE.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kiadasok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kiadasok__3214EC07FB7C72F9");

            entity.ToTable("Kiadasok");

            entity.Property(e => e.Ki)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Mennyit)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Mire)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspNetTopics.Models;

public partial class MagicVillaContext : DbContext
{
    public MagicVillaContext()
    {
    }

    public MagicVillaContext(DbContextOptions<MagicVillaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LocalUser> LocalUsers { get; set; }

    public virtual DbSet<Villa> Villas { get; set; }

    public virtual DbSet<VillaNumber> VillaNumbers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;database=MagicVilla;integrated security=true;trust server certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocalUser>(entity =>
        {
            entity.ToTable("localUsers");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Villa>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<VillaNumber>(entity =>
        {
            entity.HasKey(e => e.VillaNo);

            entity.ToTable("villaNumber");

            entity.HasIndex(e => e.VillaId, "IX_villaNumber_VillaID");

            entity.Property(e => e.VillaNo).ValueGeneratedNever();
            entity.Property(e => e.VillaId).HasColumnName("VillaID");

            entity.HasOne(d => d.Villa).WithMany(p => p.VillaNumbers).HasForeignKey(d => d.VillaId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

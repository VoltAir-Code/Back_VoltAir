using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VoltAir.Domains;

namespace VoltAir.Contexts;

public partial class VoltaireContext : DbContext
{
    public VoltaireContext()
    {
    }

    public VoltaireContext(DbContextOptions<VoltaireContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carro> Carros { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MHF127S; Initial Catalog=dbVoltaire; User Id=sa; Password=Senai@134; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carro>(entity =>
        {
            entity.HasKey(e => e.IdCarro).HasName("PK__Carros__3D09E20E3C025E74");

            entity.Property(e => e.IdCarro)
                .ValueGeneratedNever()
                .HasColumnName("idCarro");
<<<<<<< HEAD
            entity.Property(e => e.CapacidadeAtual).HasColumnType("datetime");
            entity.Property(e => e.DurBateria).HasColumnType("datetime");
            entity.Property(e => e.IdMarca).HasColumnName("idMarca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modelo");
=======
            entity.Property(e => e.BateriaAtual).HasColumnType("datetime");
            entity.Property(e => e.IdMarca).HasColumnName("idMarca");
            entity.Property(e => e.IdModelo).HasColumnName("idModelo");
            entity.Property(e => e.IdRegistro).HasColumnName("idRegistro");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1
            entity.Property(e => e.Placa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("placa");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Carros)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("FK_Carros_Marca");
<<<<<<< HEAD
=======

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Carros)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("FK_Carros_Modelos");

            entity.HasOne(d => d.IdRegistroNavigation).WithMany(p => p.Carros)
                .HasForeignKey(d => d.IdRegistro)
                .HasConstraintName("FK_Carros_Registros");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Carros)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Carros_Usuarios");
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1
        });

        modelBuilder.Entity<Marca>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.IdMarca).HasName("PK__Marca__703318120415EDF0");
=======
            entity.HasKey(e => e.IdMarca).HasName("PK__Marca__70331812E7574424");
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1

            entity.ToTable("Marca");

            entity.Property(e => e.IdMarca)
                .ValueGeneratedNever()
                .HasColumnName("idMarca");
            entity.Property(e => e.NomeMarca)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nomeMarca");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo);

            entity.Property(e => e.IdModelo)
                .ValueGeneratedNever()
                .HasColumnName("idModelo");
            entity.Property(e => e.DurBateria).HasColumnType("datetime");
            entity.Property(e => e.NomeModelo)
                .HasMaxLength(255)
                .HasColumnName("nomeModelo");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.IdRegistro).HasName("PK__Registro__62FC8F58FCF1BD8A");

            entity.Property(e => e.IdRegistro)
                .ValueGeneratedNever()
                .HasColumnName("idRegistro");
            entity.Property(e => e.DuracaoRecarga).HasColumnType("datetime");
            entity.Property(e => e.IdCarro).HasColumnName("idCarro");
            entity.Property(e => e.UltimaRecarga).HasColumnType("datetime");

            entity.HasOne(d => d.IdCarroNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdCarro)
                .HasConstraintName("FK_Registros_Carros");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__645723A69BF397A7");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idUsuario");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Foto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("foto");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

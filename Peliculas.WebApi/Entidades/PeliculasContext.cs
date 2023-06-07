using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Peliculas.WebApi.Entidades;

public partial class PeliculasContext : DbContext
{
    public PeliculasContext()
    {
    }

    public PeliculasContext(DbContextOptions<PeliculasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actores { get; set; }

    public virtual DbSet<Cine> Cines { get; set; }

    public virtual DbSet<CineOferta> CineOfertas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Critica> Criticas { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Funcion> Funciones { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    public virtual DbSet<SalasCine> SalasCines { get; set; }

    public virtual DbSet<UbicacionesEnSala> UbicacionesEnSalas { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.Property(e => e.Biografia).HasMaxLength(2000);
            entity.Property(e => e.FotoUrl).HasColumnName("FotoURL");
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasMany(d => d.Peliculas).WithMany(p => p.Actores)
                .UsingEntity<Dictionary<string, object>>(
                    "ActorPelicula",
                    r => r.HasOne<Pelicula>().WithMany().HasForeignKey("PeliculasId"),
                    l => l.HasOne<Actor>().WithMany().HasForeignKey("ActoresId"),
                    j =>
                    {
                        j.HasKey("ActoresId", "PeliculasId");
                        j.ToTable("ActorPelicula");
                        j.HasIndex(new[] { "PeliculasId" }, "IX_ActorPelicula_PeliculasId");
                    });
        });

        modelBuilder.Entity<Cine>(entity =>
        {
            entity.HasIndex(e => e.PeliculaId, "IX_Cines_PeliculaId");

            entity.HasOne(d => d.Pelicula).WithMany(p => p.Cines).HasForeignKey(d => d.PeliculaId);
        });

        modelBuilder.Entity<CineOferta>(entity =>
        {
            entity.HasIndex(e => e.CineId, "IX_CineOfertas_CineId");

            entity.Property(e => e.PorcentajeDescuento).HasColumnType("decimal(2, 2)");

            entity.HasOne(d => d.Cine).WithMany(p => p.CineOferta).HasForeignKey(d => d.CineId);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Dni).HasColumnName("DNI");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasIndex(e => e.PeliculaId, "IX_Comentarios_PeliculaId");

            entity.HasOne(d => d.Pelicula).WithMany(p => p.Comentarios).HasForeignKey(d => d.PeliculaId);
        });

        modelBuilder.Entity<Critica>(entity =>
        {
            entity.HasIndex(e => e.PeliculaId, "IX_Criticas_PeliculaId");

            entity.HasOne(d => d.Pelicula).WithMany(p => p.Criticas).HasForeignKey(d => d.PeliculaId);
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.ToTable("Direccion");

            entity.Property(e => e.Cp).HasColumnName("CP");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasIndex(e => e.ClienteId, "IX_Entradas_ClienteId");

            entity.HasIndex(e => e.FuncionId, "IX_Entradas_FuncionId");

            entity.HasIndex(e => e.SalaCineId, "IX_Entradas_SalaCineId");

            entity.Property(e => e.Precio).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.QrcodeImage).HasColumnName("QRCodeImage");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Entrada).HasForeignKey(d => d.ClienteId);

            entity.HasOne(d => d.Funcion).WithMany(p => p.Entrada).HasForeignKey(d => d.FuncionId);

            entity.HasOne(d => d.SalaCine).WithMany(p => p.Entrada).HasForeignKey(d => d.SalaCineId);
        });

        modelBuilder.Entity<Funcion>(entity =>
        {
            entity.HasIndex(e => e.PeliculaId, "IX_Funciones_PeliculaId");

            entity.HasOne(d => d.Pelicula).WithMany(p => p.Funciones).HasForeignKey(d => d.PeliculaId);
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasMany(d => d.Peliculas).WithMany(p => p.Generos)
                .UsingEntity<Dictionary<string, object>>(
                    "GeneroPelicula",
                    r => r.HasOne<Pelicula>().WithMany().HasForeignKey("PeliculasId"),
                    l => l.HasOne<Genero>().WithMany().HasForeignKey("GenerosId"),
                    j =>
                    {
                        j.HasKey("GenerosId", "PeliculasId");
                        j.ToTable("GeneroPelicula");
                        j.HasIndex(new[] { "PeliculasId" }, "IX_GeneroPelicula_PeliculasId");
                    });
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.Property(e => e.PosterLink)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Titulo).HasMaxLength(250);
            entity.Property(e => e.TrailerLink)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalasCine>(entity =>
        {
            entity.ToTable("SalasCine");

            entity.HasIndex(e => e.CineId, "IX_SalasCine_CineId");

            entity.HasOne(d => d.Cine).WithMany(p => p.SalasCines).HasForeignKey(d => d.CineId);
        });

        modelBuilder.Entity<UbicacionesEnSala>(entity =>
        {
            entity.ToTable("UbicacionesEnSala");

            entity.HasIndex(e => e.SalaCineId, "IX_UbicacionesEnSala_SalaCineId");

            entity.HasOne(d => d.SalaCine).WithMany(p => p.UbicacionesEnSalas).HasForeignKey(d => d.SalaCineId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.DireccionId, "IX_Users_DireccionId");

            entity.HasOne(d => d.Direccion).WithMany(p => p.Users).HasForeignKey(d => d.DireccionId);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.ToTable("UserLogin");

            entity.HasIndex(e => e.UserId, "IX_UserLogin_UserId").IsUnique();

            entity.HasOne(d => d.User).WithOne(p => p.UserLogin).HasForeignKey<UserLogin>(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

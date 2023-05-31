﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Peliculas.Data;

#nullable disable

namespace Peliculas.Web.Migrations
{
    [DbContext(typeof(PeliculasDbContext))]
    [Migration("20230501033731_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorPelicula", b =>
                {
                    b.Property<int>("ActoresId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("ActoresId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("ActorPelicula");
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");
                });

            modelBuilder.Entity("Peliculas.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("FotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PaisOrigen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actores");
                });

            modelBuilder.Entity("Peliculas.Entidades.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<Point>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Cines");
                });

            modelBuilder.Entity("Peliculas.Entidades.CineOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasPrecision(2, 2)
                        .HasColumnType("decimal(2,2)");

                    b.HasKey("Id");

                    b.HasIndex("CineId");

                    b.ToTable("CineOfertas");
                });

            modelBuilder.Entity("Peliculas.Entidades.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeGustaCantidad")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Peliculas.Entidades.Critica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Criticas");
                });

            modelBuilder.Entity("Peliculas.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Peliculas.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EnCartelara")
                        .HasColumnType("bit");

                    b.Property<int>("Estreno")
                        .HasColumnType("int");

                    b.Property<int>("PaisOrigen")
                        .HasColumnType("int");

                    b.Property<string>("PosterLink")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("Peliculas.Entidades.SalaCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("UbicacionEnSalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CineId");

                    b.ToTable("SalasCine");
                });

            modelBuilder.Entity("Peliculas.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Peliculas.Entidades.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<byte[]>("QRCodeImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("SalaCineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionId");

                    b.HasIndex("SalaCineId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Peliculas.Entidades.Funcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Peliculas.Entidades.UbicacionEnSala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Columna")
                        .HasColumnType("int");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("Fila")
                        .HasColumnType("int");

                    b.Property<int>("SalaCineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalaCineId");

                    b.ToTable("UbicacionesEnSala");
                });

            modelBuilder.Entity("ActorPelicula", b =>
                {
                    b.HasOne("Peliculas.Entidades.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("Peliculas.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Peliculas.Entidades.Cine", b =>
                {
                    b.HasOne("Peliculas.Entidades.Pelicula", "Pelicula")
                        .WithMany("Cines")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Entidades.CineOferta", b =>
                {
                    b.HasOne("Peliculas.Entidades.Cine", "Cine")
                        .WithMany("CineOfertas")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("Peliculas.Entidades.Comentario", b =>
                {
                    b.HasOne("Peliculas.Entidades.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Entidades.Critica", b =>
                {
                    b.HasOne("Peliculas.Entidades.Pelicula", "Pelicula")
                        .WithMany("Criticas")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Entidades.SalaCine", b =>
                {
                    b.HasOne("Peliculas.Entidades.Cine", "Cine")
                        .WithMany("SalasCine")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("Peliculas.Entidades.Entrada", b =>
                {
                    b.HasOne("Peliculas.Entidades.Cliente", "Cliente")
                        .WithMany("Entradas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Peliculas.Entidades.Funcion", "Funcion")
                        .WithMany("Entradas")
                        .HasForeignKey("FuncionId");

                    b.HasOne("Peliculas.Entidades.SalaCine", null)
                        .WithMany("Entradas")
                        .HasForeignKey("SalaCineId");

                    b.Navigation("Cliente");

                    b.Navigation("Funcion");
                });

            modelBuilder.Entity("Peliculas.Entidades.Funcion", b =>
                {
                    b.HasOne("Peliculas.Entidades.Pelicula", "Pelicula")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Entidades.UbicacionEnSala", b =>
                {
                    b.HasOne("Peliculas.Entidades.SalaCine", "Entradas")
                        .WithMany("UbicacionesEnSala")
                        .HasForeignKey("SalaCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entradas");
                });

            modelBuilder.Entity("Peliculas.Entidades.Cine", b =>
                {
                    b.Navigation("CineOfertas");

                    b.Navigation("SalasCine");
                });

            modelBuilder.Entity("Peliculas.Entidades.Pelicula", b =>
                {
                    b.Navigation("Cines");

                    b.Navigation("Comentarios");

                    b.Navigation("Criticas");

                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Peliculas.Entidades.SalaCine", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("UbicacionesEnSala");
                });

            modelBuilder.Entity("Peliculas.Entidades.Cliente", b =>
                {
                    b.Navigation("Entradas");
                });

            modelBuilder.Entity("Peliculas.Entidades.Funcion", b =>
                {
                    b.Navigation("Entradas");
                });
#pragma warning restore 612, 618
        }
    }
}
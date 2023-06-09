﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Peliculas.WebApi.Entidades;

#nullable disable

namespace Peliculas.WebApi.Migrations
{
    [DbContext(typeof(PeliculasContext))]
    partial class PeliculasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorPelicula", b =>
                {
                    b.Property<int>("ActoresId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("ActoresId", "PeliculasId");

                    b.HasIndex(new[] { "PeliculasId" }, "IX_ActorPelicula_PeliculasId");

                    b.ToTable("ActorPelicula", (string)null);
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex(new[] { "PeliculasId" }, "IX_GeneroPelicula_PeliculasId");

                    b.ToTable("GeneroPelicula", (string)null);
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biografia")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FotoURL");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PaisOrigen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actores");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<Geometry>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PeliculaId" }, "IX_Cines_PeliculaId");

                    b.ToTable("Cines");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.CineOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasColumnType("decimal(2, 2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CineId" }, "IX_CineOfertas_CineId");

                    b.ToTable("CineOfertas");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int")
                        .HasColumnName("DNI");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex(new[] { "PeliculaId" }, "IX_Comentarios_PeliculaId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Critica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PeliculaId" }, "IX_Criticas_PeliculaId");

                    b.ToTable("Criticas");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CP");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Pais")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Direccion", (string)null);
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<byte[]>("QrcodeImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("QRCodeImage");

                    b.Property<int?>("SalaCineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClienteId" }, "IX_Entradas_ClienteId");

                    b.HasIndex(new[] { "FuncionId" }, "IX_Entradas_FuncionId");

                    b.HasIndex(new[] { "SalaCineId" }, "IX_Entradas_SalaCineId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Funcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PeliculaId" }, "IX_Funciones_PeliculaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EnCartelera")
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

            modelBuilder.Entity("Peliculas.WebApi.Entidades.SalasCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex(new[] { "CineId" }, "IX_SalasCine_CineId");

                    b.ToTable("SalasCine", (string)null);
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.UbicacionesEnSala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Columna")
                        .HasColumnType("int");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("Fila")
                        .HasColumnType("int");

                    b.Property<int>("SalaCineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SalaCineId" }, "IX_UbicacionesEnSala_SalaCineId");

                    b.ToTable("UbicacionesEnSala", (string)null);
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DireccionId")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DireccionId" }, "IX_Users_DireccionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_UserLogin_UserId")
                        .IsUnique();

                    b.ToTable("UserLogin", (string)null);
                });

            modelBuilder.Entity("ActorPelicula", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Cine", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("Cines")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.CineOferta", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Cine", "Cine")
                        .WithMany("CineOferta")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Comentario", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Critica", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("Criticas")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Entrada", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Cliente", "Cliente")
                        .WithMany("Entrada")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Peliculas.WebApi.Entidades.Funcion", "Funcion")
                        .WithMany("Entrada")
                        .HasForeignKey("FuncionId");

                    b.HasOne("Peliculas.WebApi.Entidades.SalasCine", "SalaCine")
                        .WithMany("Entrada")
                        .HasForeignKey("SalaCineId");

                    b.Navigation("Cliente");

                    b.Navigation("Funcion");

                    b.Navigation("SalaCine");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Funcion", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.SalasCine", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Cine", "Cine")
                        .WithMany("SalasCines")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.UbicacionesEnSala", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.SalasCine", "SalaCine")
                        .WithMany("UbicacionesEnSalas")
                        .HasForeignKey("SalaCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalaCine");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.User", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.Direccion", "Direccion")
                        .WithMany("Users")
                        .HasForeignKey("DireccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.UserLogin", b =>
                {
                    b.HasOne("Peliculas.WebApi.Entidades.User", "User")
                        .WithOne("UserLogin")
                        .HasForeignKey("Peliculas.WebApi.Entidades.UserLogin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Cine", b =>
                {
                    b.Navigation("CineOferta");

                    b.Navigation("SalasCines");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Cliente", b =>
                {
                    b.Navigation("Entrada");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Direccion", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Funcion", b =>
                {
                    b.Navigation("Entrada");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.Pelicula", b =>
                {
                    b.Navigation("Cines");

                    b.Navigation("Comentarios");

                    b.Navigation("Criticas");

                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.SalasCine", b =>
                {
                    b.Navigation("Entrada");

                    b.Navigation("UbicacionesEnSalas");
                });

            modelBuilder.Entity("Peliculas.WebApi.Entidades.User", b =>
                {
                    b.Navigation("UserLogin");
                });
#pragma warning restore 612, 618
        }
    }
}

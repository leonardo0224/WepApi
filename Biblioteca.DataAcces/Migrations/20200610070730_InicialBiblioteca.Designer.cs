﻿// <auto-generated />
using System;
using Biblioteca.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.DataAcces.Migrations
{
    [DbContext(typeof(BibliotecaDBContext))]
    [Migration("20200610070730_InicialBiblioteca")]
    partial class InicialBiblioteca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.DataAcces.Contracts.Entities.AutorEntity", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("IdAutor");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Biblioteca.DataAcces.Contracts.Entities.CategoriaEntity", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Biblioteca.DataAcces.Contracts.Entities.LibroEntity", b =>
                {
                    b.Property<int>("IdLibro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISBN");

                    b.Property<int?>("IdAutor");

                    b.Property<int?>("IdCategoria");

                    b.Property<string>("NombreLibro");

                    b.HasKey("IdLibro");

                    b.HasIndex("IdAutor");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Biblioteca.DataAcces.Contracts.Entities.LibroEntity", b =>
                {
                    b.HasOne("Biblioteca.DataAcces.Contracts.Entities.AutorEntity", "Autor")
                        .WithMany("Libro")
                        .HasForeignKey("IdAutor");

                    b.HasOne("Biblioteca.DataAcces.Contracts.Entities.CategoriaEntity", "Categoria")
                        .WithMany("Libro")
                        .HasForeignKey("IdCategoria");
                });
#pragma warning restore 612, 618
        }
    }
}

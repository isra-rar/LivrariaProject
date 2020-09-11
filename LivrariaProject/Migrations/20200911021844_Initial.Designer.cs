﻿// <auto-generated />
using System;
using LivrariaProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LivrariaProject.Migrations
{
    [DbContext(typeof(LivrariaProjectContext))]
    [Migration("20200911021844_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LivrariaProject.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Pais")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("LivrariaProject.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AnoEdicao")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("Edicao")
                        .HasColumnType("int");

                    b.Property<long>("ISBN")
                        .HasColumnType("bigint");

                    b.Property<int>("Idioma")
                        .HasColumnType("int");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("LivrariaProject.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeMarca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("LivrariaProject.Models.Livro", b =>
                {
                    b.HasOne("LivrariaProject.Models.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId");

                    b.HasOne("LivrariaProject.Models.Marca", "Marca")
                        .WithMany("Livros")
                        .HasForeignKey("MarcaId");
                });
#pragma warning restore 612, 618
        }
    }
}

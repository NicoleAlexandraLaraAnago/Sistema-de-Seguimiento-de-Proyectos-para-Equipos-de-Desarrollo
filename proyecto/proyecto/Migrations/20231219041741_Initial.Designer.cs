﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto.Context;

#nullable disable

namespace proyecto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231219041741_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("proyecto.Model.Tarea", b =>
                {
                    b.Property<int>("TareaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TareaID"));

                    b.Property<string>("DescripcionTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TareaID");

                    b.ToTable("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}

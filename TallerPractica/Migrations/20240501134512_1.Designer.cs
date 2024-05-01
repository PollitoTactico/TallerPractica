﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerPractica.Data;

#nullable disable

namespace TallerPractica.Migrations
{
    [DbContext(typeof(TallerPracticaContext))]
    [Migration("20240501134512_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallerPractica.Models.Auto", b =>
                {
                    b.Property<int>("IdAuto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAuto"));

                    b.Property<DateTime>("Anio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotorIdMotor")
                        .HasColumnType("int");

                    b.Property<int>("NumPuertas")
                        .HasColumnType("int");

                    b.Property<string>("Propietario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAuto");

                    b.HasIndex("MotorIdMotor");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("TallerPractica.Models.Motor", b =>
                {
                    b.Property<int>("IdMotor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMotor"));

                    b.Property<DateTime>("AnioFabricacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaballoFuerza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMotor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMotor");

                    b.ToTable("Motor");
                });

            modelBuilder.Entity("TallerPractica.Models.Propietario", b =>
                {
                    b.Property<int>("IdPropietario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPropietario"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("EsEcuatoriano")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPropietario");

                    b.ToTable("Propietario");
                });

            modelBuilder.Entity("TallerPractica.Models.Auto", b =>
                {
                    b.HasOne("TallerPractica.Models.Motor", "Motor")
                        .WithMany()
                        .HasForeignKey("MotorIdMotor");

                    b.Navigation("Motor");
                });
#pragma warning restore 612, 618
        }
    }
}
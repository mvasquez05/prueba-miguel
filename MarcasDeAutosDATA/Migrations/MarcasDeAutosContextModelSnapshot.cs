﻿// <auto-generated />
using MarcasDeAutosDATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MarcasDeAutosDATA.Migrations
{
    [DbContext(typeof(MarcasDeAutosContext))]
    partial class MarcasDeAutosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MarcasDeAutosDATA.MarcaAuto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MarcasAutos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Toyota"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Ford"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Chevrolet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

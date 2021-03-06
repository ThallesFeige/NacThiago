﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rm82099.Nac1.Bruno.Web.Persistencia;

namespace Rm82099.Nac1.Bruno.Web.Migrations
{
    [DbContext(typeof(marketContext))]
    partial class marketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rm82099.Nac1.Bruno.Web.Models.Mercado", b =>
                {
                    b.Property<int>("MercadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidade")
                        .HasColumnName("Capacidade")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnName("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<bool>("Novo")
                        .HasColumnName("Novo")
                        .HasColumnType("bit");

                    b.Property<int>("Porte")
                        .HasColumnName("Porte")
                        .HasColumnType("int");

                    b.HasKey("MercadoId");

                    b.ToTable("Tbl_Mercado");
                });
#pragma warning restore 612, 618
        }
    }
}

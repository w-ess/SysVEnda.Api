﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SysVenda.Api.Data;

namespace SysVenda.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190220001954_ForeignKey1")]
    partial class ForeignKey1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SysVenda.Domain.Entidades.EstoqueMovimento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProdutoCd");

                    b.Property<int>("ProdutoId");

                    b.Property<double>("QuantidadeEntrada");

                    b.Property<double>("QuantidadeSaida");

                    b.HasKey("Codigo");

                    b.HasIndex("ProdutoCd");

                    b.ToTable("ESTOQUE_MOVIMENTO");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<decimal>("PrecoVenda");

                    b.Property<decimal>("UnidadeMedida");

                    b.HasKey("Codigo");

                    b.ToTable("PRODUTOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Usuario", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bloqueado");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Codigo");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.EstoqueMovimento", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SysVenda.Api.Data;

namespace SysVenda.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190223192310_InitialSecurity")]
    partial class InitialSecurity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.ClassificacaoPessoa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PessoaCd");

                    b.HasKey("Codigo");

                    b.HasIndex("PessoaCd");

                    b.ToTable("CLASSIFICACOES_PESSOAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Comanda", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataHora");

                    b.Property<int>("FormaPagamentoCd");

                    b.Property<int>("GarcomCd");

                    b.Property<int>("MesaCd");

                    b.Property<char?>("Status");

                    b.HasKey("Codigo");

                    b.HasIndex("FormaPagamentoCd");

                    b.HasIndex("GarcomCd");

                    b.HasIndex("MesaCd");

                    b.ToTable("COMANDAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.ComandaItem", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComandaCd");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<int>("ProdutoCd");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal>("ValorTotalLiquido")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ComandaCd");

                    b.HasIndex("ProdutoCd");

                    b.ToTable("COMANDAS_ITENS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.EstoqueMovimento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProdutoCd");

                    b.Property<decimal>("QuantidadeEntrada")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal>("QuantidadeSaida")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ProdutoCd");

                    b.ToTable("ESTOQUE_MOVIMENTO");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.FormaPagamento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Codigo");

                    b.ToTable("FORMAS_PAGAMENTOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Garcom", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(45)");

                    b.HasKey("Codigo");

                    b.ToTable("GARCONS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Mesa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Codigo");

                    b.ToTable("MESAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Pessoa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CnpjCpf")
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("NomeFantasiaApelido")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Pais")
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("PessoaCodigo");

                    b.Property<string>("RazaoSocialNome")
                        .HasColumnType("varchar(50)");

                    b.Property<char?>("Tipo");

                    b.HasKey("Codigo");

                    b.HasIndex("PessoaCodigo");

                    b.ToTable("PESSOAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(45)");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<string>("UnidadeMedida")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Codigo");

                    b.ToTable("PRODUTOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Usuario", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bloqueado");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Login")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(10)");

                    b.Property<char?>("Tipo");

                    b.HasKey("Codigo");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.ClassificacaoPessoa", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Comanda", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoCd")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.Garcom", "Garcom")
                        .WithMany()
                        .HasForeignKey("GarcomCd")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.Mesa", "Mesa")
                        .WithMany()
                        .HasForeignKey("MesaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.ComandaItem", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Comanda", "Comanda")
                        .WithMany()
                        .HasForeignKey("ComandaCd")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.EstoqueMovimento", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Pessoa", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa")
                        .WithMany("Pessoas")
                        .HasForeignKey("PessoaCodigo");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SysVenda.Api.Data;

namespace SysVenda.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

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

                    b.Property<DateTime>("DataHora")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FormaPagamentoCd");

                    b.Property<int>("GarcomCd");

                    b.Property<int>("MesaCd");

                    b.Property<string>("Status")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

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

            modelBuilder.Entity("SysVenda.Domain.Entidades.Empresa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaCd");

                    b.HasKey("Codigo");

                    b.HasIndex("PessoaCd");

                    b.ToTable("EMPRESAS");
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

                    b.Property<string>("RazaoSocialNome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Tipo")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Codigo");

                    b.ToTable("PESSOAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ControlaEstoque");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(45)");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<string>("UnidadeMedida")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Codigo");

                    b.ToTable("PRODUTOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Telefone", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ddd");

                    b.Property<string>("Numero");

                    b.Property<int>("PessoaCd");

                    b.HasKey("Codigo");

                    b.HasIndex("PessoaCd");

                    b.ToTable("TELEFONES");
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

                    b.Property<string>("Tipo")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Codigo");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagamento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaPagarParcelaCd");

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ContaPagarParcelaCd");

                    b.ToTable("CONTAS_PAGAMENTOS");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagar", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PagadorCd");

                    b.Property<int>("RecebedorCd");

                    b.HasKey("Codigo");

                    b.HasIndex("PagadorCd");

                    b.HasIndex("RecebedorCd");

                    b.ToTable("CONTAS_PAGAR");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagarParcela", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaPagarCd");

                    b.Property<decimal>("Juros")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal>("Multa")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<int>("Parcela");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ContaPagarCd");

                    b.ToTable("CONTAS_PAGAR_PARCELAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaReceber", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PagadorCd");

                    b.Property<int>("RecebedorCd");

                    b.HasKey("Codigo");

                    b.HasIndex("PagadorCd");

                    b.HasIndex("RecebedorCd");

                    b.ToTable("CONTAS_RECEBER");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaReceberParcela", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaReceberCd");

                    b.Property<decimal>("Juros")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal>("Multa")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<int>("Parcela");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ContaReceberCd");

                    b.ToTable("CONTAS_RECEBER_PARCELAS");
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaRecebimento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaReceberParcelaCd");

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Codigo");

                    b.HasIndex("ContaReceberParcelaCd");

                    b.ToTable("CONTAS_RECEBIMENTOS");
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
                        .WithMany("ClassificacoesPessoa")
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

            modelBuilder.Entity("SysVenda.Domain.Entidades.Empresa", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.EstoqueMovimento", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Entidades.Telefone", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("PessoaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagamento", b =>
                {
                    b.HasOne("SysVenda.Domain.Financeiro.ContaPagarParcela", "ContaPagarParcela")
                        .WithMany()
                        .HasForeignKey("ContaPagarParcelaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagar", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Pagador")
                        .WithMany()
                        .HasForeignKey("PagadorCd")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Recebedor")
                        .WithMany()
                        .HasForeignKey("RecebedorCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaPagarParcela", b =>
                {
                    b.HasOne("SysVenda.Domain.Financeiro.ContaPagar", "ContaPagar")
                        .WithMany("ContasPagarParcelas")
                        .HasForeignKey("ContaPagarCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaReceber", b =>
                {
                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Pagador")
                        .WithMany()
                        .HasForeignKey("PagadorCd")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysVenda.Domain.Entidades.Pessoa", "Recebedor")
                        .WithMany()
                        .HasForeignKey("RecebedorCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaReceberParcela", b =>
                {
                    b.HasOne("SysVenda.Domain.Financeiro.ContaReceber", "ContaReceber")
                        .WithMany("ContasPagarParcelas")
                        .HasForeignKey("ContaReceberCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysVenda.Domain.Financeiro.ContaRecebimento", b =>
                {
                    b.HasOne("SysVenda.Domain.Financeiro.ContaReceberParcela", "ContaReceberParcela")
                        .WithMany()
                        .HasForeignKey("ContaReceberParcelaCd")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

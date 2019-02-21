using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SysVenda.Api.Migrations
{
    public partial class CriacaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FORMAS_PAGAMENTOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMAS_PAGAMENTOS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "GARCONS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GARCONS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "MESAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESAS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tipo = table.Column<char>(nullable: true),
                    RazaoSocialNome = table.Column<string>(type: "varchar(50)", nullable: true),
                    NomeFantasiaApelido = table.Column<string>(type: "varchar(50)", nullable: true),
                    CnpjCpf = table.Column<string>(type: "varchar(14)", nullable: true),
                    Pais = table.Column<string>(type: "varchar(20)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(2)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cep = table.Column<string>(type: "varchar(8)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(50)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(8)", nullable: true),
                    PessoaCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PESSOAS_PESSOAS_PessoaCodigo",
                        column: x => x.PessoaCodigo,
                        principalTable: "PESSOAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COMANDAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Status = table.Column<char>(nullable: true),
                    GarcomCd = table.Column<int>(nullable: false),
                    MesaCd = table.Column<int>(nullable: false),
                    FormaPagamentoCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMANDAS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_COMANDAS_FORMAS_PAGAMENTOS_FormaPagamentoCd",
                        column: x => x.FormaPagamentoCd,
                        principalTable: "FORMAS_PAGAMENTOS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMANDAS_GARCONS_GarcomCd",
                        column: x => x.GarcomCd,
                        principalTable: "GARCONS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMANDAS_MESAS_MesaCd",
                        column: x => x.MesaCd,
                        principalTable: "MESAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLASSIFICACOES_PESSOAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "varchar(30)", nullable: true),
                    PessoaCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSIFICACOES_PESSOAS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CLASSIFICACOES_PESSOAS_PESSOAS_PessoaCd",
                        column: x => x.PessoaCd,
                        principalTable: "PESSOAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMANDAS_ITENS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ComandaCd = table.Column<int>(nullable: false),
                    ProdutoCd = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ValorTotalLiquido = table.Column<decimal>(type: "decimal(15, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMANDAS_ITENS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_COMANDAS_ITENS_COMANDAS_ComandaCd",
                        column: x => x.ComandaCd,
                        principalTable: "COMANDAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMANDAS_ITENS_PRODUTOS_ProdutoCd",
                        column: x => x.ProdutoCd,
                        principalTable: "PRODUTOS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLASSIFICACOES_PESSOAS_PessoaCd",
                table: "CLASSIFICACOES_PESSOAS",
                column: "PessoaCd");

            migrationBuilder.CreateIndex(
                name: "IX_COMANDAS_FormaPagamentoCd",
                table: "COMANDAS",
                column: "FormaPagamentoCd");

            migrationBuilder.CreateIndex(
                name: "IX_COMANDAS_GarcomCd",
                table: "COMANDAS",
                column: "GarcomCd");

            migrationBuilder.CreateIndex(
                name: "IX_COMANDAS_MesaCd",
                table: "COMANDAS",
                column: "MesaCd");

            migrationBuilder.CreateIndex(
                name: "IX_COMANDAS_ITENS_ComandaCd",
                table: "COMANDAS_ITENS",
                column: "ComandaCd");

            migrationBuilder.CreateIndex(
                name: "IX_COMANDAS_ITENS_ProdutoCd",
                table: "COMANDAS_ITENS",
                column: "ProdutoCd");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOAS_PessoaCodigo",
                table: "PESSOAS",
                column: "PessoaCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLASSIFICACOES_PESSOAS");

            migrationBuilder.DropTable(
                name: "COMANDAS_ITENS");

            migrationBuilder.DropTable(
                name: "PESSOAS");

            migrationBuilder.DropTable(
                name: "COMANDAS");

            migrationBuilder.DropTable(
                name: "FORMAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "GARCONS");

            migrationBuilder.DropTable(
                name: "MESAS");
        }
    }
}

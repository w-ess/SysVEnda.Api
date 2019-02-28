using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SysVenda.Api.Migrations
{
    public partial class Financeiro1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONTAS_PAGAR",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    RecebedorCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_PAGAR", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_PAGAR_PESSOAS_RecebedorCd",
                        column: x => x.RecebedorCd,
                        principalTable: "PESSOAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_RECEBER",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    PagadorCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_RECEBER", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_RECEBER_PESSOAS_PagadorCd",
                        column: x => x.PagadorCd,
                        principalTable: "PESSOAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_PAGAR_PARCELAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Titulo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Parcela = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Juros = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Multa = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ContaPagarCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_PAGAR_PARCELAS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_PAGAR_PARCELAS_CONTAS_PAGAR_ContaPagarCd",
                        column: x => x.ContaPagarCd,
                        principalTable: "CONTAS_PAGAR",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_RECEBER_PARCELAS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Titulo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Parcela = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Juros = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Multa = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ContaReceberCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_RECEBER_PARCELAS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_RECEBER_PARCELAS_CONTAS_RECEBER_ContaReceberCd",
                        column: x => x.ContaReceberCd,
                        principalTable: "CONTAS_RECEBER",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_PAGAMENTOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ContaPagarParcelaCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_PAGAMENTOS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_PAGAMENTOS_CONTAS_PAGAR_PARCELAS_ContaPagarParcelaCd",
                        column: x => x.ContaPagarParcelaCd,
                        principalTable: "CONTAS_PAGAR_PARCELAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_RECEBIMENTOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ContaReceberParcelaCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTAS_RECEBIMENTOS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_CONTAS_RECEBIMENTOS_CONTAS_RECEBER_PARCELAS_ContaReceberPar~",
                        column: x => x.ContaReceberParcelaCd,
                        principalTable: "CONTAS_RECEBER_PARCELAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_PAGAMENTOS_ContaPagarParcelaCd",
                table: "CONTAS_PAGAMENTOS",
                column: "ContaPagarParcelaCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_PAGAR_RecebedorCd",
                table: "CONTAS_PAGAR",
                column: "RecebedorCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_PAGAR_PARCELAS_ContaPagarCd",
                table: "CONTAS_PAGAR_PARCELAS",
                column: "ContaPagarCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_RECEBER_PagadorCd",
                table: "CONTAS_RECEBER",
                column: "PagadorCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_RECEBER_PARCELAS_ContaReceberCd",
                table: "CONTAS_RECEBER_PARCELAS",
                column: "ContaReceberCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_RECEBIMENTOS_ContaReceberParcelaCd",
                table: "CONTAS_RECEBIMENTOS",
                column: "ContaReceberParcelaCd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONTAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBIMENTOS");

            migrationBuilder.DropTable(
                name: "CONTAS_PAGAR_PARCELAS");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBER_PARCELAS");

            migrationBuilder.DropTable(
                name: "CONTAS_PAGAR");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBER");
        }
    }
}

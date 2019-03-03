using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class CriacaoDeColunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecebedorCd",
                table: "CONTAS_RECEBER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagadorCd",
                table: "CONTAS_PAGAR",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataHora",
                table: "COMANDAS",
                nullable: false,
                oldClrType: typeof(DateTime))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_RECEBER_RecebedorCd",
                table: "CONTAS_RECEBER",
                column: "RecebedorCd");

            migrationBuilder.CreateIndex(
                name: "IX_CONTAS_PAGAR_PagadorCd",
                table: "CONTAS_PAGAR",
                column: "PagadorCd");

            migrationBuilder.AddForeignKey(
                name: "FK_CONTAS_PAGAR_PESSOAS_PagadorCd",
                table: "CONTAS_PAGAR",
                column: "PagadorCd",
                principalTable: "PESSOAS",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CONTAS_RECEBER_PESSOAS_RecebedorCd",
                table: "CONTAS_RECEBER",
                column: "RecebedorCd",
                principalTable: "PESSOAS",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CONTAS_PAGAR_PESSOAS_PagadorCd",
                table: "CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_CONTAS_RECEBER_PESSOAS_RecebedorCd",
                table: "CONTAS_RECEBER");

            migrationBuilder.DropIndex(
                name: "IX_CONTAS_RECEBER_RecebedorCd",
                table: "CONTAS_RECEBER");

            migrationBuilder.DropIndex(
                name: "IX_CONTAS_PAGAR_PagadorCd",
                table: "CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "RecebedorCd",
                table: "CONTAS_RECEBER");

            migrationBuilder.DropColumn(
                name: "PagadorCd",
                table: "CONTAS_PAGAR");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataHora",
                table: "COMANDAS",
                nullable: false,
                oldClrType: typeof(DateTime))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class VencimentoParcelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "CONTAS_RECEBER_PARCELAS",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "CONTAS_PAGAR_PARCELAS",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "CONTAS_RECEBER_PARCELAS");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "CONTAS_PAGAR_PARCELAS");
        }
    }
}

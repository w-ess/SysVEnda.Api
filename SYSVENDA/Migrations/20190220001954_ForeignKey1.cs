using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class ForeignKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoId",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoId",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoCd",
                table: "ESTOQUE_MOVIMENTO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoCd",
                table: "ESTOQUE_MOVIMENTO",
                column: "ProdutoCd");

            migrationBuilder.AddForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoCd",
                table: "ESTOQUE_MOVIMENTO",
                column: "ProdutoCd",
                principalTable: "PRODUTOS",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoCd",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoCd",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropColumn(
                name: "ProdutoCd",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoId",
                table: "ESTOQUE_MOVIMENTO",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoId",
                table: "ESTOQUE_MOVIMENTO",
                column: "ProdutoId",
                principalTable: "PRODUTOS",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

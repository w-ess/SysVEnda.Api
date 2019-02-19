using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class Estoque2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_CProduto",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropIndex(
                name: "IX_ESTOQUE_MOVIMENTO_CProduto",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropColumn(
                name: "CProduto",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.RenameColumn(
                name: "ProdutoCd",
                table: "ESTOQUE_MOVIMENTO",
                newName: "ProdutoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoId",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoId",
                table: "ESTOQUE_MOVIMENTO");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "ESTOQUE_MOVIMENTO",
                newName: "ProdutoCd");

            migrationBuilder.AddColumn<int>(
                name: "CProduto",
                table: "ESTOQUE_MOVIMENTO",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ESTOQUE_MOVIMENTO_CProduto",
                table: "ESTOQUE_MOVIMENTO",
                column: "CProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_CProduto",
                table: "ESTOQUE_MOVIMENTO",
                column: "CProduto",
                principalTable: "PRODUTOS",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

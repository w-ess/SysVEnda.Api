using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class ForeignKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ESTOQUE_MOVIMENTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ESTOQUE_MOVIMENTO",
                nullable: false,
                defaultValue: 0);
        }
    }
}

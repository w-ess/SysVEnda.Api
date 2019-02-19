using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SysVenda.Api.Migrations
{
    public partial class Estoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnidadeMedida",
                table: "PRODUTOS",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ESTOQUE_MOVIMENTO",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    QuantidadeEntrada = table.Column<double>(nullable: false),
                    QuantidadeSaida = table.Column<double>(nullable: false),
                    ProdutoCd = table.Column<int>(nullable: false),
                    CProduto = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTOQUE_MOVIMENTO", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_CProduto",
                        column: x => x.CProduto,
                        principalTable: "PRODUTOS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Bloqueado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ESTOQUE_MOVIMENTO_CProduto",
                table: "ESTOQUE_MOVIMENTO",
                column: "CProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropColumn(
                name: "UnidadeMedida",
                table: "PRODUTOS");
        }
    }
}

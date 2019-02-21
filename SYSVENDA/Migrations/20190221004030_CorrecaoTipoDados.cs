using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVenda.Api.Migrations
{
    public partial class CorrecaoTipoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "USUARIOS",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "USUARIOS",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "USUARIOS",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "USUARIOS",
                type: "varchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<char>(
                name: "Tipo",
                table: "USUARIOS",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UnidadeMedida",
                table: "PRODUTOS",
                type: "varchar(5)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "PRODUTOS",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PRODUTOS",
                type: "varchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeSaida",
                table: "ESTOQUE_MOVIMENTO",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeEntrada",
                table: "ESTOQUE_MOVIMENTO",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "USUARIOS");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "USUARIOS");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "USUARIOS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "USUARIOS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "USUARIOS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnidadeMedida",
                table: "PRODUTOS",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "PRODUTOS",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PRODUTOS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "QuantidadeSaida",
                table: "ESTOQUE_MOVIMENTO",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "QuantidadeEntrada",
                table: "ESTOQUE_MOVIMENTO",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SysVenda.Api.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    Numero = table.Column<string>(type: "varchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "varchar(45)", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    UnidadeMedida = table.Column<string>(type: "varchar(5)", nullable: true),
                    ControlaEstoque = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Login = table.Column<string>(type: "varchar(15)", nullable: true),
                    Senha = table.Column<string>(type: "varchar(10)", nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", nullable: true),
                    Tipo = table.Column<char>(nullable: true),
                    Bloqueado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "TELEFONES",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ddd = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    PessoaCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONES", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_TELEFONES_PESSOAS_PessoaCd",
                        column: x => x.PessoaCd,
                        principalTable: "PESSOAS",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ESTOQUE_MOVIMENTO",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    QuantidadeEntrada = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    QuantidadeSaida = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    ProdutoCd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTOQUE_MOVIMENTO", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ESTOQUE_MOVIMENTO_PRODUTOS_ProdutoCd",
                        column: x => x.ProdutoCd,
                        principalTable: "PRODUTOS",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ESTOQUE_MOVIMENTO_ProdutoCd",
                table: "ESTOQUE_MOVIMENTO",
                column: "ProdutoCd");

            migrationBuilder.CreateIndex(
                name: "IX_TELEFONES_PessoaCd",
                table: "TELEFONES",
                column: "PessoaCd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CLASSIFICACOES_PESSOAS");

            migrationBuilder.DropTable(
                name: "COMANDAS_ITENS");

            migrationBuilder.DropTable(
                name: "CONTAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBIMENTOS");

            migrationBuilder.DropTable(
                name: "ESTOQUE_MOVIMENTO");

            migrationBuilder.DropTable(
                name: "TELEFONES");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "COMANDAS");

            migrationBuilder.DropTable(
                name: "CONTAS_PAGAR_PARCELAS");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBER_PARCELAS");

            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "FORMAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "GARCONS");

            migrationBuilder.DropTable(
                name: "MESAS");

            migrationBuilder.DropTable(
                name: "CONTAS_PAGAR");

            migrationBuilder.DropTable(
                name: "CONTAS_RECEBER");

            migrationBuilder.DropTable(
                name: "PESSOAS");
        }
    }
}

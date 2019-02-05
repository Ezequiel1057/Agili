using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgiliWebMvc.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ListaProduto",
                newName: "nome_prod");

            migrationBuilder.AddColumn<int>(
                name: "Itens_Pedidoid",
                table: "ListaProduto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Restaurantesid",
                table: "ListaProduto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_restaurante",
                table: "ListaProduto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "valor_produto",
                table: "ListaProduto",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Adm",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_adm = table.Column<string>(nullable: true),
                    cpf_adm = table.Column<string>(nullable: true),
                    senha_adm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_func = table.Column<string>(nullable: true),
                    cpf_func = table.Column<string>(nullable: true),
                    senha_func = table.Column<string>(nullable: true),
                    Admid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Adm_Admid",
                        column: x => x.Admid,
                        principalTable: "Adm",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Restaurantes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_rest = table.Column<string>(nullable: true),
                    cnpj_rest = table.Column<string>(nullable: true),
                    telefone_rest = table.Column<string>(nullable: true),
                    endereco_rest = table.Column<string>(nullable: true),
                    senha_rest = table.Column<int>(nullable: false),
                    Admid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurantes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Restaurantes_Adm_Admid",
                        column: x => x.Admid,
                        principalTable: "Adm",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    data_pedido = table.Column<DateTime>(nullable: false),
                    quantidadeTotal_pedidos = table.Column<int>(nullable: false),
                    valorTotal_pedidos = table.Column<double>(nullable: false),
                    Funcionariosid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Funcionarios_Funcionariosid",
                        column: x => x.Funcionariosid,
                        principalTable: "Funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Itens_Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    qtd_itensPedido = table.Column<int>(nullable: false),
                    Pedidosid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Itens_Pedidos_Pedidos_Pedidosid",
                        column: x => x.Pedidosid,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaProduto_Itens_Pedidoid",
                table: "ListaProduto",
                column: "Itens_Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_ListaProduto_Restaurantesid",
                table: "ListaProduto",
                column: "Restaurantesid");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_Admid",
                table: "Funcionarios",
                column: "Admid");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_Pedidos_Pedidosid",
                table: "Itens_Pedidos",
                column: "Pedidosid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Funcionariosid",
                table: "Pedidos",
                column: "Funcionariosid");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_Admid",
                table: "Restaurantes",
                column: "Admid");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaProduto_Itens_Pedidos_Itens_Pedidoid",
                table: "ListaProduto",
                column: "Itens_Pedidoid",
                principalTable: "Itens_Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto",
                column: "Restaurantesid",
                principalTable: "Restaurantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaProduto_Itens_Pedidos_Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto");

            migrationBuilder.DropTable(
                name: "Itens_Pedidos");

            migrationBuilder.DropTable(
                name: "Restaurantes");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Adm");

            migrationBuilder.DropIndex(
                name: "IX_ListaProduto_Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropIndex(
                name: "IX_ListaProduto_Restaurantesid",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "Restaurantesid",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "cod_restaurante",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "valor_produto",
                table: "ListaProduto");

            migrationBuilder.RenameColumn(
                name: "nome_prod",
                table: "ListaProduto",
                newName: "Name");
        }
    }
}

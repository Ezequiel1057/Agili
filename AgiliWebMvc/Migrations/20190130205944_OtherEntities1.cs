using Microsoft.EntityFrameworkCore.Migrations;

namespace AgiliWebMvc.Migrations
{
    public partial class OtherEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaProduto_Itens_Pedidos_Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropIndex(
                name: "IX_ListaProduto_Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "Itens_Pedidoid",
                table: "ListaProduto");

            migrationBuilder.DropColumn(
                name: "cod_restaurante",
                table: "ListaProduto");

            migrationBuilder.AlterColumn<string>(
                name: "senha_rest",
                table: "Restaurantes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "listaProdutosid",
                table: "Itens_Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_Pedidos_listaProdutosid",
                table: "Itens_Pedidos",
                column: "listaProdutosid");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_ListaProduto_listaProdutosid",
                table: "Itens_Pedidos",
                column: "listaProdutosid",
                principalTable: "ListaProduto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_ListaProduto_listaProdutosid",
                table: "Itens_Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Itens_Pedidos_listaProdutosid",
                table: "Itens_Pedidos");

            migrationBuilder.DropColumn(
                name: "listaProdutosid",
                table: "Itens_Pedidos");

            migrationBuilder.AlterColumn<int>(
                name: "senha_rest",
                table: "Restaurantes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Itens_Pedidoid",
                table: "ListaProduto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_restaurante",
                table: "ListaProduto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ListaProduto_Itens_Pedidoid",
                table: "ListaProduto",
                column: "Itens_Pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaProduto_Itens_Pedidos_Itens_Pedidoid",
                table: "ListaProduto",
                column: "Itens_Pedidoid",
                principalTable: "Itens_Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AgiliWebMvc.Migrations
{
    public partial class OtherEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto");

            migrationBuilder.AlterColumn<int>(
                name: "Restaurantesid",
                table: "ListaProduto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto",
                column: "Restaurantesid",
                principalTable: "Restaurantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto");

            migrationBuilder.AlterColumn<int>(
                name: "Restaurantesid",
                table: "ListaProduto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ListaProduto_Restaurantes_Restaurantesid",
                table: "ListaProduto",
                column: "Restaurantesid",
                principalTable: "Restaurantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

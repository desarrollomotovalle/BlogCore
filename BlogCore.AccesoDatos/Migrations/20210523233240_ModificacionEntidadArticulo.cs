using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class ModificacionEntidadArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_categoriaId",
                table: "Articulo");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "Articulo",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_categoriaId",
                table: "Articulo",
                newName: "IX_Articulo_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Articulo",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo",
                newName: "IX_Articulo_categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_categoriaId",
                table: "Articulo",
                column: "categoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

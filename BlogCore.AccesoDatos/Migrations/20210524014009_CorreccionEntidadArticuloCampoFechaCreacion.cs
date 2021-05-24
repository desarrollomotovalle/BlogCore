using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class CorreccionEntidadArticuloCampoFechaCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCracion",
                table: "Articulo");

            migrationBuilder.AddColumn<string>(
                name: "FechaCreacion",
                table: "Articulo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Articulo");

            migrationBuilder.AddColumn<string>(
                name: "FechaCracion",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

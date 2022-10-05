using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class ModificarTipoDatoCarnetEstudianteDeIntAString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Carnet",
                table: "Estudiante",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Carnet",
                table: "Estudiante",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

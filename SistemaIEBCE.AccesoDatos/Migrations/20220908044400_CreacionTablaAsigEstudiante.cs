using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class CreacionTablaAsigEstudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsigEstudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEstudiante = table.Column<int>(type: "int", nullable: false),
                    IdCicloEscolar = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsigEstudiante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsigEstudiante_CicloEscolar_IdCicloEscolar",
                        column: x => x.IdCicloEscolar,
                        principalTable: "CicloEscolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsigEstudiante_Estudiante_IdEstudiante",
                        column: x => x.IdEstudiante,
                        principalTable: "Estudiante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsigEstudiante_IdCicloEscolar",
                table: "AsigEstudiante",
                column: "IdCicloEscolar");

            migrationBuilder.CreateIndex(
                name: "IX_AsigEstudiante_IdEstudiante",
                table: "AsigEstudiante",
                column: "IdEstudiante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsigEstudiante");
        }
    }
}

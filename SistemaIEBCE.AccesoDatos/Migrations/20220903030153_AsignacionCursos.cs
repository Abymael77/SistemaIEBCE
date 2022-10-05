using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class AsignacionCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsigCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCatedratico = table.Column<int>(type: "int", nullable: false),
                    IdCurso = table.Column<int>(type: "int", nullable: false),
                    IdCicloEscolar = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsigCurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsigCurso_Catedratico_IdCatedratico",
                        column: x => x.IdCatedratico,
                        principalTable: "Catedratico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsigCurso_CicloEscolar_IdCicloEscolar",
                        column: x => x.IdCicloEscolar,
                        principalTable: "CicloEscolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsigCurso_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsigCurso_IdCatedratico",
                table: "AsigCurso",
                column: "IdCatedratico");

            migrationBuilder.CreateIndex(
                name: "IX_AsigCurso_IdCicloEscolar",
                table: "AsigCurso",
                column: "IdCicloEscolar");

            migrationBuilder.CreateIndex(
                name: "IX_AsigCurso_IdCurso",
                table: "AsigCurso",
                column: "IdCurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsigCurso");
        }
    }
}

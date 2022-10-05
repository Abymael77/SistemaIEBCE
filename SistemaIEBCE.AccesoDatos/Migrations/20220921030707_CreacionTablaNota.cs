using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class CreacionTablaNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAsigEstudinate = table.Column<int>(type: "int", nullable: false),
                    IdBloqueAsigCurso = table.Column<int>(type: "int", nullable: false),
                    Punteo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsigEstudiante",
                        column: x => x.IdAsigEstudinate,
                        principalTable: "AsigEstudiante",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BloqueAsigCurso",
                        column: x => x.IdBloqueAsigCurso,
                        principalTable: "BloqueAsigCurso",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nota_IdAsigEstudinate",
                table: "Nota",
                column: "IdAsigEstudinate");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_IdBloqueAsigCurso",
                table: "Nota",
                column: "IdBloqueAsigCurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nota");
        }
    }
}

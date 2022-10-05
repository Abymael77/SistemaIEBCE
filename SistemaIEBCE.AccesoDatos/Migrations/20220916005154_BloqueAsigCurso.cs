using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class BloqueAsigCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloqueAsigCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBloque = table.Column<int>(type: "int", nullable: false),
                    IdAsigCurso = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloqueAsigCurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloqueAsigCurso_AsigCurso_IdAsigCurso",
                        column: x => x.IdAsigCurso,
                        principalTable: "AsigCurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloqueAsigCurso_Bloque_IdBloque",
                        column: x => x.IdBloque,
                        principalTable: "Bloque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloqueAsigCurso_IdAsigCurso",
                table: "BloqueAsigCurso",
                column: "IdAsigCurso");

            migrationBuilder.CreateIndex(
                name: "IX_BloqueAsigCurso_IdBloque",
                table: "BloqueAsigCurso",
                column: "IdBloque");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloqueAsigCurso");
        }
    }
}

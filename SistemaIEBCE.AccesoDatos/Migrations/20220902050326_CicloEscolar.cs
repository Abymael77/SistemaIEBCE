using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class CicloEscolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CicloEscolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    IdGrado = table.Column<int>(type: "int", nullable: false),
                    IdSeccion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CicloEscolar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CicloEscolar_Grado_IdGrado",
                        column: x => x.IdGrado,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CicloEscolar_Seccion_IdSeccion",
                        column: x => x.IdSeccion,
                        principalTable: "Seccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CicloEscolar_IdGrado",
                table: "CicloEscolar",
                column: "IdGrado");

            migrationBuilder.CreateIndex(
                name: "IX_CicloEscolar_IdSeccion",
                table: "CicloEscolar",
                column: "IdSeccion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CicloEscolar");
        }
    }
}

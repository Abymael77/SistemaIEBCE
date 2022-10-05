using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class CreacionTablaAsistencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAsigEstudinate = table.Column<int>(type: "int", nullable: false),
                    IdBloqueAsigCurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencia_AsigEstudiante_IdAsigEstudinate",
                        column: x => x.IdAsigEstudinate,
                        principalTable: "AsigEstudiante",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Asistencia_BloqueAsigCurso_IdBloqueAsigCurso",
                        column: x => x.IdBloqueAsigCurso,
                        principalTable: "BloqueAsigCurso",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdAsigEstudinate",
                table: "Asistencia",
                column: "IdAsigEstudinate");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdBloqueAsigCurso",
                table: "Asistencia",
                column: "IdBloqueAsigCurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencia");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaIEBCE.AccesoDatos.Migrations
{
    public partial class CreacionTBLGastoCuotaCajaDetallegastoFacturaDetallefactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio = table.Column<DateTime>(type: "Date", nullable: false),
                    Fin = table.Column<DateTime>(type: "Date", nullable: true),
                    MontoInicial = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCuota = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescpCuota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomGasto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescGasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAsigEstudiante = table.Column<int>(type: "int", nullable: false),
                    IdCaja = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    NoFactura = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_AsigEstudiante_IdAsigEstudiante",
                        column: x => x.IdAsigEstudiante,
                        principalTable: "AsigEstudiante",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Factura_Caja_IdCaja",
                        column: x => x.IdCaja,
                        principalTable: "Caja",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DetalleGasto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGasto = table.Column<int>(type: "int", nullable: false),
                    IdCaja = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    NoFactura = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleGasto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleGasto_Caja_IdCaja",
                        column: x => x.IdCaja,
                        principalTable: "Caja",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetalleGasto_Gasto_IdGasto",
                        column: x => x.IdGasto,
                        principalTable: "Gasto",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuota = table.Column<int>(type: "int", nullable: false),
                    IdFactura = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFactura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleFactura_Cuota_IdCuota",
                        column: x => x.IdCuota,
                        principalTable: "Cuota",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetalleFactura_Factura_IdFactura",
                        column: x => x.IdFactura,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdCuota",
                table: "DetalleFactura",
                column: "IdCuota");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdFactura",
                table: "DetalleFactura",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleGasto_IdCaja",
                table: "DetalleGasto",
                column: "IdCaja");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleGasto_IdGasto",
                table: "DetalleGasto",
                column: "IdGasto");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdAsigEstudiante",
                table: "Factura",
                column: "IdAsigEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdCaja",
                table: "Factura",
                column: "IdCaja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleFactura");

            migrationBuilder.DropTable(
                name: "DetalleGasto");

            migrationBuilder.DropTable(
                name: "Cuota");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Caja");
        }
    }
}

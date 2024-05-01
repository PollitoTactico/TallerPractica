using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerPractica.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motor",
                columns: table => new
                {
                    IdMotor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMotor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaballoFuerza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioFabricacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motor", x => x.IdMotor);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EsEcuatoriano = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.IdPropietario);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    IdAuto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumPuertas = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotorIdMotor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.IdAuto);
                    table.ForeignKey(
                        name: "FK_Auto_Motor_MotorIdMotor",
                        column: x => x.MotorIdMotor,
                        principalTable: "Motor",
                        principalColumn: "IdMotor");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_MotorIdMotor",
                table: "Auto",
                column: "MotorIdMotor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Motor");
        }
    }
}

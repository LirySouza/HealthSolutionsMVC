using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {




            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    ObsConsulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfissionalId = table.Column<int>(type: "int", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId");
                    table.ForeignKey(
                        name: "FK_Consulta_Profissional_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissional",
                        principalColumn: "ProfissionalId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ProfissionalId",
                table: "Consulta",
                column: "ProfissionalId");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}

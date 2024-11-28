using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_TipoConsultaId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "TipoConsultaId",
                table: "Consulta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoConsultaId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_TipoConsultaId",
                table: "Consulta",
                column: "TipoConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta",
                column: "TipoConsultaId",
                principalTable: "TipoConsulta",
                principalColumn: "TipoConsultaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

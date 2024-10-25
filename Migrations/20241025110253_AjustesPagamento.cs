using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AjustesPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Pagamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_PacienteId",
                table: "Pagamento",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Paciente_PacienteId",
                table: "Pagamento",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "PacienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Paciente_PacienteId",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_PacienteId",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Pagamento");
        }
    }
}

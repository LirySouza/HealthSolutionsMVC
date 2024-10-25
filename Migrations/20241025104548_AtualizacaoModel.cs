using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Consulta_ConsultaId",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ConsultaId",
                table: "Pagamento",
                newName: "TipoConsultaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_ConsultaId",
                table: "Pagamento",
                newName: "IX_Pagamento_TipoConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_TipoConsulta_TipoConsultaId",
                table: "Pagamento",
                column: "TipoConsultaId",
                principalTable: "TipoConsulta",
                principalColumn: "TipoConsultaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_TipoConsulta_TipoConsultaId",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "TipoConsultaId",
                table: "Pagamento",
                newName: "ConsultaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_TipoConsultaId",
                table: "Pagamento",
                newName: "IX_Pagamento_ConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Consulta_ConsultaId",
                table: "Pagamento",
                column: "ConsultaId",
                principalTable: "Consulta",
                principalColumn: "ConsultaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

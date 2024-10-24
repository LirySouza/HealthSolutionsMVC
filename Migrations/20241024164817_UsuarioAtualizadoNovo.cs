using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioAtualizadoNovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoUsuario",
                table: "Usuario");
        }
    }
}

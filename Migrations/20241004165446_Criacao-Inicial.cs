using System;
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
            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    FormaPagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFormaPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.FormaPagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoProfissional",
                columns: table => new
                {
                    TipoProfissionalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProfissional", x => x.TipoProfissionalId);
                });

            migrationBuilder.CreateTable(
                name: "TipoSexo",
                columns: table => new
                {
                    TipoSexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoSexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSexo", x => x.TipoSexoId);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimentoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSexoId = table.Column<int>(type: "int", nullable: false),
                    CpfPaciente = table.Column<int>(type: "int", nullable: false),
                    EnderecoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonePaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoSexo_TipoSexoId",
                        column: x => x.TipoSexoId,
                        principalTable: "TipoSexo",
                        principalColumn: "TipoSexoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profissional",
                columns: table => new
                {
                    ProfissionalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimentoProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSexoId = table.Column<int>(type: "int", nullable: false),
                    CpfProfissional = table.Column<int>(type: "int", nullable: false),
                    EnderecoProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProfissionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissional", x => x.ProfissionalId);
                    table.ForeignKey(
                        name: "FK_Profissional_TipoProfissional_TipoProfissionalId",
                        column: x => x.TipoProfissionalId,
                        principalTable: "TipoProfissional",
                        principalColumn: "TipoProfissionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profissional_TipoSexo_TipoSexoId",
                        column: x => x.TipoSexoId,
                        principalTable: "TipoSexo",
                        principalColumn: "TipoSexoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeConsulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Profissional_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissional",
                        principalColumn: "ProfissionalId");
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultaId = table.Column<int>(type: "int", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "int", nullable: false),
                    ValorPagamento = table.Column<double>(type: "float", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObsPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.PagamentoId);
                    table.ForeignKey(
                        name: "FK_Pagamento_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamento_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "FormaPagamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ProfissionalId",
                table: "Consulta",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoSexoId",
                table: "Paciente",
                column: "TipoSexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ConsultaId",
                table: "Pagamento",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_FormaPagamentoId",
                table: "Pagamento",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_TipoProfissionalId",
                table: "Profissional",
                column: "TipoProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Profissional_TipoSexoId",
                table: "Profissional",
                column: "TipoSexoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Profissional");

            migrationBuilder.DropTable(
                name: "TipoProfissional");

            migrationBuilder.DropTable(
                name: "TipoSexo");
        }
    }
}

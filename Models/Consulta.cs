using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("Consulta")]
    public class Consulta
    {
        [Column("ConsultaId")]
        [Display(Name = " Código da Consulta")]
        public int ConsultaId { get; set; }

        [Column("NomeConsulta")]
        [Display(Name = "Consulta")]
        public string NomeConsulta { get; set; } = string.Empty;

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        [Column("ObsConsulta")]
        [Display(Name = "Observação")]
        public string ObsConsulta { get; set; } = string.Empty;

        [ForeignKey("ProfissionalId")]
        public int ProfissionalId { get; set; }
        [Display(Name = "Nome do Profissional")]
        public Profissional? Profissional { get; set; }

        [Column("DataConsulta")]
        [Display(Name = "Data da Consulta")]
        public DateTime DataConsulta { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("PacienteId")]
        [Display(Name = " Código do Paciente")]
        public int PacienteId { get; set; }

        [Column("NomePaciente")]
        [Display(Name = "Nome Completo")]
        public string NomePaciente { get; set; } = string.Empty;

        [Column("DataNascimentoPaciente")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimentoPaciente { get; set; } = string.Empty;

        [ForeignKey("TipoSexoId")]
        public int TipoSexoId { get; set; }
        [Display(Name = "Sexo")]
        public TipoSexo? TipoSexo { get; set; }

        [Column("CpfPaciente")]
        [Display(Name = "CPF")]
        public int CpfPaciente { get; set; }

        [Column("EnderecoPaciente")]
        [Display(Name = "Endereço")]
        public string EnderecoPaciente { get; set; } = string.Empty;

        [Column("TelefonePaciente")]
        [Display(Name = "Telefone")]
        public int TelefonePaciente { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("Profissional")]
    public class Profissional
    {
        [Column("ProfissionalId")]
        [Display(Name = " Código do Profissional")]
        public int ProfissionalId { get; set; }

        [Column("NomeProfissional")]
        [Display(Name = "Nome Completo")]
        public string NomeProfissional { get; set; } = string.Empty;

        [Column("DataNascimentoProfissional")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimentoProfissional { get; set; } = string.Empty;

        [ForeignKey("TipoSexoId")]
        public int TipoSexoId { get; set; }
        [Display(Name = "Sexo")]
        public TipoSexo? TipoSexo { get; set; }

        [Column("CpfProfissional")]
        [Display(Name = "CPF")]
        public int CpfProfissional { get; set; }

        [Column("EnderecoProfissional")]
        [Display(Name = "Endereço")]
        public string EnderecoProfissional { get; set; } = string.Empty;

        [ForeignKey("TipoProfissionalId")]
        public int TipoProfissionalId { get; set; }
        [Display(Name = "Tipo Profissional")]
        public TipoProfissional? TipoProfissional { get; set; }

    }
}

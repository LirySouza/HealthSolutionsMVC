using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthSolutions_MVC.Models
{
    [Table("TipoProfissional")]
    public class TipoProfissional
    {
        [Column("TipoProfissionalId")]
        [Display(Name = "Código do Tipo Profissional")]
        public int TipoProfissionalId { get; set; }

        [Column("NomeTipoProfissional")]
        [Display(Name = "Tipo Profissional")]
        public string NomeTipoProfissional { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("TipoSexo")]
    public class TipoSexo
    {
        [Column("TipoSexoId")]
        [Display(Name = "Código do Tipo Sexo")]
        public int TipoSexoId { get; set; }

        [Column("NomeTipoSexo")]
        [Display(Name = "Tipo Sexo")]
        public string NomeTipoSexo { get; set; } = string.Empty;
    }
}

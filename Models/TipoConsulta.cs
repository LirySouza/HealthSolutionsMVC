using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("TipoConsulta")]
    public class TipoConsulta
    {
        [Column("TipoConsultaId")]
        [Display(Name = "Código do Tipo Consulta")]
        public int TipoConsultaId { get; set; }

        [Column("NomeTipoConsulta")]
        [Display(Name = "Tipo Consulta")]
        public string NomeTipoConsulta { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Column("PagamentoId")]
        [Display(Name = " Código do Pagamento")]
        public int PagamentoId { get; set; }

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }
        [Display(Name = "Paciente")]
        public Paciente? Paciente { get; set; }

        [ForeignKey("TipoConsultaId")]
        public int TipoConsultaId { get; set; }
        [Display(Name = "Tipo Consulta")]
        public TipoConsulta? TipoConsulta { get; set; }

        [ForeignKey("FormaPagamentoId")]
        public int FormaPagamentoId { get; set; }
        [Display(Name = " Forma de Pagamento")]
        public FormaPagamento? FormaPagamento { get; set; }

        [Column("ValorPagamento")]
        [Display(Name = "Valor do Pagamento")]
        public double ValorPagamento { get; set; }

        [Column("DataPagamento")]
        [Display(Name = "Data do Pagamento")]
        public DateTime DataPagamento { get; set; }

        [Column("ObsPagamento")]
        [Display(Name = "Observação")]
        public string ObsPagamento { get; set; } = string.Empty;

    }
}

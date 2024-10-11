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

        [ForeignKey("ConsultaId")]
        public int ConsultaId { get; set; }
        public Consulta? Consulta { get; set; }

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

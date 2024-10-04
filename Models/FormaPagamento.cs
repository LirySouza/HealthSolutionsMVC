using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("FormaPagamento")]
    public class FormaPagamento
    {
        [Column("FormaPagamentoId")]
        [Display(Name = "Código da Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }

        [Column("NomeFormaPagamento")]
        [Display(Name = "Forma de Pagamento")]
        public string NomeFormaPagamento { get; set; } = string.Empty;
    }
}

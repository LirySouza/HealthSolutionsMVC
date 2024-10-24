using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSolutions_MVC.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do Usuário")]

        public int UsuarioId { get; set; }

        [Column("FotoUsuario")]
        [Display(Name = "Foto do Usuario")]

        public string FotoUsuario { get;set; } = string.Empty;

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuário")]

        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioCpf")]
        [Display(Name = "Cpf do Usuário")]

        public string UsuarioCpf { get; set; } = string.Empty;

        [Column("UsuarioEndereco")]
        [Display(Name = "Endereço do Usuário")]

        public string UsuarioEndereco { get; set; } = string.Empty;

        [Column("UsuarioTelefone")]
        [Display(Name = "Telefone do Usuário")]

        public string UsuarioTelefone { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuário")]

        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuário")]

        public string UsuarioSenha { get; set; } = string.Empty;
    }
}

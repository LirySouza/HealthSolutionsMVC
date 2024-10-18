using HealthSolutions_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthSolutions_MVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public DbSet<TipoSexo> TipoSexo { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }

        public DbSet<TipoProfissional> TipoProfissional { get; set; }

        public DbSet<Profissional> Profissional { get; set; }

        public DbSet<HealthSolutions_MVC.Models.Usuario> Usuario { get; set; } = default!;

    }

}

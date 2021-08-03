using ATSBackend.Domain.Entities;
using ATSBackend.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ATSBackend.Infra.Data.Contexts
{
    public class ATSContext : DbContext
    {
        public ATSContext(DbContextOptions<ATSContext> options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CandidatoConfiguration());
            builder.ApplyConfiguration(new VagaConfiguration());
            builder.ApplyConfiguration(new CurriculoConfiguration());
            builder.ApplyConfiguration(new ExperienciaConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source =.\sqlexpress; Initial Catalog = controle_financeiro; Integrated Security = True");
        }
    }
}

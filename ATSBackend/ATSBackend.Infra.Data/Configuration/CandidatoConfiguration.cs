using ATSBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATSBackend.Infra.Data.Configuration
{
    public class CandidatoConfiguration : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.ToTable("tb_candidato");

            builder.HasKey(x => x.IdCandidato);

            builder.Property(x => x.Profissao)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Nome)
               .HasColumnType("varchar(100)");
        }
    }
}

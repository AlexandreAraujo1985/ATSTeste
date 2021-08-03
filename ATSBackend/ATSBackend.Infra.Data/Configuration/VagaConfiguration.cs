using ATSBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATSBackend.Infra.Data.Configuration
{
    public class VagaConfiguration : IEntityTypeConfiguration<Vaga>
    {
        public void Configure(EntityTypeBuilder<Vaga> builder)
        {
            builder.ToTable("tb_vaga");

            builder.HasKey(x => x.IdVaga);

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(100)");

            builder.Property(x => x.Profissao)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Local)
               .HasColumnType("varchar(100)");
        }
    }
}

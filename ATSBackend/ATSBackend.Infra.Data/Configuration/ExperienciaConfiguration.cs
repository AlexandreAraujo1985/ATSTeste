using ATSBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATSBackend.Infra.Data.Configuration
{
    public class ExperienciaConfiguration : IEntityTypeConfiguration<Experiencia>
    {
        public void Configure(EntityTypeBuilder<Experiencia> builder)
        {
            builder.ToTable("tb_experiencia");

            builder.HasKey(x => x.IdExperiencia);

            builder.Property(x => x.NomeEmpresa)
               .HasColumnType("varchar(100)").HasColumnName("nome_empresa");
        }
    }
}

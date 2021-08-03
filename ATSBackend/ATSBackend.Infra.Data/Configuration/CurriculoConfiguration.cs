using System;
using ATSBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATSBackend.Infra.Data.Configuration
{
    public class CurriculoConfiguration : IEntityTypeConfiguration<Curriculo>
    {
        public void Configure(EntityTypeBuilder<Curriculo> builder)
        {
            builder.ToTable("tb_curriculo");

            builder.HasKey(x => x.IdCurriculo);

            builder.Property(x => x.FormacaoAcademica)
               .HasColumnType("varchar(100)").HasColumnName("formacao_academica");
        }
    }
}

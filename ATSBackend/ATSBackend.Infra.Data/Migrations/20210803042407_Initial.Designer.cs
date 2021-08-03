﻿// <auto-generated />
using System;
using ATSBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATSBackend.Infra.Data.Migrations
{
    [DbContext(typeof(ATSContext))]
    [Migration("20210803042407_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ATSBackend.Domain.Entities.Candidato", b =>
                {
                    b.Property<int>("IdCandidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCurriculo")
                        .HasColumnType("int");

                    b.Property<int>("IdVaga")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Profissao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdCandidato");

                    b.HasIndex("IdCurriculo");

                    b.ToTable("tb_candidato");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Curriculo", b =>
                {
                    b.Property<int>("IdCurriculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormacaoAcademica")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("formacao_academica");

                    b.HasKey("IdCurriculo");

                    b.ToTable("tb_curriculo");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Experiencia", b =>
                {
                    b.Property<int>("IdExperiencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCurriculo")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome_empresa");

                    b.HasKey("IdExperiencia");

                    b.HasIndex("IdCurriculo");

                    b.ToTable("tb_experiencia");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Vaga", b =>
                {
                    b.Property<int>("IdVaga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Encerrada")
                        .HasColumnType("bit");

                    b.Property<string>("Local")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Profissao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdVaga");

                    b.ToTable("tb_vaga");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Candidato", b =>
                {
                    b.HasOne("ATSBackend.Domain.Entities.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("IdCurriculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curriculo");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Experiencia", b =>
                {
                    b.HasOne("ATSBackend.Domain.Entities.Curriculo", null)
                        .WithMany("Experiencias")
                        .HasForeignKey("IdCurriculo");
                });

            modelBuilder.Entity("ATSBackend.Domain.Entities.Curriculo", b =>
                {
                    b.Navigation("Experiencias");
                });
#pragma warning restore 612, 618
        }
    }
}

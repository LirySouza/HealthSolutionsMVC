﻿// <auto-generated />
using System;
using HealthSolutions_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthSolutions_MVC.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241024145601_UsuarioAtualizado")]
    partial class UsuarioAtualizado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthSolutions_MVC.Models.Consulta", b =>
                {
                    b.Property<int>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ConsultaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsultaId"));

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataConsulta");

                    b.Property<string>("NomeConsulta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeConsulta");

                    b.Property<string>("ObsConsulta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObsConsulta");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("int");

                    b.HasKey("ConsultaId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.FormaPagamento", b =>
                {
                    b.Property<int>("FormaPagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FormaPagamentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaPagamentoId"));

                    b.Property<string>("NomeFormaPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeFormaPagamento");

                    b.HasKey("FormaPagamentoId");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<int>("CpfPaciente")
                        .HasColumnType("int")
                        .HasColumnName("CpfPaciente");

                    b.Property<string>("DataNascimentoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataNascimentoPaciente");

                    b.Property<string>("EnderecoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EnderecoPaciente");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomePaciente");

                    b.Property<int>("TelefonePaciente")
                        .HasColumnType("int")
                        .HasColumnName("TelefonePaciente");

                    b.Property<int>("TipoSexoId")
                        .HasColumnType("int");

                    b.HasKey("PacienteId");

                    b.HasIndex("TipoSexoId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PagamentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagamentoId"));

                    b.Property<int>("ConsultaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataPagamento");

                    b.Property<int>("FormaPagamentoId")
                        .HasColumnType("int");

                    b.Property<string>("ObsPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObsPagamento");

                    b.Property<double>("ValorPagamento")
                        .HasColumnType("float")
                        .HasColumnName("ValorPagamento");

                    b.HasKey("PagamentoId");

                    b.HasIndex("ConsultaId");

                    b.HasIndex("FormaPagamentoId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Profissional", b =>
                {
                    b.Property<int>("ProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfissionalId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfissionalId"));

                    b.Property<int>("CpfProfissional")
                        .HasColumnType("int")
                        .HasColumnName("CpfProfissional");

                    b.Property<string>("DataNascimentoProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataNascimentoProfissional");

                    b.Property<string>("EnderecoProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EnderecoProfissional");

                    b.Property<string>("FotoProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FotoProfissional");

                    b.Property<string>("NomeProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeProfissional");

                    b.Property<int>("TipoProfissionalId")
                        .HasColumnType("int");

                    b.Property<int>("TipoSexoId")
                        .HasColumnType("int");

                    b.HasKey("ProfissionalId");

                    b.HasIndex("TipoProfissionalId");

                    b.HasIndex("TipoSexoId");

                    b.ToTable("Profissional");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.TipoProfissional", b =>
                {
                    b.Property<int>("TipoProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoProfissionalId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProfissionalId"));

                    b.Property<string>("NomeTipoProfissional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeTipoProfissional");

                    b.HasKey("TipoProfissionalId");

                    b.ToTable("TipoProfissional");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.TipoSexo", b =>
                {
                    b.Property<int>("TipoSexoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoSexoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoSexoId"));

                    b.Property<string>("NomeTipoSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeTipoSexo");

                    b.HasKey("TipoSexoId");

                    b.ToTable("TipoSexo");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioCpf");

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEndereco");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Consulta", b =>
                {
                    b.HasOne("HealthSolutions_MVC.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthSolutions_MVC.Models.Profissional", "Profissional")
                        .WithMany()
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Profissional");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Paciente", b =>
                {
                    b.HasOne("HealthSolutions_MVC.Models.TipoSexo", "TipoSexo")
                        .WithMany()
                        .HasForeignKey("TipoSexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoSexo");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Pagamento", b =>
                {
                    b.HasOne("HealthSolutions_MVC.Models.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthSolutions_MVC.Models.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("FormaPagamento");
                });

            modelBuilder.Entity("HealthSolutions_MVC.Models.Profissional", b =>
                {
                    b.HasOne("HealthSolutions_MVC.Models.TipoProfissional", "TipoProfissional")
                        .WithMany()
                        .HasForeignKey("TipoProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthSolutions_MVC.Models.TipoSexo", "TipoSexo")
                        .WithMany()
                        .HasForeignKey("TipoSexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProfissional");

                    b.Navigation("TipoSexo");
                });
#pragma warning restore 612, 618
        }
    }
}

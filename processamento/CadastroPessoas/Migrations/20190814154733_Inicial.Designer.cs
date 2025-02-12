﻿// <auto-generated />
using System;
using Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroPessoas.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190814154733_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Dominio.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(255);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .HasMaxLength(255);

                    b.Property<string>("Complemento")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Estado")
                        .HasMaxLength(255);

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Logradouro");

                    b.Property<int>("Numero");

                    b.Property<string>("Pais")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Dominio.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("ContatoID");

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("EnderecoID");

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ContatoID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Dominio.Models.Pessoa", b =>
                {
                    b.HasOne("Dominio.Models.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dominio.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

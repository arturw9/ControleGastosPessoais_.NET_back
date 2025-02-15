﻿// <auto-generated />
using System;
using ControleGastosPessoais.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleGastosPessoais.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20241127204947_AlterNameTabelTransacao")]
    partial class AlterNameTabelTransacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ControleGastosPessoais.Models.Categoria", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("char(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(100)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ControleGastosPessoais.Models.Transacao", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("char(100)");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("char(100)");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("ControleGastosPessoais.Models.Usuario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("char(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleGastosPessoais.Models.Categoria", b =>
                {
                    b.HasOne("ControleGastosPessoais.Models.Usuario", null)
                        .WithMany("Categories")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("ControleGastosPessoais.Models.Transacao", b =>
                {
                    b.HasOne("ControleGastosPessoais.Models.Categoria", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ControleGastosPessoais.Models.Usuario", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ControleGastosPessoais.Models.Usuario", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

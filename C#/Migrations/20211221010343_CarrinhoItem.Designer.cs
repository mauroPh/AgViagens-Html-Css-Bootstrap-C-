﻿// <auto-generated />
using System;
using AgenciaDeViagens.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgenciaDeViagens.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211221010343_CarrinhoItem")]
    partial class CarrinhoItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AgenciaDeViagens.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarrinhoCompraItemId"), 1L, 1);

                    b.Property<string>("CarrinhoCompraId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PacoteId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("PacoteId");

                    b.ToTable("CarrinhoCompraItens");
                });

            modelBuilder.Entity("AgenciaDeViagens.Models.Destino", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinoId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DestinoId");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("AgenciaDeViagens.Models.Pacote", b =>
                {
                    b.Property<int>("PacoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacoteId"), 1L, 1);

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoDetalhada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPacoteFavorito")
                        .HasColumnType("bit");

                    b.Property<string>("PacoteNome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PacoteId");

                    b.HasIndex("DestinoId");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("AgenciaDeViagens.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("AgenciaDeViagens.Models.Pacote", "Pacote")
                        .WithMany()
                        .HasForeignKey("PacoteId");

                    b.Navigation("Pacote");
                });

            modelBuilder.Entity("AgenciaDeViagens.Models.Pacote", b =>
                {
                    b.HasOne("AgenciaDeViagens.Models.Destino", "Destino")
                        .WithMany("Pacotes")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("AgenciaDeViagens.Models.Destino", b =>
                {
                    b.Navigation("Pacotes");
                });
#pragma warning restore 612, 618
        }
    }
}

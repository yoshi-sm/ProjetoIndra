﻿// <auto-generated />
using System;
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(FrotaContext))]
    partial class FrotaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.AgendaManutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasColumnName("Data");

                    b.Property<int>("IdCarro")
                        .HasColumnType("int")
                        .HasColumnName("IdCarro");

                    b.Property<int>("IdManutencao")
                        .HasColumnType("int")
                        .HasColumnName("IdManutencao");

                    b.HasKey("Id");

                    b.HasIndex("IdCarro");

                    b.HasIndex("IdManutencao");

                    b.ToTable("AgendaManutencao");
                });

            modelBuilder.Entity("Backend.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Ano");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Cor");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int")
                        .HasColumnName("IdMarca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Modelo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Nome");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Placa");

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Backend.Manutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.Property<int>("ProximaManutencao")
                        .HasColumnType("int")
                        .HasColumnName("ProximaManutencao");

                    b.HasKey("Id");

                    b.ToTable("Manutencao");
                });

            modelBuilder.Entity("Backend.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Backend.RegistroManutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasColumnName("Data");

                    b.Property<int>("IdCarro")
                        .HasColumnType("int")
                        .HasColumnName("IdCarro");

                    b.Property<int>("IdManutencao")
                        .HasColumnType("int")
                        .HasColumnName("IdManutencao");

                    b.Property<int>("Quilometragem")
                        .HasColumnType("int")
                        .HasColumnName("Quilometragem");

                    b.HasKey("Id");

                    b.HasIndex("IdCarro");

                    b.HasIndex("IdManutencao");

                    b.ToTable("RegistroManutencao");
                });

            modelBuilder.Entity("Backend.AgendaManutencao", b =>
                {
                    b.HasOne("Backend.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("IdCarro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Manutencao", "Manutencao")
                        .WithMany()
                        .HasForeignKey("IdManutencao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Manutencao");
                });

            modelBuilder.Entity("Backend.Carro", b =>
                {
                    b.HasOne("Backend.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Backend.RegistroManutencao", b =>
                {
                    b.HasOne("Backend.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("IdCarro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Manutencao", "Manutencao")
                        .WithMany()
                        .HasForeignKey("IdManutencao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Manutencao");
                });
#pragma warning restore 612, 618
        }
    }
}

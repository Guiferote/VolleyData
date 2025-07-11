﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolleyData.Data;

#nullable disable

namespace VolleyData.Migrations
{
    [DbContext(typeof(VolleyDataDbContext))]
    [Migration("20250616162127_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CampeonatoEquipe", b =>
                {
                    b.Property<int>("CampeonatosId")
                        .HasColumnType("int");

                    b.Property<int>("EquipesId")
                        .HasColumnType("int");

                    b.HasKey("CampeonatosId", "EquipesId");

                    b.HasIndex("EquipesId");

                    b.ToTable("CampeonatoEquipe");
                });

            modelBuilder.Entity("VolleyData.Models.Atleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlturaCm")
                        .HasColumnType("int");

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCamisa")
                        .HasColumnType("int");

                    b.Property<int>("Posicao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Atletas");
                });

            modelBuilder.Entity("VolleyData.Models.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campeonatos");
                });

            modelBuilder.Entity("VolleyData.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("VolleyData.Models.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CampeonatoId")
                        .HasColumnType("int");

                    b.Property<int>("EquipeCasaId")
                        .HasColumnType("int");

                    b.Property<int>("EquipeVisitanteId")
                        .HasColumnType("int");

                    b.Property<int>("SetsVencidosEquipeCasa")
                        .HasColumnType("int");

                    b.Property<int>("SetsVencidosEquipeVisitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoId");

                    b.HasIndex("EquipeCasaId");

                    b.HasIndex("EquipeVisitanteId");

                    b.ToTable("Partidas");
                });

            modelBuilder.Entity("VolleyData.Models.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PartidaId")
                        .HasColumnType("int");

                    b.Property<int>("PontosEquipeCasa")
                        .HasColumnType("int");

                    b.Property<int>("PontosEquipeVisitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidaId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("VolleyData.Models.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("CampeonatoEquipe", b =>
                {
                    b.HasOne("VolleyData.Models.Campeonato", null)
                        .WithMany()
                        .HasForeignKey("CampeonatosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyData.Models.Equipe", null)
                        .WithMany()
                        .HasForeignKey("EquipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VolleyData.Models.Atleta", b =>
                {
                    b.HasOne("VolleyData.Models.Equipe", "Equipe")
                        .WithMany("Atletas")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("VolleyData.Models.Partida", b =>
                {
                    b.HasOne("VolleyData.Models.Campeonato", "Campeonato")
                        .WithMany("Partidas")
                        .HasForeignKey("CampeonatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyData.Models.Equipe", "EquipeCasa")
                        .WithMany("PartidasCasa")
                        .HasForeignKey("EquipeCasaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VolleyData.Models.Equipe", "EquipeVisitante")
                        .WithMany("PartidasVisitante")
                        .HasForeignKey("EquipeVisitanteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Campeonato");

                    b.Navigation("EquipeCasa");

                    b.Navigation("EquipeVisitante");
                });

            modelBuilder.Entity("VolleyData.Models.Set", b =>
                {
                    b.HasOne("VolleyData.Models.Partida", "Partida")
                        .WithMany("Sets")
                        .HasForeignKey("PartidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partida");
                });

            modelBuilder.Entity("VolleyData.Models.Tecnico", b =>
                {
                    b.HasOne("VolleyData.Models.Equipe", "Equipe")
                        .WithMany("Tecnicos")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("VolleyData.Models.Campeonato", b =>
                {
                    b.Navigation("Partidas");
                });

            modelBuilder.Entity("VolleyData.Models.Equipe", b =>
                {
                    b.Navigation("Atletas");

                    b.Navigation("PartidasCasa");

                    b.Navigation("PartidasVisitante");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("VolleyData.Models.Partida", b =>
                {
                    b.Navigation("Sets");
                });
#pragma warning restore 612, 618
        }
    }
}

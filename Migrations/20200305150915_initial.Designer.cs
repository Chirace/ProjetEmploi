﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetEmploi.Models;

namespace ProjetEmploi.Migrations
{
    [DbContext(typeof(ProjetEmploiContext))]
    [Migration("20200305150915_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetEmploi.Models.Batiment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Batiment");
                });

            modelBuilder.Entity("ProjetEmploi.Models.Groupe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Groupe");
                });

            modelBuilder.Entity("ProjetEmploi.Models.Salle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatimentID")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BatimentID");

                    b.ToTable("Salle");
                });

            modelBuilder.Entity("ProjetEmploi.Models.Seance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.Property<int>("GroupeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("HeureDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Jour")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalleID")
                        .HasColumnType("int");

                    b.Property<int>("TypeSeanceID")
                        .HasColumnType("int");

                    b.Property<int>("UEID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GroupeID");

                    b.HasIndex("SalleID");

                    b.HasIndex("TypeSeanceID");

                    b.HasIndex("UEID");

                    b.ToTable("Seance");
                });

            modelBuilder.Entity("ProjetEmploi.Models.TypeSeance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Intitule")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TypeSeance");
                });

            modelBuilder.Entity("ProjetEmploi.Models.UE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UE");
                });

            modelBuilder.Entity("ProjetEmploi.Models.Salle", b =>
                {
                    b.HasOne("ProjetEmploi.Models.Batiment", "LeBatiment")
                        .WithMany()
                        .HasForeignKey("BatimentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetEmploi.Models.Seance", b =>
                {
                    b.HasOne("ProjetEmploi.Models.Groupe", "LeGroupe")
                        .WithMany()
                        .HasForeignKey("GroupeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetEmploi.Models.Salle", "LaSalle")
                        .WithMany()
                        .HasForeignKey("SalleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetEmploi.Models.TypeSeance", "LeTypeSeance")
                        .WithMany()
                        .HasForeignKey("TypeSeanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetEmploi.Models.UE", "LUE")
                        .WithMany()
                        .HasForeignKey("UEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VarChar");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId")
                        .IsUnique();

                    b.ToTable("TB_ARMAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 35,
                            Nome = "Arco e Flecha",
                            PersonagemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dano = 33,
                            Nome = "Espada",
                            PersonagemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Dano = 31,
                            Nome = "Machado",
                            PersonagemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Dano = 30,
                            Nome = "Punho",
                            PersonagemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Dano = 34,
                            Nome = "Chicote",
                            PersonagemId = 5
                        },
                        new
                        {
                            Id = 6,
                            Dano = 33,
                            Nome = "Foice",
                            PersonagemId = 6
                        },
                        new
                        {
                            Id = 7,
                            Dano = 32,
                            Nome = "Cajado",
                            PersonagemId = 7
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VarChar");

                    b.HasKey("Id");

                    b.ToTable("TB_HABILIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 39,
                            Nome = "Adormecer"
                        },
                        new
                        {
                            Id = 2,
                            Dano = 41,
                            Nome = "Congelar"
                        },
                        new
                        {
                            Id = 3,
                            Dano = 37,
                            Nome = "Hipnotizar"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Derrotas")
                        .HasColumnType("int");

                    b.Property<int>("Disputas")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VarChar");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("Vitorias")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        });
                });

            modelBuilder.Entity("RpgApi.Models.PersonagemHabilidade", b =>
                {
                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.Property<int>("HabilidadeId")
                        .HasColumnType("int");

                    b.HasKey("PersonagemId", "HabilidadeId");

                    b.HasIndex("HabilidadeId");

                    b.ToTable("TB_PERSONAGENS_HABILIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            PersonagemId = 1,
                            HabilidadeId = 1
                        },
                        new
                        {
                            PersonagemId = 1,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 2,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 3,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 3,
                            HabilidadeId = 3
                        },
                        new
                        {
                            PersonagemId = 4,
                            HabilidadeId = 3
                        },
                        new
                        {
                            PersonagemId = 5,
                            HabilidadeId = 1
                        },
                        new
                        {
                            PersonagemId = 6,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 7,
                            HabilidadeId = 3
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("VarChar");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("VarChar")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VarChar");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 215, 164, 67, 183, 149, 0, 69, 237, 188, 227, 93, 114, 231, 73, 150, 113, 229, 124, 91, 101, 67, 188, 225, 140, 223, 42, 186, 17, 37, 213, 228, 130, 33, 10, 220, 60, 69, 116, 117, 194, 178, 61, 122, 99, 33, 191, 112, 152, 158, 201, 165, 147, 182, 170, 218, 53, 203, 25, 9, 197, 160, 37, 220, 60 },
                            PasswordSalt = new byte[] { 72, 55, 68, 88, 196, 4, 152, 236, 87, 211, 186, 128, 122, 92, 212, 48, 135, 28, 84, 155, 12, 157, 75, 131, 253, 18, 214, 45, 96, 221, 117, 253, 250, 252, 110, 162, 215, 74, 46, 154, 130, 20, 107, 239, 32, 16, 135, 193, 53, 33, 49, 62, 38, 106, 26, 173, 167, 145, 120, 202, 231, 217, 191, 37, 248, 239, 25, 183, 182, 214, 244, 104, 166, 209, 204, 123, 243, 4, 209, 215, 172, 13, 201, 24, 185, 119, 99, 154, 18, 178, 43, 172, 241, 52, 230, 2, 126, 172, 13, 94, 163, 61, 86, 12, 15, 63, 201, 165, 213, 138, 189, 64, 16, 19, 73, 62, 237, 208, 228, 179, 16, 86, 205, 34, 32, 15, 23, 95 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithOne("Arma")
                        .HasForeignKey("RpgApi.Models.Arma", "PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.PersonagemHabilidade", b =>
                {
                    b.HasOne("RpgApi.Models.Habilidade", "Habilidade")
                        .WithMany("PersonagemHabilidades")
                        .HasForeignKey("HabilidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithMany("PersonagemHabilidades")
                        .HasForeignKey("PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habilidade");

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Habilidade", b =>
                {
                    b.Navigation("PersonagemHabilidades");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Navigation("Arma");

                    b.Navigation("PersonagemHabilidades");
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}

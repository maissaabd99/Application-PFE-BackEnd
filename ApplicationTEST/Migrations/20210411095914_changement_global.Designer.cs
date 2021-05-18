﻿// <auto-generated />
using System;
using ApplicationTEST.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ApplicationTEST.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20210411095914_changement_global")]
    partial class changement_global
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ApplicationTEST.Models.Candidat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("CVname")
                        .HasColumnType("text");

                    b.Property<string>("CVoriginalfilename")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("adresse")
                        .HasColumnType("text");

                    b.Property<string>("date_naissance")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("nom")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("prenom")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Competence", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("candidatId")
                        .HasColumnType("text");

                    b.Property<string>("niveau")
                        .HasColumnType("text");

                    b.Property<string>("titre")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("candidatId");

                    b.ToTable("Competences");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Experience_prof", b =>
                {
                    b.Property<int>("id_ex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("candidatId")
                        .HasColumnType("text");

                    b.Property<DateTime>("date_debut")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("date_fin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("description")
                        .HasColumnType("varchar");

                    b.Property<string>("employeur")
                        .HasColumnType("text");

                    b.Property<int?>("id_generer")
                        .HasColumnType("integer");

                    b.Property<string>("lieu_Exp")
                        .HasColumnType("text");

                    b.Property<string>("poste_occupe")
                        .HasColumnType("text");

                    b.Property<string>("typeEmploi")
                        .HasColumnType("text");

                    b.HasKey("id_ex");

                    b.HasIndex("candidatId");

                    b.HasIndex("id_generer");

                    b.ToTable("Experience_prof");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Formation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("annee_debut")
                        .HasColumnType("text");

                    b.Property<string>("annee_fin")
                        .HasColumnType("text");

                    b.Property<string>("candidatId")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("diplome")
                        .HasColumnType("varchar");

                    b.Property<int?>("id_generer")
                        .HasColumnType("integer");

                    b.Property<string>("universite")
                        .HasColumnType("varchar");

                    b.HasKey("id");

                    b.HasIndex("candidatId");

                    b.HasIndex("id_generer");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Generer", b =>
                {
                    b.Property<int>("id_generer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CandidatId")
                        .HasColumnType("text");

                    b.Property<string>("domaine_activite")
                        .HasColumnType("varchar");

                    b.Property<string>("photo_profil")
                        .HasColumnType("varchar");

                    b.Property<string>("poste_domande")
                        .HasColumnType("varchar");

                    b.Property<double>("salaire_min")
                        .HasColumnType("double precision");

                    b.HasKey("id_generer");

                    b.HasIndex("CandidatId");

                    b.ToTable("Generer");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Hobby", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("candidatId")
                        .HasColumnType("text");

                    b.Property<string>("hobby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("candidatId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Langue", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("candidatId")
                        .HasColumnType("text");

                    b.Property<string>("langue")
                        .HasColumnType("text");

                    b.Property<string>("niveau")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("candidatId");

                    b.ToTable("Langues");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Linkedin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("id_candidat")
                        .HasColumnType("text");

                    b.Property<string>("linkedin")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("id_candidat")
                        .IsUnique();

                    b.ToTable("Linkedins");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Responsable_RH", b =>
                {
                    b.Property<int>("id_resp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<string>("e_mail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("mdp")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.HasKey("id_resp");

                    b.ToTable("Responsable_RH");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Competence", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany("competences")
                        .HasForeignKey("candidatId");

                    b.Navigation("candidat");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Experience_prof", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany("experiences")
                        .HasForeignKey("candidatId");

                    b.HasOne("ApplicationTEST.Models.Generer", "generer")
                        .WithMany("experience_profs")
                        .HasForeignKey("id_generer");

                    b.Navigation("candidat");

                    b.Navigation("generer");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Formation", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany("formations")
                        .HasForeignKey("candidatId");

                    b.HasOne("ApplicationTEST.Models.Generer", "generer")
                        .WithMany("formations")
                        .HasForeignKey("id_generer");

                    b.Navigation("candidat");

                    b.Navigation("generer");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Generer", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany()
                        .HasForeignKey("CandidatId");

                    b.Navigation("candidat");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Hobby", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany("hobbies")
                        .HasForeignKey("candidatId");

                    b.Navigation("candidat");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Langue", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithMany("langues")
                        .HasForeignKey("candidatId");

                    b.Navigation("candidat");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Linkedin", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", "candidat")
                        .WithOne("linkedin")
                        .HasForeignKey("ApplicationTEST.Models.Linkedin", "id_candidat");

                    b.Navigation("candidat");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationTEST.Models.Candidat", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationTEST.Models.Candidat", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationTEST.Models.Candidat", b =>
                {
                    b.Navigation("competences");

                    b.Navigation("experiences");

                    b.Navigation("formations");

                    b.Navigation("hobbies");

                    b.Navigation("langues");

                    b.Navigation("linkedin");
                });

            modelBuilder.Entity("ApplicationTEST.Models.Generer", b =>
                {
                    b.Navigation("experience_profs");

                    b.Navigation("formations");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Concrete.EFCore.Contexts;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230815083323_Modify_Prop_Name_Movies_IsReleased_IsInTheaters")]
    partial class Modify_Prop_Name_Movies_IsReleased_IsInTheaters
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("GenreMovieRole", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MovieRolesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MovieRolesId");

                    b.HasIndex("MovieRolesId");

                    b.ToTable("GenreMovieRole");
                });

            modelBuilder.Entity("LanguageMovie", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("LanguageMovie");
                });

            modelBuilder.Entity("LocationMovie", b =>
                {
                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("LocationsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("LocationMovie");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Award", b =>
                {
                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("AwardTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Year", "AwardTypeId");

                    b.HasIndex("AwardTypeId");

                    b.HasIndex("MovieId");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("Models.Concrete.Entities.AwardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AwardTypes");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationAsMinute")
                        .HasColumnType("int");

                    b.Property<bool>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("date");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies", t =>
                        {
                            t.HasTrigger("trg_UpdateMovies");
                        });
                });

            modelBuilder.Entity("Models.Concrete.Entities.MovieDetail", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("MovieDetails");
                });

            modelBuilder.Entity("Models.Concrete.Entities.MovieRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MovieRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MovieRole");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Models.Concrete.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("MovieMovieRole", b =>
                {
                    b.Property<int>("MovieRolesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("MovieRolesId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("MovieMovieRole");
                });

            modelBuilder.Entity("MovieRolePerson", b =>
                {
                    b.Property<int>("MovieRolesId")
                        .HasColumnType("int");

                    b.Property<int>("PersonsId")
                        .HasColumnType("int");

                    b.HasKey("MovieRolesId", "PersonsId");

                    b.HasIndex("PersonsId");

                    b.ToTable("MovieRolePerson");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Actor", b =>
                {
                    b.HasBaseType("Models.Concrete.Entities.MovieRole");

                    b.HasDiscriminator().HasValue("Actor");
                });

            modelBuilder.Entity("Models.Concrete.Entities.Director", b =>
                {
                    b.HasBaseType("Models.Concrete.Entities.MovieRole");

                    b.Property<string>("AlternativeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Director");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("Models.Concrete.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMovieRole", b =>
                {
                    b.HasOne("Models.Concrete.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.MovieRole", null)
                        .WithMany()
                        .HasForeignKey("MovieRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LanguageMovie", b =>
                {
                    b.HasOne("Models.Concrete.Entities.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocationMovie", b =>
                {
                    b.HasOne("Models.Concrete.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Concrete.Entities.Award", b =>
                {
                    b.HasOne("Models.Concrete.Entities.AwardType", "AwardType")
                        .WithMany()
                        .HasForeignKey("AwardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Movie", "Movie")
                        .WithMany("Awards")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwardType");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Models.Concrete.Entities.MovieDetail", b =>
                {
                    b.HasOne("Models.Concrete.Entities.Movie", "Movie")
                        .WithOne("MovieDetail")
                        .HasForeignKey("Models.Concrete.Entities.MovieDetail", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieMovieRole", b =>
                {
                    b.HasOne("Models.Concrete.Entities.MovieRole", null)
                        .WithMany()
                        .HasForeignKey("MovieRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieRolePerson", b =>
                {
                    b.HasOne("Models.Concrete.Entities.MovieRole", null)
                        .WithMany()
                        .HasForeignKey("MovieRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Concrete.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Concrete.Entities.Movie", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("MovieDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230310140246_MiddleName")]
    partial class MiddleName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp.Entity.Address", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("PersonId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ConsoleApp.Entity.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ConsoleApp.Entity.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("ConsoleApp.Entity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("HobbyPerson", b =>
                {
                    b.Property<int>("HobbiesId")
                        .HasColumnType("integer");

                    b.Property<int>("PersonsId")
                        .HasColumnType("integer");

                    b.HasKey("HobbiesId", "PersonsId");

                    b.HasIndex("PersonsId");

                    b.ToTable("HobbyPerson");
                });

            modelBuilder.Entity("ConsoleApp.Entity.Address", b =>
                {
                    b.HasOne("ConsoleApp.Entity.Person", "Person")
                        .WithOne("Address")
                        .HasForeignKey("ConsoleApp.Entity.Address", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ConsoleApp.Entity.Person", b =>
                {
                    b.HasOne("ConsoleApp.Entity.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HobbyPerson", b =>
                {
                    b.HasOne("ConsoleApp.Entity.Hobby", null)
                        .WithMany()
                        .HasForeignKey("HobbiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.Entity.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp.Entity.Person", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}

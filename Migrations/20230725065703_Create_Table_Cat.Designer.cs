﻿// <auto-generated />
using System;
using FirstWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230725065703_Create_Table_Cat")]
    partial class Create_Table_Cat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("FirstWeb.Models.Animals", b =>
                {
                    b.Property<string>("AnimalsName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimalsName");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animals");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FirstWeb.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("FirstWeb.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FirstWeb.Models.Cat", b =>
                {
                    b.HasBaseType("FirstWeb.Models.Animals");

                    b.Property<string>("CatCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CatID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Animals");

                    b.HasDiscriminator().HasValue("Cat");
                });

            modelBuilder.Entity("FirstWeb.Models.Dog", b =>
                {
                    b.HasBaseType("FirstWeb.Models.Animals");

                    b.Property<string>("DogAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DogID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Animals");

                    b.HasDiscriminator().HasValue("Dog");
                });
#pragma warning restore 612, 618
        }
    }
}

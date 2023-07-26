﻿// <auto-generated />
using FirstWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230726062110_Create_Foreignkey_Student")]
    partial class Create_Foreignkey_Student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("FirstWeb.Models.Animal", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Eat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Animal");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FirstWeb.Models.Employee", b =>
                {
                    b.Property<string>("EmpID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("FirstWeb.Models.Faculty", b =>
                {
                    b.Property<string>("FaculID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FaculName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FaculID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("FirstWeb.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("FirstWeb.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FaculID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MVS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FirstWeb.Models.Cat", b =>
                {
                    b.HasBaseType("FirstWeb.Models.Animal");

                    b.Property<string>("Sothich")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Animal");

                    b.HasDiscriminator().HasValue("Cat");
                });

            modelBuilder.Entity("FirstWeb.Models.Dog", b =>
                {
                    b.HasBaseType("FirstWeb.Models.Animal");

                    b.Property<string>("Chungloai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Animal");

                    b.HasDiscriminator().HasValue("Dog");
                });

            modelBuilder.Entity("FirstWeb.Models.Student", b =>
                {
                    b.HasOne("FirstWeb.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID");

                    b.Navigation("Faculty");
                });
#pragma warning restore 612, 618
        }
    }
}

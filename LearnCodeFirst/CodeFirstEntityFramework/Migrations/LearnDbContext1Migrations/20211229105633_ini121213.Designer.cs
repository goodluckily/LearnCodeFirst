﻿// <auto-generated />
using System;
using CodeFirstEntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstEntityFramework.Migrations.LearnDbContext1Migrations
{
    [DbContext(typeof(LearnDbContext1))]
    [Migration("20211229105633_ini121213")]
    partial class ini121213
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirstModel.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("school");
                });

            modelBuilder.Entity("CodeFirstModel.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("CodeFirstModel.Student", b =>
                {
                    b.HasOne("CodeFirstModel.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("CodeFirstModel.School", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

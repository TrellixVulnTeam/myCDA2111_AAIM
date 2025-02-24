﻿// <auto-generated />
using ApiCereals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCereals.Migrations
{
    [DbContext(typeof(CearealDbContext))]
    [Migration("20220324102433_lesson2")]
    partial class lesson2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiCereals.Models.Cereal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int")
                        .HasColumnName("Calories")
                        .HasComment("this is a comment for kellogg.Calories");

                    b.Property<int>("Carbo")
                        .HasColumnType("int")
                        .HasColumnName("Carbo");

                    b.Property<int>("Fiber")
                        .HasColumnType("int")
                        .HasColumnName("Fiber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("Potass")
                        .HasColumnType("int")
                        .HasColumnName("Potass");

                    b.Property<int>("Protein")
                        .HasColumnType("int")
                        .HasColumnName("Protein_different");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("Rating");

                    b.Property<int>("Sodium")
                        .HasColumnType("int")
                        .HasColumnName("Sodium");

                    b.Property<int>("Sugars")
                        .HasColumnType("int")
                        .HasColumnName("Sugars");

                    b.Property<int>("Vitamins")
                        .HasColumnType("int")
                        .HasColumnName("Vitamins");

                    b.HasKey("Id");

                    b.ToTable("kellogg");
                });
#pragma warning restore 612, 618
        }
    }
}

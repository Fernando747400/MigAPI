﻿// <auto-generated />
using APIF747.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIF747.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20221005231757_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("APIF747.Models.MovieItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("AudienceScore")
                        .HasColumnType("REAL");

                    b.Property<double>("Budget")
                        .HasColumnType("REAL");

                    b.Property<float>("CriticScore")
                        .HasColumnType("REAL");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("LeadActor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Revenue")
                        .HasColumnType("REAL");

                    b.Property<string>("SupportActor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Synopsis")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MovieItems");
                });
#pragma warning restore 612, 618
        }
    }
}
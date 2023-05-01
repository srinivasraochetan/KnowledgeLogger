﻿// <auto-generated />
using System;
using KnowledgeLogger.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KnowledgeLogger.Infrastructure.Migrations
{
    [DbContext(typeof(KnowledgeLoggerDBContext))]
    [Migration("20230501062221_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KnowledgeLogger.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("KnowledgeLogger.Domain.Models.KnowledgeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("LongDescription")
                        .HasColumnType("varchar");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(1,1)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("varchar(350)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime?>("Updated")
                        .IsRequired()
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("KnowledgeLogs", (string)null);
                });

            modelBuilder.Entity("KnowledgeLogger.Domain.Models.KnowledgeLog", b =>
                {
                    b.HasOne("KnowledgeLogger.Domain.Models.Category", "Category")
                        .WithMany("KnowledgeLog")
                        .HasForeignKey("CategoryId")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KnowledgeLogger.Domain.Models.Category", b =>
                {
                    b.Navigation("KnowledgeLog");
                });
#pragma warning restore 612, 618
        }
    }
}

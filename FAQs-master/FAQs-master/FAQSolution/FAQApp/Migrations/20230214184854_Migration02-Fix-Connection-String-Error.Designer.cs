﻿// <auto-generated />
using FAQApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FAQApp.Migrations
{
    [DbContext(typeof(FAQContext))]
    [Migration("20230214184854_Migration02-Fix-Connection-String-Error")]
    partial class Migration02FixConnectionStringError
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FAQApp.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "gen",
                            CategoryName = "General"
                        },
                        new
                        {
                            CategoryID = "hist",
                            CategoryName = "History"
                        });
                });

            modelBuilder.Entity("FAQApp.Models.Topic", b =>
                {
                    b.Property<string>("TopicID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicID = "cs",
                            TopicName = "C#"
                        },
                        new
                        {
                            TopicID = "js",
                            TopicName = "JavaScript"
                        },
                        new
                        {
                            TopicID = "boot",
                            TopicName = "Bootstrap"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

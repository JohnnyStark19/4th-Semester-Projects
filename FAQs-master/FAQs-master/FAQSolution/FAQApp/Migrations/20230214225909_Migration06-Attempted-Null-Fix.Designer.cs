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
    [Migration("20230214225909_Migration06-Attempted-Null-Fix")]
    partial class Migration06AttemptedNullFix
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

            modelBuilder.Entity("FAQApp.Models.FAQ", b =>
                {
                    b.Property<int>("FAQID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAQID"));

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FAQAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FAQQuestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FAQID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TopicID");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FAQID = 1,
                            CategoryID = "gen",
                            FAQAnswer = "A general purpose object-oriented programming language with a Java-like syntax.",
                            FAQQuestion = "What is C#?",
                            TopicID = "cs"
                        },
                        new
                        {
                            FAQID = 2,
                            CategoryID = "hist",
                            FAQAnswer = "In 2002.",
                            FAQQuestion = "What was C# first released?",
                            TopicID = "cs"
                        },
                        new
                        {
                            FAQID = 3,
                            CategoryID = "gen",
                            FAQAnswer = "A general purpose scripting language that executes in a web browser.",
                            FAQQuestion = "What is JavaScript?",
                            TopicID = "js"
                        },
                        new
                        {
                            FAQID = 4,
                            CategoryID = "hist",
                            FAQAnswer = "In 1995.",
                            FAQQuestion = "What was JavaScript first released?",
                            TopicID = "js"
                        },
                        new
                        {
                            FAQID = 5,
                            CategoryID = "gen",
                            FAQAnswer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                            FAQQuestion = "What is Bootstrap?",
                            TopicID = "boot"
                        },
                        new
                        {
                            FAQID = 6,
                            CategoryID = "hist",
                            FAQAnswer = "In 2011.",
                            FAQQuestion = "What was Bootstrap first released?",
                            TopicID = "boot"
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

            modelBuilder.Entity("FAQApp.Models.FAQ", b =>
                {
                    b.HasOne("FAQApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAQApp.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}

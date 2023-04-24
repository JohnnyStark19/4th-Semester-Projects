using System;
using Microsoft.EntityFrameworkCore;

namespace FAQApp.Models
{
    public class FAQContext : DbContext
    {
        //  Constructor
        public FAQContext(DbContextOptions<FAQContext> options)
            : base(options) {}

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }

        //  Add seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic {  TopicID = "cs", TopicName = "C#"},
                new Topic {  TopicID = "js", TopicName = "JavaScript"},
                new Topic {  TopicID = "boot", TopicName = "Bootstrap" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category {  CategoryID = "gen", CategoryName = "General" },
                new Category {  CategoryID = "hist", CategoryName = "History" }
            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQID = 1,
                    FAQQuestion = "What is C#?",
                    FAQAnswer = "A general purpose object-oriented programming language with a Java-like syntax.",
                    TopicID = "cs",
                    CategoryID = "gen"
                },
                new FAQ
                {
                    FAQID = 2,
                    FAQQuestion = "What was C# first released?",
                    FAQAnswer = "In 2002.",
                    TopicID = "cs",
                    CategoryID = "hist"
                },
                new FAQ
                {
                    FAQID = 3,
                    FAQQuestion = "What is JavaScript?",
                    FAQAnswer = "A general purpose scripting language that executes in a web browser.",
                    TopicID = "js",
                    CategoryID = "gen"
                },
                new FAQ
                {
                    FAQID = 4,
                    FAQQuestion = "What was JavaScript first released?",
                    FAQAnswer = "In 1995.",
                    TopicID = "js",
                    CategoryID = "hist"
                },
                new FAQ
                {
                    FAQID = 5,
                    FAQQuestion = "What is Bootstrap?",
                    FAQAnswer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    TopicID = "boot",
                    CategoryID = "gen"
                },
                new FAQ
                {
                    FAQID = 6,
                    FAQQuestion = "What was Bootstrap first released?",
                    FAQAnswer = "In 2011.",
                    TopicID = "boot",
                    CategoryID = "hist"
                }
            );
        }

    }
}

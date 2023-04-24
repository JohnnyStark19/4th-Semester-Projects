using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FAQApp.Migrations
{
    /// <inheritdoc />
    public partial class Migration05AddedFAQTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAQAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQID);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQID", "CategoryID", "FAQAnswer", "FAQQuestion", "TopicID" },
                values: new object[,]
                {
                    { 1, "gen", "A general purpose object-oriented programming language with a Java-like syntax.", "What is C#?", "cs" },
                    { 2, "hist", "In 2002.", "What was C# first released?", "cs" },
                    { 3, "gen", "A general purpose scripting language that executes in a web browser.", "What is JavaScript?", "js" },
                    { 4, "hist", "In 1995.", "What was JavaScript first released?", "js" },
                    { 5, "gen", "A CSS framework for creating responsive web apps for multiple screen sizes.", "What is Bootstrap?", "boot" },
                    { 6, "hist", "In 2011.", "What was Bootstrap first released?", "boot" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryID",
                table: "FAQs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicID",
                table: "FAQs",
                column: "TopicID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");
        }
    }
}

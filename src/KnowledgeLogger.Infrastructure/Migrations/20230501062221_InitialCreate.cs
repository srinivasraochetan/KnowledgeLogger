using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeLogger.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(150)", nullable: false),
                    ShortDescription = table.Column<string>(type: "varchar(350)", nullable: false),
                    LongDescription = table.Column<string>(type: "varchar", nullable: true),
                    Author = table.Column<string>(type: "varchar(150)", nullable: false),
                    Created = table.Column<DateTime>(type: "date", nullable: false),
                    Updated = table.Column<DateTime>(type: "date", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(1,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnowledgeLogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgeLogs_CategoryId",
                table: "KnowledgeLogs",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnowledgeLogs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "9780743273565", 10.99, "The Great Gatsby" },
                    { 2, "Harper Lee", "9780061120084", 7.9900000000000002, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "9780451524935", 9.9900000000000002, "1984" },
                    { 4, "Jane Austen", "9780141439518", 6.9900000000000002, "Pride and Prejudice" },
                    { 5, "J.D. Salinger", "9780316769488", 8.9900000000000002, "The Catcher in the Rye" },
                    { 6, "Naeem", "1111", 100.0, "Bangladesh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);
        }
    }
}

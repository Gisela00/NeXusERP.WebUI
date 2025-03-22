using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24faa09-3e49-4f8f-92dd-437f7a5db348", "rgise06@gmail.com", null, "AQAAAAIAAYagAAAAEBie6KmK8I2nqbQFhID+BuQ8ICfGl97/1d9mcyTd/UQKKOK4gLk5GQp5pNxRga4E9w==", "a5a90251-bc8b-493d-aa12-f8fec1b0abd3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9308ca0-d23a-42df-914d-7e185c33cd59", null, "rgise06@gmail.com", "AQAAAAIAAYagAAAAEB4I6Ak9AKx0ExIluo4ENwLa1tL8i/4wZ2JV6fWHNvf9X/sL9o7ybMxQLwJFhCvkTg==", "ac1670bb-0d85-4c04-89a5-19ab7a4a8bfd" });
        }
    }
}

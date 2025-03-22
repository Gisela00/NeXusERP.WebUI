using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, 0, "c9308ca0-d23a-42df-914d-7e185c33cd59", "rgise06@gmail.com", true, "", "", false, null, null, "rgise06@gmail.com", "AQAAAAIAAYagAAAAEB4I6Ak9AKx0ExIluo4ENwLa1tL8i/4wZ2JV6fWHNvf9X/sL9o7ybMxQLwJFhCvkTg==", null, false, "ac1670bb-0d85-4c04-89a5-19ab7a4a8bfd", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}

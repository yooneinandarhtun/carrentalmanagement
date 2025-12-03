using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace carrentalmanagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1421), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1438), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1442), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1442), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1568), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1569), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1571), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1571), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1623), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1623), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1625), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1626), "x5", "System" },
                    { 3, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1627), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1628), new DateTime(2025, 12, 3, 14, 55, 15, 425, DateTimeKind.Local).AddTicks(1629), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

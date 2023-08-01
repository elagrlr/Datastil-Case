using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataStillCase.Data.Migrations
{
    /// <inheritdoc />
    public partial class VisitorsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                columns: new[] { "Id", "CityId", "Date", "VisitorCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 4, 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300 },
                    { 5, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 6, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 7, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 8, 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350 },
                    { 9, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400 },
                    { 10, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 11, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250 },
                    { 12, 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450 },
                    { 13, 34, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 14, 34, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600 },
                    { 15, 34, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 16, 34, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300 },
                    { 17, 35, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 18, 35, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250 },
                    { 19, 35, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300 },
                    { 20, 35, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 21, 42, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 22, 42, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250 },
                    { 23, 42, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 24, 42, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230 },
                    { 25, 6, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350 },
                    { 26, 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 275 },
                    { 27, 6, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450 },
                    { 28, 6, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "VISITORHISTORIES",
                keyColumn: "Id",
                keyValue: 28);
        }
    }
}

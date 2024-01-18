using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicDev.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescriptionMaxLengthAndDatePub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfPublish",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "DateOfPublish",
                value: new DateTime(2024, 1, 18, 20, 42, 58, 59, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "DateOfPublish",
                value: new DateTime(2024, 1, 18, 20, 42, 58, 59, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "DateOfPublish",
                value: new DateTime(2024, 1, 18, 20, 42, 58, 59, DateTimeKind.Utc).AddTicks(3962));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfPublish",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeRecordsIdentity.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cups",
                table: "Cups");

            migrationBuilder.AlterColumn<int>(
                name: "CoffeeCupId",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Cups",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cups",
                table: "Cups",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cups",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Cups");

            migrationBuilder.AlterColumn<int>(
                name: "CoffeeCupId",
                table: "Cups",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cups",
                table: "Cups",
                column: "CoffeeCupId");
        }
    }
}

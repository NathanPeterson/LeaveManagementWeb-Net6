using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec8bbadf-6667-47bf-6969-aaaaca8667fb", "2bbcfa7f-4ea6-4841-9010-42275da6b2fd", "User", "USER" },
                    { "ec8bbadf-6667-47bf-6969-de5fca8667fb", "b8654484-9aec-43bd-aac5-03fb3ef56958", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ec8bbadf-65f4-47bf-ba86-de5fca8667fb", 0, "89dbf130-f569-401f-9918-0f3179a91a36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEFQzVqP0bQOEHriB0PfsDB7RlWzr4ORe9d9dMvbkxMd/kVz/YMa1CgYRKcwswRNPkQ==", null, false, "d4407c21-7fba-473e-835b-15eadf4eec07", null, false, null },
                    { "ec8bbadf-65f4-ffff-ba86-de5fca8667fb", 0, "d74d3810-9dcb-4cf9-9398-3e440ba71f58", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEM2/rgfJxNL0MjkNj4tDiclI595G9HvVKysKyTylWlEY6xGQw2OdWew6EK+32KqyOQ==", null, false, "3f8f4153-bb55-4b32-9c03-e24ae7210b98", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec8bbadf-6667-47bf-6969-de5fca8667fb", "ec8bbadf-65f4-47bf-ba86-de5fca8667fb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec8bbadf-6667-47bf-6969-aaaaca8667fb", "ec8bbadf-65f4-ffff-ba86-de5fca8667fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec8bbadf-6667-47bf-6969-de5fca8667fb", "ec8bbadf-65f4-47bf-ba86-de5fca8667fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec8bbadf-6667-47bf-6969-aaaaca8667fb", "ec8bbadf-65f4-ffff-ba86-de5fca8667fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-aaaaca8667fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-de5fca8667fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-47bf-ba86-de5fca8667fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-ffff-ba86-de5fca8667fb");
        }
    }
}

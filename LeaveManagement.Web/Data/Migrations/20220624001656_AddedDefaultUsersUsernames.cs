using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-aaaaca8667fb",
                column: "ConcurrencyStamp",
                value: "486013b5-860a-4a6c-b2d0-50187c41830d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-de5fca8667fb",
                column: "ConcurrencyStamp",
                value: "1ac812bb-6be9-4c20-a468-3e94d18a513a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-47bf-ba86-de5fca8667fb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "77558dd5-9556-47de-a439-676c8f55d813", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEAbsxaYs+PwcG+JLseKM65xu7lTCyVsLzKp7xsr1J/xxOEgGXVVLl9WLsWVvSMKCTA==", "444c7541-8e80-45ac-ba32-bbcc9937eb6c", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-ffff-ba86-de5fca8667fb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c95394f8-ec6a-412a-8674-d138015c732c", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEL5tF5GoenPlKabj9OzvGRFPudWuVFcTpjxQ+tZU/WU2e4TgiYgsWO94uGyJ7DdwEg==", "3ac6d606-626e-4a37-8c4f-3dbd7bc38379", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-aaaaca8667fb",
                column: "ConcurrencyStamp",
                value: "2bbcfa7f-4ea6-4841-9010-42275da6b2fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8bbadf-6667-47bf-6969-de5fca8667fb",
                column: "ConcurrencyStamp",
                value: "b8654484-9aec-43bd-aac5-03fb3ef56958");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-47bf-ba86-de5fca8667fb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "89dbf130-f569-401f-9918-0f3179a91a36", false, null, "AQAAAAEAACcQAAAAEFQzVqP0bQOEHriB0PfsDB7RlWzr4ORe9d9dMvbkxMd/kVz/YMa1CgYRKcwswRNPkQ==", "d4407c21-7fba-473e-835b-15eadf4eec07", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8bbadf-65f4-ffff-ba86-de5fca8667fb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d74d3810-9dcb-4cf9-9398-3e440ba71f58", false, null, "AQAAAAEAACcQAAAAEM2/rgfJxNL0MjkNj4tDiclI595G9HvVKysKyTylWlEY6xGQw2OdWew6EK+32KqyOQ==", "3f8f4153-bb55-4b32-9c03-e24ae7210b98", null });
        }
    }
}

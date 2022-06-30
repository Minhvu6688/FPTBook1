using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook1.Data.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5527152c-f5cb-4c6c-8813-d42e6fb10f1f", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "a62f5cad-6420-4a3d-80b1-301e5e996e9b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "DN", "3287b9dc-1954-4e54-80c5-44b7c709a235", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DN");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47440679-99bb-4244-9dec-105eea649ab8", "Manager", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "b2f47acc-3c44-4a3a-852c-363014c15d36");
        }
    }
}

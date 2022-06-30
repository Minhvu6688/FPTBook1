using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook1.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Roles = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    Order_Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_User_UserName",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "1976fa43-e95c-4345-8a4b-2fb59c3baf9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "0b1e11bb-8710-4638-b204-555edeb43934");

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "BookId", "Order_Date", "Quantity", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 2, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 3, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_BookId",
                table: "Carts",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserName",
                table: "Carts",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "1f6337a3-4d89-463c-8935-3665db92e987");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "e8a9d9fb-26cf-4049-b109-d8efa7b68522");
        }
    }
}

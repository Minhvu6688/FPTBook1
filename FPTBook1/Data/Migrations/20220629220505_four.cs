using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook1.Data.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order_Date",
                table: "Carts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Cart_Date",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "47440679-99bb-4244-9dec-105eea649ab8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "b2f47acc-3c44-4a3a-852c-363014c15d36");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cart_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cart_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cart_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cart_Date",
                table: "Carts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Order_Date",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Order_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Order_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Order_Date",
                value: new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

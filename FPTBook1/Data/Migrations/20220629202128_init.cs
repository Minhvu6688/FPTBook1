using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook1.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, null, "Truyen thieu nhi" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 2, null, "Truyen Tranh" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 3, null, "Sach Khoa hoc" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "https://store-images.s-microsoft.com/image/apps.22817.9007199266705314.fd912ef5-5ce8-41d7-a270-2a522ef4542a.452c3f51-eed5-43eb-b715-11c508dfb2c7?mode=scale&q=90&h=300&w=300", "O Long vien", 25000.0, 10 },
                    { 2, 1, "https://salt.tikicdn.com/ts/product/e4/10/e3/1396373bfbafe6f8787bc7df79208060.jpg", "Doraemon", 30000.0, 20 },
                    { 3, 2, "https://cdn0.fahasa.com/media/catalog/product/t/h/tham_tu_lung_danh_conan_tap_98.jpg", "Conan", 35000.0, 30 },
                    { 4, 2, "https://vn-live-05.slatic.net/p/42ac175de9b46a1e8289cc017db87cf3.jpg_525x525q80.jpg", "7 vien ngoc rong", 40000.0, 40 },
                    { 5, 3, "https://product.hstatic.net/200000343865/product/5_86_de30021142e34329b8662b2919a7e127_master.jpg", "Ty Quay", 18000.0, 60 },
                    { 6, 3, "https://i.imgur.com/toLtUQd.jpg", "Truyen ma", 17000.0, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}

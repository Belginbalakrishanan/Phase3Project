using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeProject1.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    LaptopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaptopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaptopDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaptopRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.LaptopId);
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "LaptopId", "LaptopDescription", "LaptopName", "LaptopRate" },
                values: new object[] { 201, "12th Generation Intel® Core™ i3 processor\r\nFreeDOS 3.0\r\n(15.6) 39.62 cm diagonal, HD anti-glare display with Intel® Iris® Xᵉ Graphics\r\n8 GB DDR4-3200 MHz RAM (1 x 8 GB)", "HP", 48000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptops");
        }
    }
}

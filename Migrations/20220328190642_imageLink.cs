using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab3.Migrations
{
    public partial class imageLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Product",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Product");
        }
    }
}

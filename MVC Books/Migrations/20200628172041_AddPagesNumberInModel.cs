using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Books.Migrations
{
    public partial class AddPagesNumberInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pages_Number",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pages_Number",
                table: "Book");
        }
    }
}

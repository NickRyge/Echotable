using Microsoft.EntityFrameworkCore.Migrations;

namespace PopoErEnLuder.Migrations
{
    public partial class header : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "Post",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "Post");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCollection.Migrations
{
    public partial class CorrectForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

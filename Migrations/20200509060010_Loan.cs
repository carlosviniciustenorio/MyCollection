using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCollection.Migrations
{
    public partial class Loan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Loan",
                table: "Item",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loan",
                table: "Item");
        }
    }
}

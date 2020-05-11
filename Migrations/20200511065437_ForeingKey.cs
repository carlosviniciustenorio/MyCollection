using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCollection.Migrations
{
    public partial class ForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItensId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ItensId",
                table: "User",
                column: "ItensId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Item_ItensId",
                table: "User",
                column: "ItensId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Item_ItensId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ItensId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ItensId",
                table: "User");
        }
    }
}

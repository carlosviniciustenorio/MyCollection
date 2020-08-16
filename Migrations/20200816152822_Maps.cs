using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCollection.Migrations
{
    public partial class Maps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinculo_Item_ItensId",
                table: "Vinculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Item_Type_Enum_Constraint",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Itens");

            migrationBuilder.CreateCheckConstraint(
                name: "CK_Itens_Type_Enum_Constraint",
                table: "Itens",
                sql: "[Type] IN(1, 2, 3)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Itens",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Itens",
                table: "Itens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinculo_Itens_ItensId",
                table: "Vinculo",
                column: "ItensId",
                principalTable: "Itens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinculo_Itens_ItensId",
                table: "Vinculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Itens",
                table: "Itens");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Itens_Type_Enum_Constraint",
                table: "Itens");

            migrationBuilder.RenameTable(
                name: "Itens",
                newName: "Item");

            migrationBuilder.CreateCheckConstraint(
                name: "CK_Item_Type_Enum_Constraint",
                table: "Item",
                sql: "[Type] IN(1, 2, 3)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinculo_Item_ItensId",
                table: "Vinculo",
                column: "ItensId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

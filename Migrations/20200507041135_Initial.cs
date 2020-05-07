using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_Locations_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrowed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    NameResponsible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneResponsible = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrowed_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowed_ItemId",
                table: "Borrowed",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_PlaceId",
                table: "Itens",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowed");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}

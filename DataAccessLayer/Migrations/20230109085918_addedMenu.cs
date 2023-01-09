using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addedMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menuler",
                columns: table => new
                {
                    menuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuler", x => x.menuId);
                    table.ForeignKey(
                        name: "FK_menuler_menuler_parentId",
                        column: x => x.parentId,
                        principalTable: "menuler",
                        principalColumn: "menuId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_menuler_parentId",
                table: "menuler",
                column: "parentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menuler");
        }
    }
}

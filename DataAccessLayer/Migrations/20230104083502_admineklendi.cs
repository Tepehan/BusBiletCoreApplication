using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class admineklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminler",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    adminPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    adminEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    adminType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminler", x => x.adminId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminler");
        }
    }
}

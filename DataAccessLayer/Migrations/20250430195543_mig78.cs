using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig78 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "özelliklers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_özelliklers", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "özelliklers");
        }
    }
}

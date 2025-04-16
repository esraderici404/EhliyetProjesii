using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hakkımızdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<int>(type: "int", nullable: false),
                    Picture1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buton = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkımızdas", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hakkımızdas");
        }
    }
}

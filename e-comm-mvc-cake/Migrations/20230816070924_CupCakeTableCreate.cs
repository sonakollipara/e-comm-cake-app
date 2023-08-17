using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_comm_mvc_cake.Migrations
{
    public partial class CupCakeTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CakeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CakeFlavour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cookies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CookieImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookieName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CookieFlavour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CupCakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupCakeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CupCakeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CupCakeFlavour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupCakes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cakes");

            migrationBuilder.DropTable(
                name: "Cookies");

            migrationBuilder.DropTable(
                name: "CupCakes");
        }
    }
}

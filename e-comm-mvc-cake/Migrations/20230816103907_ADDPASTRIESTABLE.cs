using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_comm_mvc_cake.Migrations
{
    public partial class ADDPASTRIESTABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pastries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastryImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PastryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PastryFlavour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pastries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pastries");
        }
    }
}

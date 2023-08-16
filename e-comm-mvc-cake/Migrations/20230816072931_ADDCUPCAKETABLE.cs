using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_comm_mvc_cake.Migrations
{
    public partial class ADDCUPCAKETABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "CupCakes");
        }
    }
}

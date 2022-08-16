using Microsoft.EntityFrameworkCore.Migrations;

namespace Medicine.Microservice.Migrations
{
    public partial class medinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Med_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Badge = table.Column<int>(type: "int", nullable: false),
                    Init_Quantity = table.Column<int>(type: "int", nullable: false),
                    Curr_Quantity = table.Column<int>(type: "int", nullable: false),
                    Exp_Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Med_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicines");
        }
    }
}

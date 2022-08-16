using Microsoft.EntityFrameworkCore.Migrations;

namespace Medicine.Microservice.Migrations
{
    public partial class medseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Med_Id", "Badge", "Curr_Quantity", "Exp_Date", "Init_Quantity", "Name" },
                values: new object[] { 1, 9854145, 2500, "01-12-2025", 5000, "Amikacin" });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Med_Id", "Badge", "Curr_Quantity", "Exp_Date", "Init_Quantity", "Name" },
                values: new object[] { 2, 8424956, 1000, "01-12-2025", 5000, "Crizotinib" });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Med_Id", "Badge", "Curr_Quantity", "Exp_Date", "Init_Quantity", "Name" },
                values: new object[] { 3, 4594252, 3280, "01-12-2025", 5000, "Etoposid" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Med_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Med_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Med_Id",
                keyValue: 3);
        }
    }
}

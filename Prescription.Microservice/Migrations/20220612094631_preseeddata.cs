using Microsoft.EntityFrameworkCore.Migrations;

namespace Prescription.Microservice.Migrations
{
    public partial class preseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Prs_Id", "Date", "Doc_Id", "Med_Id", "Pat_Id", "Quantity" },
                values: new object[] { 1, "05-06-2022", 1, 2, 2, 18 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Prs_Id", "Date", "Doc_Id", "Med_Id", "Pat_Id", "Quantity" },
                values: new object[] { 2, "10-06-2022", 2, 1, 3, 27 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Prs_Id", "Date", "Doc_Id", "Med_Id", "Pat_Id", "Quantity" },
                values: new object[] { 3, "07-06-2022", 3, 3, 1, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Prs_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Prs_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Prs_Id",
                keyValue: 3);
        }
    }
}

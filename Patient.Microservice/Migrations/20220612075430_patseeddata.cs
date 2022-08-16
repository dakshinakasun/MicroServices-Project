using Microsoft.EntityFrameworkCore.Migrations;

namespace Patient.Microservice.Migrations
{
    public partial class patseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Pat_Id", "Address", "Age", "Contact_No", "Email", "Gender", "Name" },
                values: new object[] { 1, "Kaluthara", 35, "0761234567", "kamal@gmail.com", "Male", "Mr.Kamal Suraweera" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Pat_Id", "Address", "Age", "Contact_No", "Email", "Gender", "Name" },
                values: new object[] { 2, "Colombo", 28, "0711234567", "fernando@gmail.com", "Male", "Mr.Amal Fernando" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Pat_Id", "Address", "Age", "Contact_No", "Email", "Gender", "Name" },
                values: new object[] { 3, "Gampaha", 30, "0771234567", "manuka@gmail.com", "Male", "Mr.Manuka Liyanage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Pat_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Pat_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Pat_Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Doctor.Microservice.Migrations
{
    public partial class docseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doc_Id", "Age", "Contact_No", "Email", "Gender", "Name", "Spec_Type" },
                values: new object[] { 1, 25, "0761234567", "kasun@gmail.com", "Male", "Dr.Dakshina Kasun", "Cardiologists" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doc_Id", "Age", "Contact_No", "Email", "Gender", "Name", "Spec_Type" },
                values: new object[] { 2, 24, "0711234567", "akash@gmail.com", "Male", "Dr.Kaveen Akash", "Allergists" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doc_Id", "Age", "Contact_No", "Email", "Gender", "Name", "Spec_Type" },
                values: new object[] { 3, 24, "0771234567", "deshani@gmail.com", "Female", "Dr.Deshani Dakshima", "Neurologists" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doc_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doc_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doc_Id",
                keyValue: 3);
        }
    }
}

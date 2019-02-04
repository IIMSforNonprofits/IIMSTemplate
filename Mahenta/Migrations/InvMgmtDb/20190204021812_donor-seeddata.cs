using Microsoft.EntityFrameworkCore.Migrations;

namespace Mahenta.Migrations.InvMgmtDb
{
    public partial class donorseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Donors",
                columns: new[] { "ID", "Address", "CompanyName", "DonorEntity", "DonorName", "Email", "JobTitle", "PhoneNumber", "TotalDonations" },
                values: new object[,]
                {
                    { 1, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 2, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 3, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 4, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 5, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 6, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 },
                    { 7, null, null, 0, "Jon Doe", "email1@gmail.com", null, "1234567890", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}

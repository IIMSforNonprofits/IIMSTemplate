using Microsoft.EntityFrameworkCore.Migrations;

namespace Mahenta.Migrations.InvMgmtDb
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Availability", "Color", "Condition", "Description", "DonorID", "EstimatedValue", "Name", "OrderID", "Size", "Sku", "Use" },
                values: new object[,]
                {
                    { 1, 0, null, null, "It's crumptious, when it crunches", 1, null, "Crunch Bar", null, null, "PROD001", null },
                    { 2, 0, null, null, "It's out of this woooooorld", 2, null, "Mars bar", null, null, "PROD002", null },
                    { 3, 0, null, null, "Guess whose back...wait wrong kind of wrapper", 3, null, "M&Ms", null, null, "PROD003", null },
                    { 4, 0, null, null, "M&Ms without chocolate", 4, null, "Skittles", null, null, "PROD004", null },
                    { 5, 0, null, null, "Left, left, right, right...", 5, null, "Twix", null, null, "PROD005", null },
                    { 6, 0, null, null, "Pokey", 6, null, "Pocky", null, null, "PROD006", null },
                    { 7, 0, null, null, "ha, I wish", 7, null, "100 Grand", null, null, "PROD007", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}

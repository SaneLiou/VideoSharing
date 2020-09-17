using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoSharing.Data.Migrations
{
    public partial class AddRoles_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a6d635-df37-4ef5-8c13-750c7979afea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "945abf06-998e-46ef-bf9f-1899997f56a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67b50161-5a2b-4a87-bb68-5d8183e985e8", "0731d13a-720e-41a6-96f8-f2b48007e149", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3e5f9c6-cc17-4637-be25-d3bb4ae45123", "5ceb1921-20db-4744-9a8a-caa790e96999", "RegisteredUser", "REGISTEREDUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85fb27b0-52b3-4852-b91d-782a821dafe8", "97e723f8-1560-4554-bc99-63bd434d930a", "Administration", "ADMINISTRATION" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67b50161-5a2b-4a87-bb68-5d8183e985e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85fb27b0-52b3-4852-b91d-782a821dafe8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3e5f9c6-cc17-4637-be25-d3bb4ae45123");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "945abf06-998e-46ef-bf9f-1899997f56a9", "9dfb7752-cffb-4d9b-8b63-12b4dc66b4f6", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93a6d635-df37-4ef5-8c13-750c7979afea", "75bf675a-1567-4423-89a3-c8497f0c5701", "Administration", "ADMINISTRATION" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoSharing.Data.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "945abf06-998e-46ef-bf9f-1899997f56a9", "9dfb7752-cffb-4d9b-8b63-12b4dc66b4f6", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93a6d635-df37-4ef5-8c13-750c7979afea", "75bf675a-1567-4423-89a3-c8497f0c5701", "Administration", "ADMINISTRATION" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a6d635-df37-4ef5-8c13-750c7979afea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "945abf06-998e-46ef-bf9f-1899997f56a9");
        }
    }
}

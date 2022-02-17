using Microsoft.EntityFrameworkCore.Migrations;

namespace Rise_Tech_Rehber.Data.Migrations
{
    public partial class Rehber_17022022_0343 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IT_ID",
                table: "ILETISIMTIPLER",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IB_ID",
                table: "ILETISIMBILGILER",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ILETISIMTIPLER",
                newName: "IT_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ILETISIMBILGILER",
                newName: "IB_ID");
        }
    }
}

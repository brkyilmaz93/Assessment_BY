using Microsoft.EntityFrameworkCore.Migrations;

namespace Rise_Tech_Rehber.Data.Migrations
{
    public partial class Rehber_16022022_2120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SilinmisMi",
                table: "KISILER",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SilinmisMi",
                table: "ILETISIMTIPLER",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SilinmisMi",
                table: "ILETISIMBILGILER",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SilinmisMi",
                table: "KISILER");

            migrationBuilder.DropColumn(
                name: "SilinmisMi",
                table: "ILETISIMTIPLER");

            migrationBuilder.DropColumn(
                name: "SilinmisMi",
                table: "ILETISIMBILGILER");
        }
    }
}

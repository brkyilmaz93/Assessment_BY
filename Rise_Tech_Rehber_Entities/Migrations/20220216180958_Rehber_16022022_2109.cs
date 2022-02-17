using Microsoft.EntityFrameworkCore.Migrations;

namespace Rise_Tech_Rehber.Data.Migrations
{
    public partial class Rehber_16022022_2109 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UU_ID",
                table: "ILETISIMBILGILER",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UU_ID",
                table: "ILETISIMBILGILER");
        }
    }
}

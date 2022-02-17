using Microsoft.EntityFrameworkCore.Migrations;

namespace Rise_Tech_Rehber.Data.Migrations
{
    public partial class Rehber_17022022_0339 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ILETISIMBILGILER_KISILER_KisiUU_ID",
                table: "ILETISIMBILGILER");

            migrationBuilder.RenameColumn(
                name: "UU_ID",
                table: "KISILER",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "KisiUU_ID",
                table: "ILETISIMBILGILER",
                newName: "KisiId");

            migrationBuilder.RenameIndex(
                name: "IX_ILETISIMBILGILER_KisiUU_ID",
                table: "ILETISIMBILGILER",
                newName: "IX_ILETISIMBILGILER_KisiId");

            migrationBuilder.AddForeignKey(
                name: "FK_ILETISIMBILGILER_KISILER_KisiId",
                table: "ILETISIMBILGILER",
                column: "KisiId",
                principalTable: "KISILER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ILETISIMBILGILER_KISILER_KisiId",
                table: "ILETISIMBILGILER");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KISILER",
                newName: "UU_ID");

            migrationBuilder.RenameColumn(
                name: "KisiId",
                table: "ILETISIMBILGILER",
                newName: "KisiUU_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ILETISIMBILGILER_KisiId",
                table: "ILETISIMBILGILER",
                newName: "IX_ILETISIMBILGILER_KisiUU_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ILETISIMBILGILER_KISILER_KisiUU_ID",
                table: "ILETISIMBILGILER",
                column: "KisiUU_ID",
                principalTable: "KISILER",
                principalColumn: "UU_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Rise_Tech_Rehber.Data.Migrations
{
    public partial class Rehber_16022022_2000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ILETISIMTIPLER",
                columns: table => new
                {
                    IT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipAdı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILETISIMTIPLER", x => x.IT_ID);
                });

            migrationBuilder.CreateTable(
                name: "KISILER",
                columns: table => new
                {
                    UU_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KISILER", x => x.UU_ID);
                });

            migrationBuilder.CreateTable(
                name: "ILETISIMBILGILER",
                columns: table => new
                {
                    IB_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilgiIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IT_ID = table.Column<int>(type: "int", nullable: false),
                    KisiUU_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILETISIMBILGILER", x => x.IB_ID);
                    table.ForeignKey(
                        name: "FK_ILETISIMBILGILER_ILETISIMTIPLER_IT_ID",
                        column: x => x.IT_ID,
                        principalTable: "ILETISIMTIPLER",
                        principalColumn: "IT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ILETISIMBILGILER_KISILER_KisiUU_ID",
                        column: x => x.KisiUU_ID,
                        principalTable: "KISILER",
                        principalColumn: "UU_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ILETISIMBILGILER_IT_ID",
                table: "ILETISIMBILGILER",
                column: "IT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ILETISIMBILGILER_KisiUU_ID",
                table: "ILETISIMBILGILER",
                column: "KisiUU_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ILETISIMBILGILER");

            migrationBuilder.DropTable(
                name: "ILETISIMTIPLER");

            migrationBuilder.DropTable(
                name: "KISILER");
        }
    }
}

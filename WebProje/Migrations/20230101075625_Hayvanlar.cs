using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje.Migrations
{
    public partial class Hayvanlar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hayvan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HayvanResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sahiplenildimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sahiplenme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanId = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    dogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    soru1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soru2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soru3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soru4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahiplenme", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hayvan");

            migrationBuilder.DropTable(
                name: "Sahiplenme");
        }
    }
}

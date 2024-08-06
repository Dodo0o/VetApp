using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetApp.Migrations
{
    /// <inheritdoc />
    public partial class Deneme1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asilar",
                columns: table => new
                {
                    AsiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanID = table.Column<int>(type: "int", nullable: false),
                    AsiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asilar", x => x.AsiID);
                    table.ForeignKey(
                        name: "FK_Asilar_Hayvanlar_HayvanID",
                        column: x => x.HayvanID,
                        principalTable: "Hayvanlar",
                        principalColumn: "HayvanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TibbiKayitlar",
                columns: table => new
                {
                    TibbiKayitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanID = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TibbiKayitlar", x => x.TibbiKayitID);
                    table.ForeignKey(
                        name: "FK_TibbiKayitlar_Hayvanlar_HayvanID",
                        column: x => x.HayvanID,
                        principalTable: "Hayvanlar",
                        principalColumn: "HayvanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asilar_HayvanID",
                table: "Asilar",
                column: "HayvanID");

            migrationBuilder.CreateIndex(
                name: "IX_TibbiKayitlar_HayvanID",
                table: "TibbiKayitlar",
                column: "HayvanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asilar");

            migrationBuilder.DropTable(
                name: "TibbiKayitlar");
        }
    }
}

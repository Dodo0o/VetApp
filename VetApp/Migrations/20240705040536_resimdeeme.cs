using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetApp.Migrations
{
    /// <inheritdoc />
    public partial class resimdeeme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResimYolu",
                table: "Hayvanlar",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimYolu",
                table: "Hayvanlar");
        }
    }
}

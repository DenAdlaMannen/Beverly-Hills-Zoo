using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class animalMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cucumber_MaxDepth",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dragon_MaxAltitude",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Hedgehog_Speed",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Plankton_MaxDepth",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Snake_Speed",
                table: "Animals",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cucumber_MaxDepth",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Dragon_MaxAltitude",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Hedgehog_Speed",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Plankton_MaxDepth",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Snake_Speed",
                table: "Animals");
        }
    }
}

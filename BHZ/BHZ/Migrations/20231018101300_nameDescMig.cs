using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class nameDescMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ant_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ant_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Crab_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Crab_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cucumber_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cucumber_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dragon_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dragon_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hedgehog_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hedgehog_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plankton_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plankton_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Snake_AnimalDescription",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Snake_AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Ant_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Ant_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Crab_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Crab_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Cucumber_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Cucumber_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Dragon_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Dragon_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Hedgehog_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Hedgehog_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Plankton_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Plankton_AnimalName",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Snake_AnimalDescription",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Snake_AnimalName",
                table: "Animals");
        }
    }
}

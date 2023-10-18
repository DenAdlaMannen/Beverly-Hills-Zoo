using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class initalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dragon_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Dragon_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Dragon_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    WeightMin = table.Column<int>(type: "int", nullable: true),
                    WeightMax = table.Column<int>(type: "int", nullable: true),
                    Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Ant_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Ant_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Ant_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Hedgehog_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Hedgehog_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Hedgehog_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Snake_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Snake_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Snake_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Crab_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Crab_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Crab_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Cucumber_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Cucumber_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Cucumber_Extinct = table.Column<bool>(type: "bit", nullable: true),
                    Plankton_WeightMin = table.Column<int>(type: "int", nullable: true),
                    Plankton_WeightMax = table.Column<int>(type: "int", nullable: true),
                    Plankton_Extinct = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class AnimalsVisitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Visits_VisitId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_VisitId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Animals");

            migrationBuilder.CreateTable(
                name: "AnimalVisit",
                columns: table => new
                {
                    AnimalsID = table.Column<int>(type: "int", nullable: false),
                    visitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalVisit", x => new { x.AnimalsID, x.visitsId });
                    table.ForeignKey(
                        name: "FK_AnimalVisit_Animals_AnimalsID",
                        column: x => x.AnimalsID,
                        principalTable: "Animals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalVisit_Visits_visitsId",
                        column: x => x.visitsId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalVisit_visitsId",
                table: "AnimalVisit",
                column: "visitsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalVisit");

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_VisitId",
                table: "Animals",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Visits_VisitId",
                table: "Animals",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id");
        }
    }
}

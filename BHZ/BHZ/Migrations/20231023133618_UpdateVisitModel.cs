using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVisitModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

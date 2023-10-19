﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHZ.Migrations
{
    /// <inheritdoc />
    public partial class initialMig : Migration
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
                    SpecieDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecieWeightMin = table.Column<int>(type: "int", nullable: false),
                    SpecieWeightMax = table.Column<int>(type: "int", nullable: false),
                    Endangered = table.Column<bool>(type: "bit", nullable: false),
                    AirAnimalSpecie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HabitatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandAnimalSpecie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterAnimalSpecie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAltitude = table.Column<int>(type: "int", nullable: true),
                    Speed = table.Column<int>(type: "int", nullable: true),
                    MaxDepth = table.Column<int>(type: "int", nullable: true)
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
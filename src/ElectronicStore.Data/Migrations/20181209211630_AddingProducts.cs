using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicStore.Data.Migrations
{
    public partial class AddingProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirConditioners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    EnergyEfficiencyRating = table.Column<int>(nullable: false),
                    PowerConsumptionHeating = table.Column<double>(nullable: false),
                    PowerConsumptionCooling = table.Column<double>(nullable: false),
                    TemperatureAmplitude = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditioners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fridges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Dimensions = table.Column<string>(nullable: true),
                    EnergyEfficiencyRating = table.Column<int>(nullable: false),
                    Capacity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoCameras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PhotoType = table.Column<int>(nullable: false),
                    SensorDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoCameras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Smartphones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ScreenSize = table.Column<int>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    OS = table.Column<int>(nullable: false),
                    OSVersion = table.Column<double>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    InternalMemory = table.Column<int>(nullable: false),
                    MainCamera = table.Column<string>(nullable: true),
                    SecondaryCamera = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartphones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TVs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ScreenSize = table.Column<int>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    IsSmart = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WashingMachines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Dimensions = table.Column<string>(nullable: true),
                    EnergyEfficiencyRating = table.Column<int>(nullable: false),
                    Capacity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingMachines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirConditioners");

            migrationBuilder.DropTable(
                name: "Fridges");

            migrationBuilder.DropTable(
                name: "PhotoCameras");

            migrationBuilder.DropTable(
                name: "Smartphones");

            migrationBuilder.DropTable(
                name: "TVs");

            migrationBuilder.DropTable(
                name: "WashingMachines");
        }
    }
}

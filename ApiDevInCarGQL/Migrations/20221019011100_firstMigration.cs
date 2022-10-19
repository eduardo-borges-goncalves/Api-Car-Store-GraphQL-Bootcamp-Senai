using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDevInCarGQL.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Chassis = table.Column<int>(type: "int", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doors = table.Column<int>(type: "int", nullable: true),
                    Fuel = table.Column<int>(type: "int", nullable: true),
                    Wheels = table.Column<int>(type: "int", nullable: true),
                    BucketCapacity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Cpf", "Name" },
                values: new object[,]
                {
                    { 1, "01101101101", "Pedro" },
                    { 2, "01181101101", "Marcia" },
                    { 3, "01101901101", "Alfredo" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Available", "BucketCapacity", "Chassis", "Color", "Doors", "Fuel", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value", "VehicleType", "Wheels" },
                values: new object[,]
                {
                    { 1, false, null, 0, "Azul", 4, 1, "NKI9089", new DateTime(2022, 10, 18, 22, 11, 0, 136, DateTimeKind.Local).AddTicks(8171), "Punto", "260", 189.0, 1, null },
                    { 2, false, 200, 0, "Preto", 4, 2, "MJE9089", new DateTime(2022, 10, 18, 22, 11, 0, 138, DateTimeKind.Local).AddTicks(4030), "Amarok", "200", 400.0, 0, null },
                    { 3, false, null, 0, "Rosa", 4, 0, "KKO9089", new DateTime(2022, 10, 18, 22, 11, 0, 138, DateTimeKind.Local).AddTicks(4234), "Lancer", "456", 89.0, 1, null },
                    { 4, false, null, 0, "Vermelha", null, null, "Npl5589", new DateTime(2022, 10, 18, 22, 11, 0, 138, DateTimeKind.Local).AddTicks(3852), "twister", "2", 19.0, 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}

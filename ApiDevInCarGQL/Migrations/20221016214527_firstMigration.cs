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
                name: "Cars",
                columns: table => new
                {
                    Chassis = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doors = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Chassis);
                });

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
                name: "Moto",
                columns: table => new
                {
                    Chassis = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.Chassis);
                });

            migrationBuilder.CreateTable(
                name: "Vans",
                columns: table => new
                {
                    Chassis = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doors = table.Column<int>(type: "int", nullable: false),
                    BucketCapacity = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vans", x => x.Chassis);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Chassis", "Available", "Color", "Doors", "Fuel", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value" },
                values: new object[,]
                {
                    { 518802396, true, "Black", 4, 0, "JUU8989", new DateTime(2022, 10, 16, 18, 45, 25, 964, DateTimeKind.Local).AddTicks(2477), "Mercedez", "220", 389.0 },
                    { 1001238233, true, "Preto", 2, 1, "LIO9007", new DateTime(2022, 10, 16, 18, 45, 25, 964, DateTimeKind.Local).AddTicks(2376), "Ferrari", "380", 289.0 },
                    { 1528736604, true, "Azul", 4, 1, "NKI9089", new DateTime(2022, 10, 16, 18, 45, 25, 960, DateTimeKind.Local).AddTicks(6871), "Punto", "260", 189.0 }
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
                table: "Moto",
                columns: new[] { "Chassis", "Available", "Color", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value", "Wheels" },
                values: new object[,]
                {
                    { 203264637, true, "Preto", "FGH9089", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(2165), "CG 150", "1.5", 19.0, 2 },
                    { 677924677, true, "Azul", "NKI9089", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(1054), "Twister", "2", 18.0, 2 },
                    { 1791421939, true, "Vermelho", "ADB8989", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(2176), "Biz", "1.25", 14.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Vans",
                columns: new[] { "Chassis", "Available", "BucketCapacity", "Color", "Doors", "Fuel", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value" },
                values: new object[,]
                {
                    { 576584181, true, 400, "Azul", 4, 0, "POI9089", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(6131), "Amarok", "260", 389.0 },
                    { 873609422, true, 400, "Branco", 4, 0, "NOI9089", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(7626), "Hylux", "260", 489.0 },
                    { 1297277583, true, 400, "Vermelho", 4, 0, "POI9089", new DateTime(2022, 10, 16, 18, 45, 25, 966, DateTimeKind.Local).AddTicks(7636), "S-10", "260", 289.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "Vans");
        }
    }
}

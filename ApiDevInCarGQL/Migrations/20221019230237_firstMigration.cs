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
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    IdTransaction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdVehicle = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.IdTransaction);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    IdVehicle = table.Column<int>(type: "int", nullable: false)
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
                    BucketCapacity = table.Column<int>(type: "int", nullable: true),
                    IdTransaction = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.IdVehicle);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "IdCustomer", "Cpf", "Name" },
                values: new object[,]
                {
                    { 1, "01101101101", "Pedro" },
                    { 2, "01181101101", "Marcia" },
                    { 3, "01101901101", "Alfredo" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "IdVehicle", "Available", "BucketCapacity", "Chassis", "Color", "Doors", "Fuel", "IdTransaction", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value", "VehicleType", "Wheels" },
                values: new object[,]
                {
                    { 1, true, null, 0, "Azul", 4, 1, null, "NKI9089", new DateTime(2022, 10, 19, 20, 2, 37, 253, DateTimeKind.Local).AddTicks(265), "Punto", "260", 189.0, 1, null },
                    { 2, true, null, 0, "Vermelha", null, null, null, "Npl5589", new DateTime(2022, 10, 19, 20, 2, 37, 254, DateTimeKind.Local).AddTicks(3655), "twister", "2", 19.0, 2, 2 },
                    { 3, true, 200, 0, "Preto", 4, 2, null, "MJE9089", new DateTime(2022, 10, 19, 20, 2, 37, 254, DateTimeKind.Local).AddTicks(3868), "Amarok", "200", 400.0, 0, null },
                    { 4, true, null, 0, "Rosa", 4, 0, null, "KKO9089", new DateTime(2022, 10, 19, 20, 2, 37, 254, DateTimeKind.Local).AddTicks(4026), "Lancer", "456", 89.0, 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}

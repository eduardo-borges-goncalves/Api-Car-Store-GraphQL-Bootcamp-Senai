using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDevInCarGQL.Migrations
{
    public partial class firstKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IdCustomer = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cpf);
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

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    IdTransaction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustomer = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    IdVehicle = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.IdTransaction);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Vehicles_IdVehicle",
                        column: x => x.IdVehicle,
                        principalTable: "Vehicles",
                        principalColumn: "IdVehicle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Cpf", "IdCustomer", "Name" },
                values: new object[,]
                {
                    { "01101101101", 1, "Pedro" },
                    { "01101901101", 3, "Alfredo" },
                    { "01181101101", 2, "Marcia" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "IdVehicle", "Available", "BucketCapacity", "Chassis", "Color", "Doors", "Fuel", "IdTransaction", "LicensePlate", "ManufacturingDate", "Name", "Power", "Value", "VehicleType", "Wheels" },
                values: new object[,]
                {
                    { 1, true, null, 0, "Azul", 4, 1, null, "NKI9089", new DateTime(2022, 10, 20, 21, 56, 44, 476, DateTimeKind.Local).AddTicks(5316), "Punto", "260", 189.0, 1, null },
                    { 2, true, null, 0, "Vermelha", null, null, null, "Npl5589", new DateTime(2022, 10, 20, 21, 56, 44, 479, DateTimeKind.Local).AddTicks(4154), "twister", "2", 19.0, 2, 2 },
                    { 3, true, 200, 0, "Preto", 4, 2, null, "MJE9089", new DateTime(2022, 10, 20, 21, 56, 44, 479, DateTimeKind.Local).AddTicks(4503), "Amarok", "200", 400.0, 0, null },
                    { 4, true, null, 0, "Rosa", 4, 0, null, "KKO9089", new DateTime(2022, 10, 20, 21, 56, 44, 479, DateTimeKind.Local).AddTicks(4792), "Lancer", "456", 89.0, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdCustomer",
                table: "Transactions",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdVehicle",
                table: "Transactions",
                column: "IdVehicle",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordsSystem.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecUserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentityNumber = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecUserDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressesDetails",
                columns: table => new
                {
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecUserDetailId = table.Column<int>(type: "int", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Suburb = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UnitNumber = table.Column<int>(type: "int", nullable: false),
                    ComplexName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressesDetails", x => x.Country);
                    table.ForeignKey(
                        name: "FK_AddressesDetails_RecUserDetails_RecUserDetailId",
                        column: x => x.RecUserDetailId,
                        principalTable: "RecUserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecUserDetailId = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<long>(type: "bigint", maxLength: 100, nullable: false),
                    RegistrationNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.EmailAddress);
                    table.ForeignKey(
                        name: "FK_CompanyDetails_RecUserDetails_RecUserDetailId",
                        column: x => x.RecUserDetailId,
                        principalTable: "RecUserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecUserDetailId = table.Column<int>(type: "int", nullable: false),
                    EmpRole = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.Department);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_RecUserDetails_RecUserDetailId",
                        column: x => x.RecUserDetailId,
                        principalTable: "RecUserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressesDetails_RecUserDetailId",
                table: "AddressesDetails",
                column: "RecUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_RecUserDetailId",
                table: "CompanyDetails",
                column: "RecUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_RecUserDetailId",
                table: "EmployeeDetails",
                column: "RecUserDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressesDetails");

            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "RecUserDetails");
        }
    }
}

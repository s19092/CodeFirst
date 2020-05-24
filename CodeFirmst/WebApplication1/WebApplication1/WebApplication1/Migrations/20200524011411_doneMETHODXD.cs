using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class doneMETHODXD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "XDASD", " jADWQd", "PLOX" },
                    { 2, "XDAS12121212121212D", " jADWQDQ2QWR13131313d", "PLO121212121212X" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Discriminator", "FirstName", "LastName", "Birthdate" },
                values: new object[,]
                {
                    { 1, "Client", "Jan", "Kowalski", new DateTime(2020, 5, 24, 3, 14, 11, 215, DateTimeKind.Local).AddTicks(4994) },
                    { 2, "Client", "dzban", "walski", new DateTime(2020, 5, 24, 3, 14, 11, 218, DateTimeKind.Local).AddTicks(8058) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Discriminator", "FirstName", "LastName", "Email" },
                values: new object[,]
                {
                    { 3, "Doctor", "qram", "wqas", "małpa@@.com" },
                    { 4, "Doctor", "qrqweeqw", "wqaasdsadadss", "małpfqfwqwfwqfqfw@fqfwq.con" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

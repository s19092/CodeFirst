using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class RelatrionsForPrescriptions3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_People_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Prescriptions");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_People_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_People_IdDoctor",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_IdDoctor",
                table: "Prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_People_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

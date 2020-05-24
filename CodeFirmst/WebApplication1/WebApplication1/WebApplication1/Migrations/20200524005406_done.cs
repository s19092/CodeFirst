using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescrition_Medicament",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedicament = table.Column<int>(nullable: true),
                    IdPrescrtiption = table.Column<int>(nullable: true),
                    Dose = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescrition_Medicament", x => x.id);
                    table.ForeignKey(
                        name: "FK_Prescrition_Medicament_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescrition_Medicament_Prescriptions_IdPrescrtiption",
                        column: x => x.IdPrescrtiption,
                        principalTable: "Prescriptions",
                        principalColumn: "IdPrescrition",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescrition_Medicament_IdMedicament",
                table: "Prescrition_Medicament",
                column: "IdMedicament");

            migrationBuilder.CreateIndex(
                name: "IX_Prescrition_Medicament_IdPrescrtiption",
                table: "Prescrition_Medicament",
                column: "IdPrescrtiption");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescrition_Medicament");
        }
    }
}

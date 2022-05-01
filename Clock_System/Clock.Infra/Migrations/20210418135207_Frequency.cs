using Microsoft.EntityFrameworkCore.Migrations;

namespace Clock.Infra.Migrations
{
    public partial class Frequency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "FrequencyFK",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Frequency",
                columns: table => new
                {
                    IdFrequency = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequency", x => x.IdFrequency);
                });

            migrationBuilder.InsertData(
                table: "Frequency",
                columns: new[] { "IdFrequency", "Description" },
                values: new object[,]
                {
                    { 1, "Weekly" },
                    { 2, "Fortnightly" },
                    { 3, "Monthly" },
                    { 4, "One Off" },
                    { 5, "Exit Clean" },
                    { 9999, "Not Informed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_FrequencyFK",
                table: "Client",
                column: "FrequencyFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Frequency_FrequencyFK",
                table: "Client",
                column: "FrequencyFK",
                principalTable: "Frequency",
                principalColumn: "IdFrequency",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Frequency_FrequencyFK",
                table: "Client");

            migrationBuilder.DropTable(
                name: "Frequency");

            migrationBuilder.DropIndex(
                name: "IX_Client_FrequencyFK",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FrequencyFK",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "Frequency",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

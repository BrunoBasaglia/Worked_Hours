using Microsoft.EntityFrameworkCore.Migrations;

namespace Clock.Infra.Migrations
{
    public partial class changingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonFk",
                table: "Hours",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonIdPerson",
                table: "Hours",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hours_PersonIdPerson",
                table: "Hours",
                column: "PersonIdPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_Hours_Person_PersonIdPerson",
                table: "Hours",
                column: "PersonIdPerson",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hours_Person_PersonIdPerson",
                table: "Hours");

            migrationBuilder.DropIndex(
                name: "IX_Hours_PersonIdPerson",
                table: "Hours");

            migrationBuilder.DropColumn(
                name: "PersonFk",
                table: "Hours");

            migrationBuilder.DropColumn(
                name: "PersonIdPerson",
                table: "Hours");
        }
    }
}

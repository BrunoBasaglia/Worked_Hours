using Microsoft.EntityFrameworkCore.Migrations;

namespace Clock.Infra.Migrations
{
    public partial class changingDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hours_Person_PersonIdPerson",
                table: "Hours");

            migrationBuilder.DropIndex(
                name: "IX_Hours_PersonIdPerson",
                table: "Hours");

            migrationBuilder.DropColumn(
                name: "PersonIdPerson",
                table: "Hours");

            migrationBuilder.AlterColumn<string>(
                name: "PersonFk",
                table: "Hours",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hours_PersonFk",
                table: "Hours",
                column: "PersonFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Hours_Person_PersonFk",
                table: "Hours",
                column: "PersonFk",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hours_Person_PersonFk",
                table: "Hours");

            migrationBuilder.DropIndex(
                name: "IX_Hours_PersonFk",
                table: "Hours");

            migrationBuilder.AlterColumn<string>(
                name: "PersonFk",
                table: "Hours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonIdPerson",
                table: "Hours",
                type: "nvarchar(450)",
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
    }
}

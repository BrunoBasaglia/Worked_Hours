using Microsoft.EntityFrameworkCore.Migrations;

namespace Clock.Infra.Migrations
{
    public partial class new_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Wages",
                table: "Person",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wages",
                table: "Person");
        }
    }
}

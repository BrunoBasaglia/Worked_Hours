using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clock.Infra.Migrations
{
    public partial class createDatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    IdState = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.IdState);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    IdCity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StateFk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.IdCity);
                    table.ForeignKey(
                        name: "FK_City_State_StateFk",
                        column: x => x.StateFk,
                        principalTable: "State",
                        principalColumn: "IdState",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    IdEmployer = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    ABN = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    CityFk = table.Column<int>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    PayDay = table.Column<string>(nullable: true),
                    PaymentFrequency = table.Column<string>(nullable: true),
                    PayBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.IdEmployer);
                    table.ForeignKey(
                        name: "FK_Employer_City_CityFk",
                        column: x => x.CityFk,
                        principalTable: "City",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    IdPerson = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Telephone = table.Column<string>(nullable: true),
                    ABN = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    CityFk = table.Column<int>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Person_City_CityFk",
                        column: x => x.CityFk,
                        principalTable: "City",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    IdHour = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateTime>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    Finish = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EmployerFk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.IdHour);
                    table.ForeignKey(
                        name: "FK_Hours_Employer_EmployerFk",
                        column: x => x.EmployerFk,
                        principalTable: "Employer",
                        principalColumn: "IdEmployer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonEmployer",
                columns: table => new
                {
                    IdPerson = table.Column<string>(nullable: false),
                    IdEmployer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEmployer", x => new { x.IdPerson, x.IdEmployer });
                    table.ForeignKey(
                        name: "FK_PersonEmployer_Employer_IdEmployer",
                        column: x => x.IdEmployer,
                        principalTable: "Employer",
                        principalColumn: "IdEmployer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonEmployer_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "IdState", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "SA", "South Australia" },
                    { 2, "NSW", "New South Wales" },
                    { 3, "QLD", "Queensland" },
                    { 4, "NT", "Northern Territory" },
                    { 5, "VIC", "Victoria" },
                    { 6, "TAS", "Tasmania" },
                    { 7, "ACT", "Australia Capital Territory" },
                    { 8, "WA", "Western Australia" },
                    { 9999, "N/A", "Not Informed" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "IdCity", "Name", "StateFk" },
                values: new object[,]
                {
                    { 1, "Adelaide", 1 },
                    { 32, "Gold Coast-Tweed Heads", 3 },
                    { 37, "Darwin", 4 },
                    { 38, "Melbourne", 5 },
                    { 39, "Geelong", 5 },
                    { 40, "Ballarat", 5 },
                    { 41, "Bendigo", 5 },
                    { 42, "La Trobe Valley", 5 },
                    { 43, "Mildura", 5 },
                    { 31, "Gladstone	", 3 },
                    { 44, "Shepparton", 5 },
                    { 33, "Hobart", 6 },
                    { 34, "Launceston", 6 },
                    { 35, "Burnie-Devonport", 6 },
                    { 36, "Camberra-Queanbeyan", 7 },
                    { 2, "Perth", 8 },
                    { 3, "Mandurah", 8 },
                    { 4, "Bunbury", 8 },
                    { 5, "Geraldton", 8 },
                    { 45, "Warrnambool", 5 },
                    { 30, "Hervey Bay", 3 },
                    { 27, "Bundaberg", 3 },
                    { 26, "Rockhampton", 3 },
                    { 7, "Sydney", 2 },
                    { 8, "Newcastle", 2 },
                    { 9, "Wollongong", 2 },
                    { 10, "Wagga Wagga", 2 },
                    { 11, "Coffs Harbour", 2 },
                    { 12, "Tamworth", 2 },
                    { 13, "Port Macquarie", 2 },
                    { 14, "Orange", 2 },
                    { 15, "Dubbo", 2 },
                    { 16, "Nowra-Bomaderry", 2 },
                    { 17, "Bathurst", 2 },
                    { 18, "Lismore", 2 },
                    { 19, "Albury-Wodonga", 2 },
                    { 20, "Brisbane", 3 },
                    { 21, "Sunshine Coast", 3 },
                    { 22, "Townsville", 3 },
                    { 23, "Cairns", 3 },
                    { 24, "Toowoomba", 3 },
                    { 25, "Mackay", 3 },
                    { 6, "Kalgoorlie-Boulder", 8 },
                    { 9999, "Not Informed", 9999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_StateFk",
                table: "City",
                column: "StateFk");

            migrationBuilder.CreateIndex(
                name: "IX_Employer_CityFk",
                table: "Employer",
                column: "CityFk");

            migrationBuilder.CreateIndex(
                name: "IX_Hours_EmployerFk",
                table: "Hours",
                column: "EmployerFk");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CityFk",
                table: "Person",
                column: "CityFk");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEmployer_IdEmployer",
                table: "PersonEmployer",
                column: "IdEmployer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "PersonEmployer");

            migrationBuilder.DropTable(
                name: "Employer");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}

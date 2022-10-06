using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLite.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Number = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 6, nullable: true),
                    Nameset = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 6, nullable: true),
                    Givenname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Middleinitial = table.Column<string>(type: "TEXT", maxLength: 1, nullable: true),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 23, nullable: true),
                    Streetaddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "TEXT", maxLength: 22, nullable: true),
                    Statefull = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Zipcode = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    Countryfull = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Emailaddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Password = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Browseruseragent = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Telephonenumber = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Telephonecountrycode = table.Column<int>(type: "INTEGER", nullable: false),
                    Maidenname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Birthday = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Tropicalzodiac = table.Column<string>(type: "TEXT", maxLength: 11, nullable: true),
                    Cctype = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Ccnumber = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    Cvv2 = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    Ccexpires = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Nationalid = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Upstracking = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true),
                    Westernunionmtcn = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Moneygrammtcn = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true),
                    Color = table.Column<string>(type: "TEXT", maxLength: 6, nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", maxLength: 70, nullable: true),
                    Company = table.Column<string>(type: "TEXT", maxLength: 70, nullable: true),
                    Vehicle = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Domain = table.Column<string>(type: "TEXT", maxLength: 70, nullable: true),
                    Bloodtype = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    Pounds = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Kilograms = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Feetinches = table.Column<string>(type: "TEXT", maxLength: 6, nullable: true),
                    Centimeters = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    Guid = table.Column<string>(type: "TEXT", maxLength: 36, nullable: true),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

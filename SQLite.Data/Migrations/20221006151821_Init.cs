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
                    Gender = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Nameset = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Givenname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Middleinitial = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 23, nullable: false),
                    Streetaddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 22, nullable: false),
                    Statefull = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Zipcode = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Countryfull = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Emailaddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Browseruseragent = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Telephonenumber = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Telephonecountrycode = table.Column<int>(type: "INTEGER", nullable: false),
                    Maidenname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Birthday = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Tropicalzodiac = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Cctype = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Ccnumber = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    Cvv2 = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    Ccexpires = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Nationalid = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Upstracking = table.Column<string>(type: "TEXT", maxLength: 24, nullable: false),
                    Westernunionmtcn = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Moneygrammtcn = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Color = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Occupation = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    Company = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    Vehicle = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Domain = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    Bloodtype = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    Pounds = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Kilograms = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Feetinches = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Centimeters = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    Guid = table.Column<string>(type: "TEXT", maxLength: 36, nullable: false),
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

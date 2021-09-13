using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class SeedModelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Germany", "DE" },
                    { 2, "Bulgaria", "BG" },
                    { 3, "Denmark", "DK" },
                    { 4, "Czechia", "CZ" },
                    { 5, "Belgium", "BE" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 2, "4, Onitolo Road, Off Gerrard Road", 1, "Wheatbaker", 3.7000000000000002 },
                    { 1, "30, Mobolaji Bank Anthony Way, Airport Road, Ikeja GRA", 2, "Sheraton", 4.5 },
                    { 4, "5141, Aba Road, GRA Phase 2, Rumuadaolu", 2, "Hotel Presidential", 4.0999999999999996 },
                    { 5, "10, Bisala Road, Independence Layout", 3, "Golden Royale", 3.5 },
                    { 3, "30, Mobolaji Bank Anthony Way, Airport Road, Ikeja GRA", 5, "Transcorp Hilton", 4.6500000000000004 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

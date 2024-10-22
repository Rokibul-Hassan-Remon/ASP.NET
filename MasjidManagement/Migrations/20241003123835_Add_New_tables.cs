using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasjidManagement.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSubscribe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonorGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonorCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonorBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonorAge = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonorFavColor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImamId = table.Column<int>(type: "int", nullable: false),
                    ImamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamJoinDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnDuty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamBirthTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImamAge = table.Column<int>(type: "int", nullable: false),
                    ImamFavColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalatTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrayerStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrayerEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalatTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerBirthTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerAge = table.Column<int>(type: "int", nullable: false),
                    VolunteerFavColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Imams");

            migrationBuilder.DropTable(
                name: "SalatTime");

            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameliorated_Communications.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Callees",
                columns: table => new
                {
                    CalleeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phoneNumber = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    zipCode = table.Column<int>(nullable: false),
                    callCount = table.Column<int>(nullable: false),
                    answerCount = table.Column<int>(nullable: false),
                    gift = table.Column<int>(nullable: false),
                    giftDate = table.Column<string>(nullable: true),
                    lastCallDate = table.Column<DateTime>(nullable: true),
                    lastCallTime = table.Column<DateTime>(nullable: true),
                    nextCallDate = table.Column<DateTime>(nullable: true),
                    nextCallTime = table.Column<DateTime>(nullable: true),
                    hasResponse = table.Column<bool>(nullable: false),
                    calleeDemeanor = table.Column<string>(nullable: true),
                    isInterested = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Callees", x => x.CalleeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Callees");
        }
    }
}

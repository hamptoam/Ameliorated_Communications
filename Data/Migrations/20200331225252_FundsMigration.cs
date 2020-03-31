using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameliorated_Communications.Data.Migrations
{
    public partial class FundsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fund",
                columns: table => new
                {
                    FundId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyFunds = table.Column<double>(nullable: false),
                    WeeklyFunds = table.Column<double>(nullable: false),
                    MonthlyFunds = table.Column<double>(nullable: false),
                    QuarterlyFunds = table.Column<double>(nullable: false),
                    YearlyFunds = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fund", x => x.FundId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fund");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameliorated_Communications.Data.Migrations
{
    public partial class EmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Campaigns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Callees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    CampaignId = table.Column<int>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CalleeId = table.Column<int>(nullable: true),
                    outgoingText = table.Column<string>(nullable: true),
                    DailyCalls = table.Column<int>(nullable: false),
                    QuantityGifts = table.Column<int>(nullable: false),
                    WeeklyCalls = table.Column<int>(nullable: false),
                    WeeklyQuantityGifts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Callees_CalleeId",
                        column: x => x.CalleeId,
                        principalTable: "Callees",
                        principalColumn: "CalleeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_EmployeeId",
                table: "Campaigns",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Callees_EmployeeId",
                table: "Callees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CalleeId",
                table: "Employee",
                column: "CalleeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CampaignId",
                table: "Employee",
                column: "CampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Callees_Employee_EmployeeId",
                table: "Callees",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Employee_EmployeeId",
                table: "Campaigns",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Callees_Employee_EmployeeId",
                table: "Callees");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Employee_EmployeeId",
                table: "Campaigns");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_EmployeeId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Callees_EmployeeId",
                table: "Callees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Callees");
        }
    }
}

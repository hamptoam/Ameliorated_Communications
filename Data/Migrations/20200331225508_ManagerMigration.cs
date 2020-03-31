using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameliorated_Communications.Data.Migrations
{
    public partial class ManagerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Campaigns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Callees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ManagerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ManagerId",
                table: "Employee",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ManagerId",
                table: "Campaigns",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Callees_ManagerId",
                table: "Callees",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Callees_Manager_ManagerId",
                table: "Callees",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Manager_ManagerId",
                table: "Campaigns",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Manager_ManagerId",
                table: "Employee",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Callees_Manager_ManagerId",
                table: "Callees");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Manager_ManagerId",
                table: "Campaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Manager_ManagerId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ManagerId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_ManagerId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Callees_ManagerId",
                table: "Callees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Callees");
        }
    }
}

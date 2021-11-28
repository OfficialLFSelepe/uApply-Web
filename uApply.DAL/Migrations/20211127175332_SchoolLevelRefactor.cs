using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class SchoolLevelRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolLevelId",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolLevelId",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LearnerId",
                table: "Application",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SchoolLevelId",
                table: "Schools",
                column: "SchoolLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_LearnerId",
                table: "Application",
                column: "LearnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Learners_LearnerId",
                table: "Application",
                column: "LearnerId",
                principalTable: "Learners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_SchoolLevels_SchoolLevelId",
                table: "Schools",
                column: "SchoolLevelId",
                principalTable: "SchoolLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Learners_LearnerId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_SchoolLevels_SchoolLevelId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_SchoolLevelId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Application_LearnerId",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "SchoolLevelId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolLevelId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "LearnerId",
                table: "Application");
        }
    }
}

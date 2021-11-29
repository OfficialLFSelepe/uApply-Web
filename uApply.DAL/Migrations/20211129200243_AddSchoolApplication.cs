using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddSchoolApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Learners_LearnerId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Application",
                table: "Application");

            migrationBuilder.RenameTable(
                name: "Application",
                newName: "Applications");

            migrationBuilder.RenameIndex(
                name: "IX_Application_SchoolId",
                table: "Applications",
                newName: "IX_Applications_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_LearnerId",
                table: "Applications",
                newName: "IX_Applications_LearnerId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                table: "Applications",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Created", "GradeId", "LearnerId", "SchoolId", "Status" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 11, 29, 22, 2, 43, 90, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 1, "Not Yet Attended" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_GradeId",
                table: "Applications",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Grades_GradeId",
                table: "Applications",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Learners_LearnerId",
                table: "Applications",
                column: "LearnerId",
                principalTable: "Learners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Schools_SchoolId",
                table: "Applications",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Grades_GradeId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Learners_LearnerId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Schools_SchoolId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_GradeId",
                table: "Applications");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "Application");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_SchoolId",
                table: "Application",
                newName: "IX_Application_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_LearnerId",
                table: "Application",
                newName: "IX_Application_LearnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Application",
                table: "Application",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Learners_LearnerId",
                table: "Application",
                column: "LearnerId",
                principalTable: "Learners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

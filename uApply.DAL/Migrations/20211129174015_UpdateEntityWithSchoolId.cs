using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class UpdateEntityWithSchoolId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SchoolLevels",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Primary School" });

            migrationBuilder.InsertData(
                table: "SchoolLevels",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "High School" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolLevelId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "SchoolLevelId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolLevelId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "SchoolLevelId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "SchoolLevelId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SchoolLevelId",
                table: "Grades",
                column: "SchoolLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_SchoolLevels_SchoolLevelId",
                table: "Grades",
                column: "SchoolLevelId",
                principalTable: "SchoolLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_SchoolLevels_SchoolLevelId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_SchoolLevelId",
                table: "Grades");

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolLevelId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "SchoolLevelId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolLevelId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "SchoolLevelId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "SchoolLevelId",
                value: 0);
        }
    }
}

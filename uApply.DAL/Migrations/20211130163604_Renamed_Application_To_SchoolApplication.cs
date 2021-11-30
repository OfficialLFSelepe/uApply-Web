using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class Renamed_Application_To_SchoolApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.CreateTable(
                name: "SchoolApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    LearnerId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolApplications_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolApplications_Learners_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolApplications_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SchoolApplications",
                columns: new[] { "Id", "Created", "GradeId", "LearnerId", "SchoolId", "Status" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 11, 30, 18, 36, 3, 308, DateTimeKind.Unspecified).AddTicks(948), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 1, "Not Yet Attended" });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolApplications_GradeId",
                table: "SchoolApplications",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolApplications_LearnerId",
                table: "SchoolApplications",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolApplications_SchoolId",
                table: "SchoolApplications",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolApplications");

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    LearnerId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Learners_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Created", "GradeId", "LearnerId", "SchoolId", "Status" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 11, 29, 22, 2, 43, 90, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 1, "Not Yet Attended" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_GradeId",
                table: "Applications",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LearnerId",
                table: "Applications",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_SchoolId",
                table: "Applications",
                column: "SchoolId");
        }
    }
}

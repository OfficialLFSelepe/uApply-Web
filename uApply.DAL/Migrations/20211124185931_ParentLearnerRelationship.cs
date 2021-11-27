using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class ParentLearnerRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Genders_GenderId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Grades_GradeId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Languages_LanguageId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Nationalities_NationalityId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Races_RaceId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Titles_TitleId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Towns_TownId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Genders_GenderId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Languages_LanguageId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Nationalities_NationalityId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Races_RaceId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Titles_TitleId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Towns_TownId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Towns_TownId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Districts_DistrictId",
                table: "Towns");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Learners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Learners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParentId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Learners_ParentId",
                table: "Learners",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Genders_GenderId",
                table: "Learners",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Grades_GradeId",
                table: "Learners",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Languages_LanguageId",
                table: "Learners",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Nationalities_NationalityId",
                table: "Learners",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Parents_ParentId",
                table: "Learners",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Races_RaceId",
                table: "Learners",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Titles_TitleId",
                table: "Learners",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Towns_TownId",
                table: "Learners",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Genders_GenderId",
                table: "Parents",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Languages_LanguageId",
                table: "Parents",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Nationalities_NationalityId",
                table: "Parents",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Races_RaceId",
                table: "Parents",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Titles_TitleId",
                table: "Parents",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Towns_TownId",
                table: "Parents",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Towns_TownId",
                table: "Schools",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Districts_DistrictId",
                table: "Towns",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Genders_GenderId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Grades_GradeId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Languages_LanguageId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Nationalities_NationalityId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Parents_ParentId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Races_RaceId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Titles_TitleId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Towns_TownId",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Genders_GenderId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Languages_LanguageId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Nationalities_NationalityId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Races_RaceId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Titles_TitleId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Towns_TownId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Towns_TownId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Districts_DistrictId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Learners_ParentId",
                table: "Learners");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Learners");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Schools_SchoolId",
                table: "Application",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Genders_GenderId",
                table: "Learners",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Grades_GradeId",
                table: "Learners",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Languages_LanguageId",
                table: "Learners",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Nationalities_NationalityId",
                table: "Learners",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Races_RaceId",
                table: "Learners",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Titles_TitleId",
                table: "Learners",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Towns_TownId",
                table: "Learners",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Genders_GenderId",
                table: "Parents",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Languages_LanguageId",
                table: "Parents",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Nationalities_NationalityId",
                table: "Parents",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Races_RaceId",
                table: "Parents",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Titles_TitleId",
                table: "Parents",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Towns_TownId",
                table: "Parents",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Towns_TownId",
                table: "Schools",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Districts_DistrictId",
                table: "Towns",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

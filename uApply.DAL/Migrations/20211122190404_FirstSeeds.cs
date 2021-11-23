using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class FirstSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Learners_Parents_ParentId",
                table: "Learners");

            migrationBuilder.DropIndex(
                name: "IX_Learners_ParentId",
                table: "Learners");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Learners");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Titles",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderType" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "8" },
                    { 2, "9" },
                    { 3, "10" },
                    { 4, "11" },
                    { 5, "12" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Sesotho" },
                    { 3, "isiXhosa" }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Other" },
                    { 1, "South Africa" }
                });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "White" },
                    { 1, "African" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Miss" },
                    { 1, "Mr" },
                    { 4, "Dr" },
                    { 3, "Mrs" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[,]
                {
                    { 5, 3, "Frankfort" },
                    { 4, 2, "betlehem" },
                    { 3, 2, "phuthaditjhaba" },
                    { 1, 1, "Bloem" },
                    { 6, 3, "Ficksburg" },
                    { 2, 1, "Botshabelo" }
                });

            migrationBuilder.InsertData(
                table: "Learners",
                columns: new[] { "Id", "Email", "FullNames", "GenderId", "GradeId", "IdNumber", "IsDisabled", "LanguageId", "NationalityId", "Password", "PhoneNumber", "PostalCode", "RaceId", "StreetAddress", "Surburb", "Surname", "TitleId", "TownId", "Username" },
                values: new object[] { 1, "maxvitsha@gmail.com", "Sne Maxwell", 1, 1, 9802356508984L, false, 2, 1, "@Sijo4C#", "0645698789", 611, 1, "10360 Poulos Village", "Bakenberg", "Selepe", 1, 1, null });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Email", "FullNames", "GenderId", "IdNumber", "LanguageId", "NationalityId", "Password", "PhoneNumber", "PostalCode", "RaceId", "StreetAddress", "Surburb", "Surname", "TitleId", "TownId", "Username" },
                values: new object[] { 1, "lesetjaofficial26@gmail.com", "lesetja Frans", 1, 3265453088L, 2, 1, "@Sijo4C#", "0636517935", 611, 1, "10360 Poulos Village", "Bakenberg", "Selepe", 1, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Learners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Titles",
                newName: "Gender");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Learners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Learners_ParentId",
                table: "Learners",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_Parents_ParentId",
                table: "Learners",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

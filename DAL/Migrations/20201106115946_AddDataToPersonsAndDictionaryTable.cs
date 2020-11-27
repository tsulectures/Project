using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddDataToPersonsAndDictionaryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Dictionaries",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Dictionaries",
                columns: new[] { "Id", "HasGender", "HasPhoneType", "HasPosition", "Title" },
                values: new object[,]
                {
                    { 1, false, false, true, "Manager" },
                    { 2, false, false, true, "CEO" },
                    { 3, false, false, true, "CTO" },
                    { 4, false, false, true, "Web Developer" },
                    { 5, true, false, false, "Male" },
                    { 6, true, false, false, "Female" },
                    { 7, false, true, false, "Home" },
                    { 8, false, true, false, "Work" },
                    { 9, false, true, false, "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Email", "Firstname", "GenderId", "Lastname", "PositionId" },
                values: new object[] { 1, new DateTime(1996, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@tes.com", "Person1", 5, "PersonLastName1", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Dictionaries",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

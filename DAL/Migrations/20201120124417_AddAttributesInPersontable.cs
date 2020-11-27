using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddAttributesInPersontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalNumber",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalNumber",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "People");
        }
    }
}

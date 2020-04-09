using Microsoft.EntityFrameworkCore.Migrations;

namespace ARMS.DataAccess.Migrations
{
    public partial class AddColumnFullNameToStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fullname",
                table: "Students",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullname",
                table: "Students");
        }
    }
}

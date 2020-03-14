using Microsoft.EntityFrameworkCore.Migrations;

namespace ARMS.DataAccess.Migrations
{
    public partial class ModifyRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_NextOfKin_NextOfKinId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Students_StudentId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_NextOfKin_NextOfKinId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Students_StudentId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKin_Students_StudentId",
                table: "NextOfKin");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_NextOfKin_NextOfKinId",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Students_StudentId",
                table: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "PhoneNumber",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "NextOfKinId",
                table: "PhoneNumber",
                newName: "next_of_kin_id");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_StudentId",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_NextOfKinId",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_next_of_kin_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "NextOfKin",
                newName: "student_id");

            migrationBuilder.RenameIndex(
                name: "IX_NextOfKin_StudentId",
                table: "NextOfKin",
                newName: "IX_NextOfKin_student_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Email",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "NextOfKinId",
                table: "Email",
                newName: "next_of_kin_id");

            migrationBuilder.RenameIndex(
                name: "IX_Email_StudentId",
                table: "Email",
                newName: "IX_Email_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Email_NextOfKinId",
                table: "Email",
                newName: "IX_Email_next_of_kin_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Address",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "NextOfKinId",
                table: "Address",
                newName: "next_of_kin_id");

            migrationBuilder.RenameIndex(
                name: "IX_Address_StudentId",
                table: "Address",
                newName: "IX_Address_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Address_NextOfKinId",
                table: "Address",
                newName: "IX_Address_next_of_kin_id");

            migrationBuilder.AlterColumn<int>(
                name: "next_of_kin_id",
                table: "PhoneNumber",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "next_of_kin_id",
                table: "Email",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "next_of_kin_id",
                table: "Address",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_NextOfKin_next_of_kin_id",
                table: "Address",
                column: "next_of_kin_id",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Students_student_id",
                table: "Address",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_NextOfKin_next_of_kin_id",
                table: "Email",
                column: "next_of_kin_id",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Students_student_id",
                table: "Email",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKin_Students_student_id",
                table: "NextOfKin",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_NextOfKin_next_of_kin_id",
                table: "PhoneNumber",
                column: "next_of_kin_id",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Students_student_id",
                table: "PhoneNumber",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_NextOfKin_next_of_kin_id",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Students_student_id",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_NextOfKin_next_of_kin_id",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Students_student_id",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKin_Students_student_id",
                table: "NextOfKin");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_NextOfKin_next_of_kin_id",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Students_student_id",
                table: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "PhoneNumber",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "next_of_kin_id",
                table: "PhoneNumber",
                newName: "NextOfKinId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_student_id",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_next_of_kin_id",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_NextOfKinId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "NextOfKin",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_NextOfKin_student_id",
                table: "NextOfKin",
                newName: "IX_NextOfKin_StudentId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Email",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "next_of_kin_id",
                table: "Email",
                newName: "NextOfKinId");

            migrationBuilder.RenameIndex(
                name: "IX_Email_student_id",
                table: "Email",
                newName: "IX_Email_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Email_next_of_kin_id",
                table: "Email",
                newName: "IX_Email_NextOfKinId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Address",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "next_of_kin_id",
                table: "Address",
                newName: "NextOfKinId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_student_id",
                table: "Address",
                newName: "IX_Address_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_next_of_kin_id",
                table: "Address",
                newName: "IX_Address_NextOfKinId");

            migrationBuilder.AlterColumn<int>(
                name: "NextOfKinId",
                table: "PhoneNumber",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NextOfKinId",
                table: "Email",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NextOfKinId",
                table: "Address",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Address_NextOfKin_NextOfKinId",
                table: "Address",
                column: "NextOfKinId",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Students_StudentId",
                table: "Address",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_NextOfKin_NextOfKinId",
                table: "Email",
                column: "NextOfKinId",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Students_StudentId",
                table: "Email",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKin_Students_StudentId",
                table: "NextOfKin",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_NextOfKin_NextOfKinId",
                table: "PhoneNumber",
                column: "NextOfKinId",
                principalTable: "NextOfKin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Students_StudentId",
                table: "PhoneNumber",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

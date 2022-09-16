using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMVC.Migrations
{
    public partial class manytoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SubjectID",
                table: "Teachers",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Subjects_SubjectID",
                table: "Teachers",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Subjects_SubjectID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SubjectID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "Teachers");

            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    SubjectsSubjectID = table.Column<int>(type: "int", nullable: false),
                    TeachersTeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectsSubjectID, x.TeachersTeacherID });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Subjects_SubjectsSubjectID",
                        column: x => x.SubjectsSubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Teachers_TeachersTeacherID",
                        column: x => x.TeachersTeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeachersTeacherID",
                table: "SubjectTeacher",
                column: "TeachersTeacherID");
        }
    }
}

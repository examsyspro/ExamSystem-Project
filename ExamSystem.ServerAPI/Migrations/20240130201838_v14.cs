using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamSystem.ServerAPI.Migrations
{
    /// <inheritdoc />
    public partial class v14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamStrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalHours = table.Column<int>(type: "int", nullable: false),
                    TotalMinutes = table.Column<int>(type: "int", nullable: false),
                    RandomQuestionOrder = table.Column<bool>(type: "bit", nullable: false),
                    CourseType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamStrId);
                });

            migrationBuilder.CreateTable(
                name: "StudentExams",
                columns: table => new
                {
                    StudentExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalTime = table.Column<int>(type: "int", nullable: false),
                    CourseType = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    isFinished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentExams", x => x.StudentExamId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionStrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamStrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RandomAnsOrder = table.Column<bool>(type: "bit", nullable: false),
                    IndexCorrect = table.Column<int>(type: "int", nullable: false),
                    ExamStrId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionStrId);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamStrId1",
                        column: x => x.ExamStrId1,
                        principalTable: "Exams",
                        principalColumn: "ExamStrId");
                });

            migrationBuilder.CreateTable(
                name: "OptionAns",
                columns: table => new
                {
                    OptionAnsStrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionAnsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionStrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionStrId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionAns", x => x.OptionAnsStrId);
                    table.ForeignKey(
                        name: "FK_OptionAns_Questions_QuestionStrId1",
                        column: x => x.QuestionStrId1,
                        principalTable: "Questions",
                        principalColumn: "QuestionStrId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OptionAns_QuestionStrId1",
                table: "OptionAns",
                column: "QuestionStrId1");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamStrId1",
                table: "Questions",
                column: "ExamStrId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionAns");

            migrationBuilder.DropTable(
                name: "StudentExams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Data.Migrations
{
    public partial class Try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_trainings_TrainingId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_TrainingId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "students");

            migrationBuilder.CreateTable(
                name: "StudentTraining",
                columns: table => new
                {
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    TrainingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTraining", x => new { x.StudentsId, x.TrainingsId });
                    table.ForeignKey(
                        name: "FK_StudentTraining_students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTraining_trainings_TrainingsId",
                        column: x => x.TrainingsId,
                        principalTable: "trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTraining_TrainingsId",
                table: "StudentTraining",
                column: "TrainingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTraining");

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_TrainingId",
                table: "students",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_trainings_TrainingId",
                table: "students",
                column: "TrainingId",
                principalTable: "trainings",
                principalColumn: "Id");
        }
    }
}

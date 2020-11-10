using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Migrations
{
    public partial class SeedStudentSubjectsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentSubjectId", "Grade", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 0, 1, 1 },
                    { 74, 0, 37, 5 },
                    { 72, 0, 36, 5 },
                    { 71, 0, 36, 1 },
                    { 70, 0, 35, 4 },
                    { 69, 0, 35, 1 },
                    { 68, 0, 34, 5 },
                    { 67, 0, 34, 1 },
                    { 66, 0, 33, 5 },
                    { 65, 0, 33, 1 },
                    { 64, 0, 32, 4 },
                    { 63, 0, 32, 1 },
                    { 62, 0, 31, 5 },
                    { 61, 0, 31, 2 },
                    { 60, 0, 30, 5 },
                    { 59, 0, 30, 2 },
                    { 58, 0, 29, 5 },
                    { 57, 0, 29, 3 },
                    { 56, 0, 28, 4 },
                    { 55, 0, 28, 2 },
                    { 54, 0, 27, 5 },
                    { 53, 0, 27, 2 },
                    { 75, 0, 38, 1 },
                    { 76, 0, 38, 5 },
                    { 77, 0, 39, 2 },
                    { 78, 0, 39, 4 },
                    { 100, 0, 50, 4 },
                    { 99, 0, 50, 1 },
                    { 98, 0, 49, 4 },
                    { 97, 0, 49, 2 },
                    { 96, 0, 48, 5 },
                    { 95, 0, 48, 3 },
                    { 94, 0, 47, 4 },
                    { 93, 0, 47, 3 },
                    { 92, 0, 46, 4 },
                    { 91, 0, 46, 2 },
                    { 52, 0, 26, 4 },
                    { 90, 0, 45, 4 },
                    { 88, 0, 44, 5 },
                    { 87, 0, 44, 2 },
                    { 86, 0, 43, 4 },
                    { 85, 0, 43, 2 },
                    { 84, 0, 42, 5 },
                    { 83, 0, 42, 1 },
                    { 82, 0, 41, 4 },
                    { 81, 0, 41, 2 },
                    { 80, 0, 40, 5 },
                    { 79, 0, 40, 1 },
                    { 89, 0, 45, 1 },
                    { 51, 0, 26, 3 },
                    { 73, 0, 37, 1 },
                    { 49, 0, 25, 1 },
                    { 23, 0, 12, 2 },
                    { 22, 0, 11, 5 },
                    { 21, 0, 11, 2 },
                    { 20, 0, 10, 4 },
                    { 19, 0, 10, 1 },
                    { 18, 0, 9, 5 },
                    { 17, 0, 9, 3 },
                    { 16, 0, 8, 5 },
                    { 15, 0, 8, 2 },
                    { 14, 0, 7, 5 },
                    { 24, 0, 12, 5 },
                    { 13, 0, 7, 1 },
                    { 11, 0, 6, 3 },
                    { 10, 0, 5, 5 },
                    { 9, 0, 5, 2 },
                    { 8, 0, 4, 4 },
                    { 7, 0, 4, 1 },
                    { 6, 0, 3, 5 },
                    { 5, 0, 3, 1 },
                    { 4, 0, 2, 4 },
                    { 50, 0, 25, 4 },
                    { 2, 0, 1, 4 },
                    { 12, 0, 6, 5 },
                    { 25, 0, 13, 3 },
                    { 3, 0, 2, 3 },
                    { 27, 0, 14, 2 },
                    { 48, 0, 24, 4 },
                    { 47, 0, 24, 1 },
                    { 46, 0, 23, 4 },
                    { 45, 0, 23, 3 },
                    { 44, 0, 22, 4 },
                    { 43, 0, 22, 1 },
                    { 41, 0, 21, 2 },
                    { 40, 0, 20, 4 },
                    { 39, 0, 20, 3 },
                    { 38, 0, 19, 4 },
                    { 42, 0, 21, 4 },
                    { 36, 0, 18, 4 },
                    { 37, 0, 19, 1 },
                    { 26, 0, 13, 5 },
                    { 29, 0, 15, 3 },
                    { 30, 0, 15, 4 },
                    { 31, 0, 16, 2 },
                    { 28, 0, 14, 5 },
                    { 33, 0, 17, 2 },
                    { 34, 0, 17, 4 },
                    { 35, 0, 18, 2 },
                    { 32, 0, 16, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50,
                column: "StudentName",
                value: "Ekaterine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32,
                column: "StudentName",
                value: "Zurab");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39,
                column: "StudentName",
                value: "Mariam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44,
                column: "StudentName",
                value: "Ana");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45,
                column: "StudentName",
                value: "Teimurazi");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47,
                column: "StudentName",
                value: "Anastasia");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48,
                column: "StudentName",
                value: "Estate");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49,
                column: "StudentName",
                value: "Ekaterine");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50,
                column: "StudentName",
                value: "Anastasia");
        }
    }
}

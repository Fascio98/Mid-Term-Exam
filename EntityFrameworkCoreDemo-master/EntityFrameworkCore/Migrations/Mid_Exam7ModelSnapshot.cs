﻿// <auto-generated />
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Migrations
{
    [DbContext(typeof(Mid_Exam7))]
    partial class Mid_Exam7ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCore.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 2,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 3,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 4,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 5,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 6,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 7,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 8,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 9,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 10,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 11,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 12,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 13,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 14,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 15,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 16,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 17,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 18,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 19,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 20,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 21,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 22,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 23,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 24,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 25,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 26,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 27,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 28,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 29,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 30,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 31,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 32,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 33,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 34,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 35,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 36,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 37,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 38,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 39,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 40,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 41,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 42,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 43,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 44,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 45,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 46,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 47,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 48,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 49,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 50,
                            StudentName = "Ekaterine"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCore.StudentSubject", b =>
                {
                    b.Property<int>("StudentSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentSubjectId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjects");

                    b.HasData(
                        new
                        {
                            StudentSubjectId = 1,
                            Grade = 0,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 2,
                            Grade = 0,
                            StudentId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 3,
                            Grade = 0,
                            StudentId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 4,
                            Grade = 0,
                            StudentId = 2,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 5,
                            Grade = 0,
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 6,
                            Grade = 0,
                            StudentId = 3,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 7,
                            Grade = 0,
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 8,
                            Grade = 0,
                            StudentId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 9,
                            Grade = 0,
                            StudentId = 5,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 10,
                            Grade = 0,
                            StudentId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 11,
                            Grade = 0,
                            StudentId = 6,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 12,
                            Grade = 0,
                            StudentId = 6,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 13,
                            Grade = 0,
                            StudentId = 7,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 14,
                            Grade = 0,
                            StudentId = 7,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 15,
                            Grade = 0,
                            StudentId = 8,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 16,
                            Grade = 0,
                            StudentId = 8,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 17,
                            Grade = 0,
                            StudentId = 9,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 18,
                            Grade = 0,
                            StudentId = 9,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 19,
                            Grade = 0,
                            StudentId = 10,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 20,
                            Grade = 0,
                            StudentId = 10,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 21,
                            Grade = 0,
                            StudentId = 11,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 22,
                            Grade = 0,
                            StudentId = 11,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 23,
                            Grade = 0,
                            StudentId = 12,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 24,
                            Grade = 0,
                            StudentId = 12,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 25,
                            Grade = 0,
                            StudentId = 13,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 26,
                            Grade = 0,
                            StudentId = 13,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 27,
                            Grade = 0,
                            StudentId = 14,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 28,
                            Grade = 0,
                            StudentId = 14,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 29,
                            Grade = 0,
                            StudentId = 15,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 30,
                            Grade = 0,
                            StudentId = 15,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 31,
                            Grade = 0,
                            StudentId = 16,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 32,
                            Grade = 0,
                            StudentId = 16,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 33,
                            Grade = 0,
                            StudentId = 17,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 34,
                            Grade = 0,
                            StudentId = 17,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 35,
                            Grade = 0,
                            StudentId = 18,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 36,
                            Grade = 0,
                            StudentId = 18,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 37,
                            Grade = 0,
                            StudentId = 19,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 38,
                            Grade = 0,
                            StudentId = 19,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 39,
                            Grade = 0,
                            StudentId = 20,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 40,
                            Grade = 0,
                            StudentId = 20,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 41,
                            Grade = 0,
                            StudentId = 21,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 42,
                            Grade = 0,
                            StudentId = 21,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 43,
                            Grade = 0,
                            StudentId = 22,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 44,
                            Grade = 0,
                            StudentId = 22,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 45,
                            Grade = 0,
                            StudentId = 23,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 46,
                            Grade = 0,
                            StudentId = 23,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 47,
                            Grade = 0,
                            StudentId = 24,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 48,
                            Grade = 0,
                            StudentId = 24,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 49,
                            Grade = 0,
                            StudentId = 25,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 50,
                            Grade = 0,
                            StudentId = 25,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 51,
                            Grade = 0,
                            StudentId = 26,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 52,
                            Grade = 0,
                            StudentId = 26,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 53,
                            Grade = 0,
                            StudentId = 27,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 54,
                            Grade = 0,
                            StudentId = 27,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 55,
                            Grade = 0,
                            StudentId = 28,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 56,
                            Grade = 0,
                            StudentId = 28,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 57,
                            Grade = 0,
                            StudentId = 29,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 58,
                            Grade = 0,
                            StudentId = 29,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 59,
                            Grade = 0,
                            StudentId = 30,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 60,
                            Grade = 0,
                            StudentId = 30,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 61,
                            Grade = 0,
                            StudentId = 31,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 62,
                            Grade = 0,
                            StudentId = 31,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 63,
                            Grade = 0,
                            StudentId = 32,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 64,
                            Grade = 0,
                            StudentId = 32,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 65,
                            Grade = 0,
                            StudentId = 33,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 66,
                            Grade = 0,
                            StudentId = 33,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 67,
                            Grade = 0,
                            StudentId = 34,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 68,
                            Grade = 0,
                            StudentId = 34,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 69,
                            Grade = 0,
                            StudentId = 35,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 70,
                            Grade = 0,
                            StudentId = 35,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 71,
                            Grade = 0,
                            StudentId = 36,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 72,
                            Grade = 0,
                            StudentId = 36,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 73,
                            Grade = 0,
                            StudentId = 37,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 74,
                            Grade = 0,
                            StudentId = 37,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 75,
                            Grade = 0,
                            StudentId = 38,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 76,
                            Grade = 0,
                            StudentId = 38,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 77,
                            Grade = 0,
                            StudentId = 39,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 78,
                            Grade = 0,
                            StudentId = 39,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 79,
                            Grade = 0,
                            StudentId = 40,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 80,
                            Grade = 0,
                            StudentId = 40,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 81,
                            Grade = 0,
                            StudentId = 41,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 82,
                            Grade = 0,
                            StudentId = 41,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 83,
                            Grade = 0,
                            StudentId = 42,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 84,
                            Grade = 0,
                            StudentId = 42,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 85,
                            Grade = 0,
                            StudentId = 43,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 86,
                            Grade = 0,
                            StudentId = 43,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 87,
                            Grade = 0,
                            StudentId = 44,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 88,
                            Grade = 0,
                            StudentId = 44,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 89,
                            Grade = 0,
                            StudentId = 45,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 90,
                            Grade = 0,
                            StudentId = 45,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 91,
                            Grade = 0,
                            StudentId = 46,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 92,
                            Grade = 0,
                            StudentId = 46,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 93,
                            Grade = 0,
                            StudentId = 47,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 94,
                            Grade = 0,
                            StudentId = 47,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 95,
                            Grade = 0,
                            StudentId = 48,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentSubjectId = 96,
                            Grade = 0,
                            StudentId = 48,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentSubjectId = 97,
                            Grade = 0,
                            StudentId = 49,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentSubjectId = 98,
                            Grade = 0,
                            StudentId = 49,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentSubjectId = 99,
                            Grade = 0,
                            StudentId = 50,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentSubjectId = 100,
                            Grade = 0,
                            StudentId = 50,
                            SubjectId = 4
                        });
                });

            modelBuilder.Entity("EntityFrameworkCore.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            SubjectName = "Daprogrameba"
                        },
                        new
                        {
                            SubjectId = 2,
                            SubjectName = "Matematika"
                        },
                        new
                        {
                            SubjectId = 3,
                            SubjectName = "Fizika"
                        },
                        new
                        {
                            SubjectId = 4,
                            SubjectName = "Qartuli"
                        },
                        new
                        {
                            SubjectId = 5,
                            SubjectName = "Geografia"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCore.StudentSubject", b =>
                {
                    b.HasOne("EntityFrameworkCore.Student", "Student")
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCore.Subject", "Subject")
                        .WithMany("Students")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
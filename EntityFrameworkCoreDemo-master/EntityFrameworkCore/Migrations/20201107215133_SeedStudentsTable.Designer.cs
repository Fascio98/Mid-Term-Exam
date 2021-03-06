﻿// <auto-generated />
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Migrations
{
    [DbContext(typeof(Mid_Exam7))]
    [Migration("20201107215133_SeedStudentsTable")]
    partial class SeedStudentsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 2,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 3,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 4,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 5,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 6,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 7,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 8,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 9,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 10,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 11,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 12,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 13,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 14,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 15,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 16,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 17,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 18,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 19,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 20,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 21,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 22,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 23,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 24,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 25,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 26,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 27,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 28,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 29,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 30,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 31,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 32,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 33,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 34,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 35,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 36,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 37,
                            StudentName = "Mariam"
                        },
                        new
                        {
                            StudentId = 38,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 39,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 40,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 41,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 42,
                            StudentName = "Ana"
                        },
                        new
                        {
                            StudentId = 43,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 44,
                            StudentName = "Ekaterine"
                        },
                        new
                        {
                            StudentId = 45,
                            StudentName = "Anastasia"
                        },
                        new
                        {
                            StudentId = 46,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 47,
                            StudentName = "Estate"
                        },
                        new
                        {
                            StudentId = 48,
                            StudentName = "Zurab"
                        },
                        new
                        {
                            StudentId = 49,
                            StudentName = "Teimurazi"
                        },
                        new
                        {
                            StudentId = 50,
                            StudentName = "Estate"
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

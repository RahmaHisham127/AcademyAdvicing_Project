﻿// <auto-generated />
using System;
using Academy.Repo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Academy.Repo.Data.Migrations
{
    [DbContext(typeof(AcademyContext))]
    [Migration("20250302200359_initialmigration2")]
    partial class initialmigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Academy.Core.Models.AssignedCourse", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("ClassWorkScore")
                        .HasColumnType("real");

                    b.Property<int>("CourseId1")
                        .HasColumnType("int");

                    b.Property<float>("FinalScore")
                        .HasColumnType("real");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PracticalScore")
                        .HasColumnType("real");

                    b.Property<int>("StudentId1")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId1");

                    b.HasIndex("StudentId1");

                    b.ToTable("Assignedcourses");
                });

            modelBuilder.Entity("Academy.Core.Models.AvailableCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcademicYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Availablecourses");
                });

            modelBuilder.Entity("Academy.Core.Models.Coordinator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("Academy.Core.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Credit")
                        .HasColumnType("real");

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.Property<int>("ManageById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("ManageById");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Academy.Core.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignedById")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedById");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Academy.Core.Models.DoctorCourses", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "DoctorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("doctorCourses");
                });

            modelBuilder.Entity("Academy.Core.Models.FinalExamTimeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("FinalExamTimeTable");
                });

            modelBuilder.Entity("Academy.Core.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UploadedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UploadedById");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Academy.Core.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenerateById")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenerateById");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Academy.Core.Models.ScheduleTimeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("UploadedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UploadedById");

                    b.ToTable("ScheduleTimeTable");
                });

            modelBuilder.Entity("Academy.Core.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompeletedHours")
                        .HasColumnType("int");

                    b.Property<float>("GPA")
                        .HasColumnType("real");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManageById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManageById");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Academy.Core.Models.StudentAffair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentAffairs");
                });

            modelBuilder.Entity("Academy.Core.Models.AssignedCourse", b =>
                {
                    b.HasOne("Academy.Core.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Core.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Academy.Core.Models.Course", b =>
                {
                    b.HasOne("Academy.Core.Models.Coordinator", "ManageBy")
                        .WithMany("Courses")
                        .HasForeignKey("ManageById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageBy");
                });

            modelBuilder.Entity("Academy.Core.Models.Doctor", b =>
                {
                    b.HasOne("Academy.Core.Models.Coordinator", "AssignedBy")
                        .WithMany("Doctors")
                        .HasForeignKey("AssignedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedBy");
                });

            modelBuilder.Entity("Academy.Core.Models.DoctorCourses", b =>
                {
                    b.HasOne("Academy.Core.Models.Course", "Course")
                        .WithMany("Doctor")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Academy.Core.Models.Doctor", "Doctor")
                        .WithMany("Courses")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Academy.Core.Models.Material", b =>
                {
                    b.HasOne("Academy.Core.Models.Doctor", "UploadedBy")
                        .WithMany("Materials")
                        .HasForeignKey("UploadedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("Academy.Core.Models.Report", b =>
                {
                    b.HasOne("Academy.Core.Models.Coordinator", "GenerateBy")
                        .WithMany("Reports")
                        .HasForeignKey("GenerateById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenerateBy");
                });

            modelBuilder.Entity("Academy.Core.Models.ScheduleTimeTable", b =>
                {
                    b.HasOne("Academy.Core.Models.Coordinator", "UploadedBy")
                        .WithMany("ScheduleTimeTables")
                        .HasForeignKey("UploadedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("Academy.Core.Models.Student", b =>
                {
                    b.HasOne("Academy.Core.Models.StudentAffair", "ManageBy")
                        .WithMany("Students")
                        .HasForeignKey("ManageById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageBy");
                });

            modelBuilder.Entity("Academy.Core.Models.Coordinator", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Doctors");

                    b.Navigation("Reports");

                    b.Navigation("ScheduleTimeTables");
                });

            modelBuilder.Entity("Academy.Core.Models.Course", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Academy.Core.Models.Doctor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Materials");
                });

            modelBuilder.Entity("Academy.Core.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Academy.Core.Models.StudentAffair", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

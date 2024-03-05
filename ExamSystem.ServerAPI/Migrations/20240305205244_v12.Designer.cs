﻿// <auto-generated />
using System;
using ExamSystem.ServerAPI.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamSystem.ServerAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240305205244_v12")]
    partial class v12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Error", b =>
                {
                    b.Property<int>("ErrorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ErrorId"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParticipationId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ErrorId");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<int>("CourseType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExamDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExamStrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExamTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RandomQuestionOrder")
                        .HasColumnType("bit");

                    b.Property<string>("TeacherFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int");

                    b.Property<int>("TotalMinutes")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.OptionAns", b =>
                {
                    b.Property<int>("OptionAnsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OptionAnsId"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid>("OptionAnsStrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestionStrId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OptionAnsId");

                    b.HasIndex("QuestionId");

                    b.ToTable("OptionAns");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Participation", b =>
                {
                    b.Property<int>("ParticipationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipationId"));

                    b.Property<int>("Exam_Id")
                        .HasColumnType("int");

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.Property<string>("Student_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParticipationId");

                    b.ToTable("Participations");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<Guid>("ExamStrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IndexCorrect")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestionStrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("RandomAnsOrder")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseType")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.OptionAns", b =>
                {
                    b.HasOne("ExamSystem.ServerAPI.Models.Question", null)
                        .WithMany("Options")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Question", b =>
                {
                    b.HasOne("ExamSystem.ServerAPI.Models.Exam", null)
                        .WithMany("questions")
                        .HasForeignKey("ExamId");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Exam", b =>
                {
                    b.Navigation("questions");
                });

            modelBuilder.Entity("ExamSystem.ServerAPI.Models.Question", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using ExpertEase.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpertEase.Infrastructure.Migrations
{
    [DbContext(typeof(WebAppDatabaseContext))]
    [Migration("20250416222510_UpdateSummaryLimit")]
    partial class UpdateSummaryLimit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "unaccent");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategorySpecialist", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SpecialistsUserId")
                        .HasColumnType("uuid");

                    b.HasKey("CategoriesId", "SpecialistsUserId");

                    b.HasIndex("SpecialistsUserId");

                    b.ToTable("SpecialistCategories", (string)null);
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Reply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ReceiverUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("RejectedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RequestedStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SenderUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Specialist", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("YearsExperience")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.ToTable("Specialist");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ExternalSource")
                        .HasColumnType("text");

                    b.Property<Guid>("InitiatorUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ReceiverAccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ReceiverUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("RejectedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("RejectionCode")
                        .HasColumnType("integer");

                    b.Property<string>("RejectionDetails")
                        .HasColumnType("text");

                    b.Property<Guid?>("SenderAccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SenderUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("TransactionType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("InitiatorUserId");

                    b.HasIndex("ReceiverAccountId");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("SenderAccountId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CategorySpecialist", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpertEase.Domain.Entities.Specialist", null)
                        .WithMany()
                        .HasForeignKey("SpecialistsUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Account", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("ExpertEase.Domain.Entities.Account", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Reply", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.Request", "Request")
                        .WithMany("Replies")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Request", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.User", "ReceiverUser")
                        .WithMany()
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExpertEase.Domain.Entities.User", "SenderUser")
                        .WithMany("Requests")
                        .HasForeignKey("SenderUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Specialist", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.User", "User")
                        .WithOne("Specialist")
                        .HasForeignKey("ExpertEase.Domain.Entities.Specialist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("ExpertEase.Domain.Entities.User", "InitiatorUser")
                        .WithMany("Transactions")
                        .HasForeignKey("InitiatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpertEase.Domain.Entities.Account", "ReceiverAccount")
                        .WithMany()
                        .HasForeignKey("ReceiverAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ExpertEase.Domain.Entities.User", "ReceiverUser")
                        .WithMany()
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ExpertEase.Domain.Entities.Account", "SenderAccount")
                        .WithMany()
                        .HasForeignKey("SenderAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ExpertEase.Domain.Entities.User", "SenderUser")
                        .WithMany()
                        .HasForeignKey("SenderUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("InitiatorUser");

                    b.Navigation("ReceiverAccount");

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderAccount");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.Request", b =>
                {
                    b.Navigation("Replies");
                });

            modelBuilder.Entity("ExpertEase.Domain.Entities.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("Requests");

                    b.Navigation("Specialist");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

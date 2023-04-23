﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolChatOriginal.Models;

#nullable disable

namespace SchoolChatOriginal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221215160944_Mig2")]
    partial class Mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolChat.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("SchoolChat.Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SchoolChat.Models.Group", b =>
                {
                    b.Property<int>("IdGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGroup"));

                    b.Property<int>("CategoryIdCategory")
                        .HasColumnType("int");

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.HasKey("IdGroup");

                    b.HasIndex("CategoryIdCategory");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SchoolChat.Models.Message", b =>
                {
                    b.Property<int>("IdMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMessage"));

                    b.Property<int>("GroupIdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("MessageTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TextMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.HasKey("IdMessage");

                    b.HasIndex("GroupIdGroup");

                    b.HasIndex("UserId");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SchoolChat.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"));

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SchoolChat.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SchoolChatOriginal.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroupIdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupIdGroup");

                    b.HasIndex("UserId");

                    b.HasIndex("UserIdUser");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("SchoolChatOriginal.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdRole")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("RoleIdRole")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleIdRole");

                    b.HasIndex("UserId");

                    b.HasIndex("UserIdUser");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SchoolChat.Models.Group", b =>
                {
                    b.HasOne("SchoolChat.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryIdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SchoolChat.Models.Message", b =>
                {
                    b.HasOne("SchoolChat.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupIdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolChat.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("SchoolChat.Models.User", null)
                        .WithMany("Messages")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolChatOriginal.Models.UserGroup", b =>
                {
                    b.HasOne("SchoolChat.Models.Group", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupIdGroup");

                    b.HasOne("SchoolChat.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("SchoolChat.Models.User", null)
                        .WithMany("UserGroups")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolChatOriginal.Models.UserRole", b =>
                {
                    b.HasOne("SchoolChat.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleIdRole");

                    b.HasOne("SchoolChat.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("SchoolChat.Models.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolChat.Models.Group", b =>
                {
                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("SchoolChat.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SchoolChat.Models.User", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserGroups");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
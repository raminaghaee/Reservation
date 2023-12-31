﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoolDA.Contexts;

#nullable disable

namespace PoolDA.Migrations
{
    [DbContext(typeof(PoolDbContext))]
    partial class PoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PoolBL.Constant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<int>("IsActived")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Constant", "Pool");
                });

            modelBuilder.Entity("PoolBL.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.HasIndex("UserId");

                    b.ToTable("Employee", "Pool");
                });

            modelBuilder.Entity("PoolBL.Pay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<string>("CreateDate")
                        .IsRequired()
                        .HasColumnType("NCHAR(10)");

                    b.Property<string>("CreateTime")
                        .IsRequired()
                        .HasColumnType("NCHAR(5)");

                    b.Property<int>("CreateTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PayTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Pay", "Pool");
                });

            modelBuilder.Entity("PoolBL.Pool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Pool", "Pool");
                });

            modelBuilder.Entity("PoolBL.Reserved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmDate")
                        .IsRequired()
                        .HasColumnType("NCHAR(10)");

                    b.Property<string>("ConfirmTime")
                        .IsRequired()
                        .HasColumnType("NCHAR(5)");

                    b.Property<string>("CreateDate")
                        .IsRequired()
                        .HasColumnType("NCHAR(10)");

                    b.Property<string>("CreateTime")
                        .IsRequired()
                        .HasColumnType("NCHAR(5)");

                    b.Property<int>("CreateTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("IsConfirm")
                        .HasColumnType("int");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<int>("SansId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PoolId");

                    b.HasIndex("SansId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Reserved", "Pool");
                });

            modelBuilder.Entity("PoolBL.Sans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeekId")
                        .HasColumnType("int");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("NCHAR(5)");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("NCHAR(5)");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.ToTable("Sans", "Pool");
                });

            modelBuilder.Entity("PoolBL.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<int>("CreateTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PoolId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket", "Pool");
                });

            modelBuilder.Entity("PoolBL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivedId")
                        .HasColumnType("int");

                    b.Property<byte?>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PoolBL.Employee", b =>
                {
                    b.HasOne("PoolBL.Pool", "Pool")
                        .WithMany("Employees")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolBL.User", "User")
                        .WithMany("Employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoolBL.Pay", b =>
                {
                    b.HasOne("PoolBL.Ticket", "Ticket")
                        .WithOne("Pay")
                        .HasForeignKey("PoolBL.Pay", "TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("PoolBL.Reserved", b =>
                {
                    b.HasOne("PoolBL.Employee", "Employee")
                        .WithMany("Reserveds")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("PoolBL.Pool", null)
                        .WithMany("Reserveds")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PoolBL.Sans", null)
                        .WithMany("Reserved")
                        .HasForeignKey("SansId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PoolBL.Ticket", "Ticket")
                        .WithMany("Reserveds")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolBL.User", null)
                        .WithMany("Reserveds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("PoolBL.Sans", b =>
                {
                    b.HasOne("PoolBL.Pool", "Pool")
                        .WithMany("Sans")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("PoolBL.Ticket", b =>
                {
                    b.HasOne("PoolBL.Employee", "Employee")
                        .WithMany("Tickets")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("PoolBL.Pool", "Pool")
                        .WithMany("Tickets")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolBL.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Pool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoolBL.Employee", b =>
                {
                    b.Navigation("Reserveds");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("PoolBL.Pool", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Reserveds");

                    b.Navigation("Sans");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("PoolBL.Sans", b =>
                {
                    b.Navigation("Reserved");
                });

            modelBuilder.Entity("PoolBL.Ticket", b =>
                {
                    b.Navigation("Pay")
                        .IsRequired();

                    b.Navigation("Reserveds");
                });

            modelBuilder.Entity("PoolBL.User", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Reserveds");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}

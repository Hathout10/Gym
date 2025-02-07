﻿// <auto-generated />
using System;
using GYM.System.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GYM.System.DAL.Data.Migrations
{
    [DbContext(typeof(GymDbContext))]
    [Migration("20250207172632_Addsessions2")]
    partial class Addsessions2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Booking_Seessions", b =>
                {
                    b.Property<int>("playerId")
                        .HasColumnType("int");

                    b.Property<int>("subscriptionId")
                        .HasColumnType("int");

                    b.Property<int>("receptionistId")
                        .HasColumnType("int");

                    b.Property<int?>("Sessionsid")
                        .HasColumnType("int");

                    b.HasKey("playerId", "subscriptionId", "receptionistId");

                    b.HasIndex("Sessionsid");

                    b.HasIndex("receptionistId");

                    b.HasIndex("subscriptionId");

                    b.ToTable("BookingSeessions");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Booking_Subscription", b =>
                {
                    b.Property<int>("playerId")
                        .HasColumnType("int");

                    b.Property<int>("subscriptionId")
                        .HasColumnType("int");

                    b.Property<int>("receptionistId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("playerId", "subscriptionId", "receptionistId");

                    b.HasIndex("receptionistId");

                    b.HasIndex("subscriptionId");

                    b.ToTable("BookingSubscription");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.CashPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("adminId")
                        .HasColumnType("int");

                    b.Property<int?>("receptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("adminId");

                    b.HasIndex("receptionistId");

                    b.ToTable("CashPayment");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecializationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Equipments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("adminid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("adminid");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<bool?>("IsStopped")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.Property<int?>("receptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("receptionistId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Receptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receptionist");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Sessions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("adminId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("adminId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Subscription", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumOf_Sessions")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("adminId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("adminId");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("Gym.System.DAL.Data.Entites.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Bonus")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("adminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("adminId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Booking_Seessions", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Sessions", null)
                        .WithMany("BookingSubscription")
                        .HasForeignKey("Sessionsid");

                    b.HasOne("GYM.System.DAL.Data.Entites.Player", "player")
                        .WithMany()
                        .HasForeignKey("playerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GYM.System.DAL.Data.Entites.Receptionist", "receptionist")
                        .WithMany()
                        .HasForeignKey("receptionistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GYM.System.DAL.Data.Entites.Subscription", "subscription")
                        .WithMany()
                        .HasForeignKey("subscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("player");

                    b.Navigation("receptionist");

                    b.Navigation("subscription");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Booking_Subscription", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Player", "player")
                        .WithMany("BookingSubscription")
                        .HasForeignKey("playerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GYM.System.DAL.Data.Entites.Receptionist", "receptionist")
                        .WithMany("BookingSubscription")
                        .HasForeignKey("receptionistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GYM.System.DAL.Data.Entites.Subscription", "subscription")
                        .WithMany("BookingSubscription")
                        .HasForeignKey("subscriptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("player");

                    b.Navigation("receptionist");

                    b.Navigation("subscription");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.CashPayment", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Admin", "admin")
                        .WithMany("ControlPayments")
                        .HasForeignKey("adminId");

                    b.HasOne("GYM.System.DAL.Data.Entites.Receptionist", "receptionist")
                        .WithMany("Enrollpayments")
                        .HasForeignKey("receptionistId");

                    b.Navigation("admin");

                    b.Navigation("receptionist");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Equipments", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Admin", "admin")
                        .WithMany("Addequipments")
                        .HasForeignKey("adminid");

                    b.Navigation("admin");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Player", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Receptionist", "receptionist")
                        .WithMany("AddPlayer")
                        .HasForeignKey("receptionistId");

                    b.Navigation("receptionist");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Sessions", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Admin", "admin")
                        .WithMany()
                        .HasForeignKey("adminId");

                    b.Navigation("admin");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Subscription", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Admin", "admin")
                        .WithMany("Addplan")
                        .HasForeignKey("adminId");

                    b.Navigation("admin");
                });

            modelBuilder.Entity("Gym.System.DAL.Data.Entites.Employees", b =>
                {
                    b.HasOne("GYM.System.DAL.Data.Entites.Admin", "admin")
                        .WithMany("manageEmployee")
                        .HasForeignKey("adminId");

                    b.Navigation("admin");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Admin", b =>
                {
                    b.Navigation("Addequipments");

                    b.Navigation("Addplan");

                    b.Navigation("ControlPayments");

                    b.Navigation("manageEmployee");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Player", b =>
                {
                    b.Navigation("BookingSubscription");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Receptionist", b =>
                {
                    b.Navigation("AddPlayer");

                    b.Navigation("BookingSubscription");

                    b.Navigation("Enrollpayments");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Sessions", b =>
                {
                    b.Navigation("BookingSubscription");
                });

            modelBuilder.Entity("GYM.System.DAL.Data.Entites.Subscription", b =>
                {
                    b.Navigation("BookingSubscription");
                });
#pragma warning restore 612, 618
        }
    }
}

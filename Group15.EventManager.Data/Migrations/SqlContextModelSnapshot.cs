﻿// <auto-generated />
using System;
using Group15.EventManager.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Group15.EventManager.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoadName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoadNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoadName = "Bredgade",
                            RoadNumber = 1
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<int>("Invited")
                        .HasColumnType("int");

                    b.Property<int>("MaxCustomerLimit")
                        .HasColumnType("int");

                    b.Property<int>("MinCustomerAmount")
                        .HasColumnType("int");

                    b.Property<int>("NotRegistred")
                        .HasColumnType("int");

                    b.Property<int>("Registered")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Attendance");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"),
                            CreatedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Finished = false,
                            Invited = 0,
                            MaxCustomerLimit = 100,
                            MinCustomerAmount = 10,
                            NotRegistred = 0,
                            Registered = 0
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Auth.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                            ConcurrencyStamp = "bd5b9857-9d78-4f9d-81e3-28569973e0a2",
                            CreatedDate = new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminDev@hotmail.coM",
                            FirstName = "Rasmus",
                            LastName = "Petersen",
                            NormalizedEmail = "ADMINDEV@HOTMAIL.COM",
                            NormalizedUserName = "ADMINDEV@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKFD5G4BF9gaZ7MShGkxwTlFaAYjEerlpF/QsTWhrHvIhF3n+ry+9mGIA+abQWtAAQ==",
                            PhoneNumber = "28929173",
                            SecurityStamp = "f4572cb1-6f71-46fd-8260-0baea7287367",
                            UserName = "adminDev@hotmail.com"
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("038d1fee-4610-4f8f-acf5-d35d2f24d72f"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Herning",
                            RegionId = new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"),
                            Zipcode = 7429
                        },
                        new
                        {
                            Id = new Guid("6daf7bfe-850b-4bdd-87c5-5cf5cc2160dd"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aalborg",
                            RegionId = new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"),
                            Zipcode = 9000
                        },
                        new
                        {
                            Id = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Odense",
                            RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"),
                            Zipcode = 5000
                        },
                        new
                        {
                            Id = new Guid("0a0e4d03-66af-4121-8de0-707d12beaeed"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Slagelse",
                            RegionId = new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"),
                            Zipcode = 4200
                        },
                        new
                        {
                            Id = new Guid("1d3ffeaa-3d1f-4920-9ffa-310f61b8dc41"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "København",
                            RegionId = new Guid("808bb796-576a-46d8-a53f-cd52324d9705"),
                            Zipcode = 2100
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Torsten Jakobsen",
                            StoreId = new Guid("da868f6a-4f8c-4695-baae-4a0feea05207")
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AttendanceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndEventDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("LastBookingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MarkerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaxCustomerLimit")
                        .HasColumnType("int");

                    b.Property<int>("MinCustomerAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PayOnline")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AttendanceId");

                    b.HasIndex("CityId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FoodId");

                    b.HasIndex("MarkerId");

                    b.HasIndex("RegionId");

                    b.HasIndex("StoreId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                            AddressId = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                            AttendanceId = new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"),
                            CityId = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eventet kommer til at foregå i Odense kl. 16:00, hvor man vil få tilbudt forfriskninger og vin til maden",
                            EmployeeId = new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"),
                            EndEventDate = new DateTime(2022, 12, 24, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2022, 12, 24, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            FoodId = new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"),
                            Image = new byte[] { 0 },
                            LastBookingDate = new DateTime(2022, 12, 12, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkerId = new Guid("847fea10-80f0-49a0-8997-409eafdb5892"),
                            MaxCustomerLimit = 200,
                            MinCustomerAmount = 50,
                            Name = "Vinsmagning i hyggelige omgivelser",
                            PayOnline = true,
                            Price = 700.0,
                            RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274")
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Stegt and",
                            Price = 249.94999999999999
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4bca98a6-3cd0-49da-a947-02ad2ef8cdf5"),
                            CreatedDate = new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 30.0,
                            Name = "Basic"
                        },
                        new
                        {
                            Id = new Guid("cf113457-a62f-4ed5-ae65-d5d4ebc09537"),
                            CreatedDate = new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 40.0,
                            Name = "Member"
                        },
                        new
                        {
                            Id = new Guid("0daeaea2-2e4e-49f7-be7b-d61724c60971"),
                            CreatedDate = new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 45.0,
                            Name = "Business"
                        },
                        new
                        {
                            Id = new Guid("dba67215-9771-457d-9698-d7dc708a00e7"),
                            CreatedDate = new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 55.0,
                            Name = "Premium"
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Joint.ApplicationUserEvent", b =>
                {
                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ApplicationUserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("UserEvents");
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Marker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("X")
                        .HasColumnType("float");

                    b.Property<double>("Y")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Markers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("847fea10-80f0-49a0-8997-409eafdb5892"),
                            CreatedDate = new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            X = 10.369267000000001,
                            Y = 55.427731000000001
                        },
                        new
                        {
                            Id = new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"),
                            CreatedDate = new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            X = 10.379875,
                            Y = 55.394002999999998
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Midtjylland"
                        },
                        new
                        {
                            Id = new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nordjylland"
                        },
                        new
                        {
                            Id = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Syddanmark"
                        },
                        new
                        {
                            Id = new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sjælland"
                        },
                        new
                        {
                            Id = new Guid("808bb796-576a-46d8-a53f-cd52324d9705"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hovedstaden"
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MarkerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("MarkerId");

                    b.HasIndex("RegionId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"),
                            AddressId = new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                            CityId = new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkerId = new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"),
                            Name = "Odense Vinbutik",
                            RegionId = new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274")
                        });
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1f30749-d72d-422f-860c-534d49297bd8"),
                            CreatedDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2209255-92ed-4e3a-9368-31736af7f935"),
                            ConcurrencyStamp = "62b0f3e4-fa81-4b33-a5b4-9c21e8aa577f",
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = new Guid("6519cc1b-cd18-4898-a7bd-959d826ff413"),
                            ConcurrencyStamp = "9be42a72-8ca8-42fb-a61c-bc8e323f523e",
                            CreatedDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.City", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Employee", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Store", "Store")
                        .WithMany("Employees")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Event", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Group15.EventManager.Domain.Models.Attendance", "Attendance")
                        .WithMany()
                        .HasForeignKey("AttendanceId");

                    b.HasOne("Group15.EventManager.Domain.Models.City", "City")
                        .WithMany("Events")
                        .HasForeignKey("CityId");

                    b.HasOne("Group15.EventManager.Domain.Models.Employee", "Employee")
                        .WithMany("Events")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Group15.EventManager.Domain.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("Group15.EventManager.Domain.Models.Marker", "Marker")
                        .WithMany()
                        .HasForeignKey("MarkerId");

                    b.HasOne("Group15.EventManager.Domain.Models.Region", "Region")
                        .WithMany("Events")
                        .HasForeignKey("RegionId");

                    b.HasOne("Group15.EventManager.Domain.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Joint.ApplicationUserEvent", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", "User")
                        .WithMany("UserEvents")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group15.EventManager.Domain.Models.Event", "Event")
                        .WithMany("UserEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Store", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Group15.EventManager.Domain.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Group15.EventManager.Domain.Models.Marker", "Marker")
                        .WithMany()
                        .HasForeignKey("MarkerId");

                    b.HasOne("Group15.EventManager.Domain.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("Group15.EventManager.Domain.Models.Ticket", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId");

                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Group15.EventManager.Domain.Models.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

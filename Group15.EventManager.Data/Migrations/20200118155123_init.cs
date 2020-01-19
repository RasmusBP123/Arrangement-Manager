using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RoadName = table.Column<string>(nullable: true),
                    RoadNumber = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Invited = table.Column<int>(nullable: false),
                    Registered = table.Column<int>(nullable: false),
                    NotRegistred = table.Column<int>(nullable: false),
                    MinCustomerAmount = table.Column<int>(nullable: false),
                    MaxCustomerLimit = table.Column<int>(nullable: false),
                    Finished = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Discount = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    RegionId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AddressId = table.Column<Guid>(nullable: true),
                    MarkerId = table.Column<Guid>(nullable: true),
                    RegionId = table.Column<Guid>(nullable: true),
                    CityId = table.Column<Guid>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Markers_MarkerId",
                        column: x => x.MarkerId,
                        principalTable: "Markers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StoreId = table.Column<Guid>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    PayOnline = table.Column<bool>(nullable: false),
                    MinCustomerAmount = table.Column<int>(nullable: false),
                    MaxCustomerLimit = table.Column<int>(nullable: false),
                    LastBookingDate = table.Column<DateTime>(nullable: false),
                    EventDate = table.Column<DateTime>(nullable: false),
                    EndEventDate = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: true),
                    MarkerId = table.Column<Guid>(nullable: true),
                    AttendanceId = table.Column<Guid>(nullable: true),
                    CityId = table.Column<Guid>(nullable: true),
                    RegionId = table.Column<Guid>(nullable: true),
                    FoodId = table.Column<Guid>(nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    StoreId = table.Column<Guid>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Attendance_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Markers_MarkerId",
                        column: x => x.MarkerId,
                        principalTable: "Markers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    EventId = table.Column<Guid>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => new { x.ApplicationUserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "CreatedDate", "RoadName", "RoadNumber" },
                values: new object[] { new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bredgade", 1 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("f2209255-92ed-4e3a-9368-31736af7f935"), "62b0f3e4-fa81-4b33-a5b4-9c21e8aa577f", new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "USER" },
                    { new Guid("6519cc1b-cd18-4898-a7bd-959d826ff413"), "9be42a72-8ca8-42fb-a61c-bc8e323f523e", new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"), "bd5b9857-9d78-4f9d-81e3-28569973e0a2", new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDev@hotmail.coM", "Rasmus", "Petersen", "ADMINDEV@HOTMAIL.COM", "ADMINDEV@HOTMAIL.COM", "AQAAAAEAACcQAAAAENFsvzdYfVG/7FmytXy0aNnHvsuBUYWbCUTyIZKSBIfWK7C1niccqvrwUmbRM04PPQ==", "28929173", "f4572cb1-6f71-46fd-8260-0baea7287367", "adminDev@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "Id", "CreatedDate", "Finished", "Invited", "MaxCustomerLimit", "MinCustomerAmount", "NotRegistred", "Registered" },
                values: new object[] { new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 100, 10, 0, 0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedDate", "Name", "Price" },
                values: new object[] { new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stegt and", 249.94999999999999 });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedDate", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("4bca98a6-3cd0-49da-a947-02ad2ef8cdf5"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0, "Basic" },
                    { new Guid("cf113457-a62f-4ed5-ae65-d5d4ebc09537"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, "Member" },
                    { new Guid("0daeaea2-2e4e-49f7-be7b-d61724c60971"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, "Business" },
                    { new Guid("dba67215-9771-457d-9698-d7dc708a00e7"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.0, "Premium" }
                });

            migrationBuilder.InsertData(
                table: "Markers",
                columns: new[] { "Id", "CreatedDate", "X", "Y" },
                values: new object[,]
                {
                    { new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"), new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.379875, 55.394002999999998 },
                    { new Guid("847fea10-80f0-49a0-8997-409eafdb5892"), new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.369267000000001, 55.427731000000001 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midtjylland" },
                    { new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nordjylland" },
                    { new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syddanmark" },
                    { new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sjælland" },
                    { new Guid("808bb796-576a-46d8-a53f-cd52324d9705"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hovedstaden" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "Name", "RegionId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("038d1fee-4610-4f8f-acf5-d35d2f24d72f"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herning", new Guid("0d096733-5437-4c53-8f3d-0e815d3753b3"), 7429 },
                    { new Guid("6daf7bfe-850b-4bdd-87c5-5cf5cc2160dd"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aalborg", new Guid("4c68ec57-cfed-4b52-be86-6349d47f9a74"), 9000 },
                    { new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odense", new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"), 5000 },
                    { new Guid("0a0e4d03-66af-4121-8de0-707d12beaeed"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slagelse", new Guid("2469efa8-72a6-490f-bf5a-b434e672bc78"), 4200 },
                    { new Guid("1d3ffeaa-3d1f-4920-9ffa-310f61b8dc41"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "København", new Guid("808bb796-576a-46d8-a53f-cd52324d9705"), 2100 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedDate", "EventId", "UserId" },
                values: new object[] { new Guid("a1f30749-d72d-422f-860c-534d49297bd8"), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278") });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "CityId", "CreatedDate", "MarkerId", "Name", "RegionId" },
                values: new object[] { new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"), new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"), "Odense Vinbutik", new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274") });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedDate", "Name", "StoreId" },
                values: new object[] { new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Torsten Jakobsen", new Guid("da868f6a-4f8c-4695-baae-4a0feea05207") });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "AddressId", "AttendanceId", "CityId", "CreatedDate", "Description", "EmployeeId", "EndEventDate", "EventDate", "FoodId", "Image", "LastBookingDate", "MarkerId", "MaxCustomerLimit", "MinCustomerAmount", "Name", "PayOnline", "Price", "RegionId", "StoreId" },
                values: new object[] { new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"), new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"), new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eventet kommer til at foregå i Odense kl. 16:00, hvor man vil få tilbudt forfriskninger og vin til maden", new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"), new DateTime(2022, 12, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"), new byte[] { 0 }, new DateTime(2022, 12, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("847fea10-80f0-49a0-8997-409eafdb5892"), 200, 50, "Vinsmagning i hyggelige omgivelser", true, 700.0, new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274"), null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RegionId",
                table: "Cities",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StoreId",
                table: "Employees",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AddressId",
                table: "Event",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AttendanceId",
                table: "Event",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CityId",
                table: "Event",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EmployeeId",
                table: "Event",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_FoodId",
                table: "Event",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_MarkerId",
                table: "Event",
                column: "MarkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_RegionId",
                table: "Event",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StoreId",
                table: "Event",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId",
                table: "Stores",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CityId",
                table: "Stores",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_MarkerId",
                table: "Stores",
                column: "MarkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_RegionId",
                table: "Stores",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Markers");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}

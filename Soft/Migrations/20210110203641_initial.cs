using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SemestriProject.Soft.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Africa",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    LiftingCapacity = table.Column<string>(nullable: true),
                    ContainerType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Africa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "America",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    TypeOfCargo = table.Column<string>(nullable: true),
                    AirplaneType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_America", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Australia",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    TypeOfCargo = table.Column<string>(nullable: true),
                    AirplaneType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Australia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baltics",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    Loading = table.Column<string>(nullable: true),
                    Departures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baltics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "China",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    TypeOfCargo = table.Column<string>(nullable: true),
                    AirplaneType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_China", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Europe",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    LiftingCapacity = table.Column<string>(nullable: true),
                    ContainerType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Europe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakeOrder",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AddressRow = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PackageType = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Volume = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    GoodsDescription = table.Column<string>(nullable: true),
                    DangerousGoods = table.Column<bool>(nullable: false),
                    TemperatureSensitive = table.Column<bool>(nullable: false),
                    CustomerComments = table.Column<string>(nullable: true),
                    AcceptTerms = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RussiaAndCIS",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    Loading = table.Column<string>(nullable: true),
                    Departures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RussiaAndCIS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scandinavia",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReadyForCollection = table.Column<DateTime>(nullable: true),
                    RequestedDeliveryTime = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    TravelTime = table.Column<string>(nullable: true),
                    OrderTime = table.Column<string>(nullable: true),
                    Loading = table.Column<string>(nullable: true),
                    Departures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scandinavia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Africa");

            migrationBuilder.DropTable(
                name: "America");

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
                name: "Australia");

            migrationBuilder.DropTable(
                name: "Baltics");

            migrationBuilder.DropTable(
                name: "China");

            migrationBuilder.DropTable(
                name: "Europe");

            migrationBuilder.DropTable(
                name: "MakeOrder");

            migrationBuilder.DropTable(
                name: "RussiaAndCIS");

            migrationBuilder.DropTable(
                name: "Scandinavia");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

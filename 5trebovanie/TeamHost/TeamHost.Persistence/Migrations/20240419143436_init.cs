using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamHost.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aplha2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aplha3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronimic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryGame",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    GamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGame", x => new { x.CategoryId, x.GamesId });
                    table.ForeignKey(
                        name: "FK_CategoryGame_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatform",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "int", nullable: false),
                    PlatformsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatform", x => new { x.GamesId, x.PlatformsId });
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    StaticFileId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyDeveloperId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Companies_CompanyDeveloperId",
                        column: x => x.CompanyDeveloperId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaticFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticFiles_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platforms_StaticFiles_ImageId",
                        column: x => x.ImageId,
                        principalTable: "StaticFiles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "strategy", null, null, "Стратегии", "Strategy", null, null },
                    { 2, "adventure", null, null, "Приключенческие игры", "Adventure", null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Aplha2", "Aplha3", "Code", "Fullname", "Name" },
                values: new object[,]
                {
                    { 1, "AU", "AUS", 36L, "АВСТРАЛИЯ", "АВСТРАЛИЯ" },
                    { 2, "AT", "AUT", 40L, "АВСТРИЙСКАЯ РЕСПУБЛИКА", "АВСТРИЯ" },
                    { 3, "AZ", "AZE", 31L, "РЕСПУБЛИКА АЗЕРБАЙДЖАН", "АЗЕРБАЙДЖАН" },
                    { 4, "AL", "ALB", 8L, "РЕСПУБЛИКА АЛБАНИЯ", "АЛБАНИЯ" },
                    { 5, "DZ", "DZA", 12L, "АЛЖИРСКАЯ НАРОДНАЯ ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "АЛЖИР" },
                    { 6, "AI", "AIA", 660L, "АНГИЛЬЯ", "АНГИЛЬЯ" },
                    { 7, "AO", "AGO", 24L, "РЕСПУБЛИКА АНГОЛА", "АНГОЛА" },
                    { 8, "AD", "AND", 20L, "КНЯЖЕСТВО АНДОРРА", "АНДОРРА" },
                    { 9, "AQ", "ATA", 10L, "АНТАРКТИДА", "АНТАРКТИДА" },
                    { 10, "AG", "ATG", 28L, "АНТИГУА И БАРБУДА", "АНТИГУА И БАРБУДА" },
                    { 11, "AR", "ARG", 32L, "АРГЕНТИНСКАЯ РЕСПУБЛИКА", "АРГЕНТИНА" },
                    { 12, "AM", "ARM", 51L, "РЕСПУБЛИКА АРМЕНИЯ", "АРМЕНИЯ" },
                    { 13, "AW", "ABW", 533L, "ОСТРОВ АРУБА", "АРУБА" },
                    { 14, "AF", "AFG", 4L, "ПЕРЕХОДНОЕ ИСЛАМСКОЕ ГОСУДАРСТВО АФГАНИСТАН", "АФГАНИСТАН" },
                    { 15, "BS", "BHS", 44L, "СОДРУЖЕСТВО БАГАМЫ", "БАГАМЫ" },
                    { 16, "BD", "BGD", 50L, "НАРОДНАЯ РЕСПУБЛИКА БАНГЛАДЕШ", "БАНГЛАДЕШ" },
                    { 17, "BB", "BRB", 52L, "БАРБАДОС", "БАРБАДОС" },
                    { 18, "BH", "BHR", 48L, "КОРОЛЕВСТВО БАХРЕЙН", "БАХРЕЙН" },
                    { 19, "BY", "BLR", 112L, "РЕСПУБЛИКА БЕЛАРУСЬ", "БЕЛАРУСЬ" },
                    { 20, "BZ", "BLZ", 84L, "БЕЛИЗ", "БЕЛИЗ" },
                    { 21, "BE", "BEL", 56L, "КОРОЛЕВСТВО БЕЛЬГИИ", "БЕЛЬГИЯ" },
                    { 22, "BJ", "BEN", 204L, "РЕСПУБЛИКА БЕНИН", "БЕНИН" },
                    { 23, "BM", "BMU", 60L, "БЕРМУДСКИЕ ОСТРОВА", "БЕРМУДЫ" },
                    { 24, "BG", "BGR", 100L, "РЕСПУБЛИКА БОЛГАРИЯ", "БОЛГАРИЯ" },
                    { 25, "BO", "BOL", 68L, "РЕСПУБЛИКА БОЛИВИЯ", "БОЛИВИЯ" },
                    { 26, "BA", "BIH", 70L, "БОСНИЯ И ГЕРЦЕГОВИНА", "БОСНИЯ И ГЕРЦЕГОВИНА" },
                    { 27, "BW", "BWA", 72L, "РЕСПУБЛИКА БОТСВАНА", "БОТСВАНА" },
                    { 28, "BR", "BRA", 76L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА БРАЗИЛИЯ", "БРАЗИЛИЯ" },
                    { 29, "IO", "IOT", 86L, "БРИТАНСКАЯ ТЕРРИТОРИЯ В ИНДИЙСКОМ ОКЕАНЕ (БРИТ.)", "БРИТАН. ТЕРРИТ." },
                    { 30, "BN", "BRN", 96L, "БРУНЕЙ-ДАРУССАЛАМ", "БРУНЕЙ" },
                    { 31, "BV", "BVT", 74L, "ОСТРОВ БУВЕ", "БУВЕ" },
                    { 32, "BF", "BFA", 854L, "БУРКИНА-ФАСО", "БУРКИНА-ФАСО" },
                    { 33, "BI", "BDI", 108L, "РЕСПУБЛИКА БУРУНДИ", "БУРУНДИ" },
                    { 34, "BT", "BTN", 64L, "КОРОЛЕВСТВО БУТАН", "БУТАН" },
                    { 35, "VU", "VUT", 548L, "РЕСПУБЛИКА ВАНУАТУ", "ВАНУАТУ" },
                    { 36, "VA", "VAT", 336L, "ПАПСКИЙ ПРЕСТОЛ (ГОСУДАРСТВО-ГОРОД ВАТИКАН)", "ВАТИКАН" },
                    { 37, "HU", "HUN", 348L, "ВЕНГЕРСКАЯ РЕСПУБЛИКА", "ВЕНГРИЯ" },
                    { 38, "VE", "VEN", 862L, "БОЛИВАРИЙСКАЯ РЕСПУБЛИКА ВЕНЕСУЭЛА", "ВЕНЕСУЭЛА" },
                    { 39, "VI", "VIR", 850L, "ВИРГИНСКИЕ ОСТРОВА (США)", "ВИРГИН. О-ВА" },
                    { 40, "VG", "VGB", 92L, "БРИТАНСКИЕ ВИРГИНСКИЕ ОСТРОВА", "ВИРГИН. О-ВА, БРИТАНСКИЕ" },
                    { 41, "AS", "ASM", 16L, "АМЕРИКАНСКОЕ САМОА (США)", "ВОСТОЧНОЕ САМОА" },
                    { 42, "VN", "VNM", 704L, "СОЦИАЛИСТИЧЕСКАЯ РЕСПУБЛИКА ВЬЕТНАМ", "ВЬЕТНАМ" },
                    { 43, "GA", "GAB", 266L, "ГАБОНСКАЯ РЕСПУБЛИКА", "ГАБОН" },
                    { 44, "HT", "HTI", 332L, "РЕСПУБЛИКА ГАИТИ", "ГАИТИ" },
                    { 45, "GY", "GUY", 328L, "РЕСПУБЛИКА ГАЙАНА", "ГАЙАНА" },
                    { 46, "GM", "GMB", 270L, "РЕСПУБЛИКА ГАМБИЯ", "ГАМБИЯ" },
                    { 47, "GH", "GHA", 288L, "РЕСПУБЛИКА ГАНА", "ГАНА" },
                    { 48, "GP", "GLP", 312L, "ГВАДЕЛУПА (ФР.)", "ГВАДЕЛУПА" },
                    { 49, "GT", "GTM", 320L, "РЕСПУБЛИКА ГВАТЕМАЛА", "ГВАТЕМАЛА" },
                    { 50, "GF", "GUF", 254L, "ФРАНЦУЗСКАЯ ГВИАНА (ФР.)", "ГВИАНА" },
                    { 51, "GN", "GIN", 324L, "ГВИНЕЙСКАЯ РЕСПУБЛИКА", "ГВИНЕЯ" },
                    { 52, "GW", "GNB", 624L, "РЕСПУБЛИКА ГВИНЕЯ-БИСАУ", "ГВИНЕЯ-БИСАУ" },
                    { 53, "DE", "DEU", 276L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА ГЕРМАНИЯ", "ГЕРМАНИЯ" },
                    { 54, "GG", "GGY", 831L, "ГЕРНСИ", "ГЕРНСИ" },
                    { 55, "GI", "GIB", 292L, "ГИБРАЛТАР (БРИТ.)", "ГИБРАЛТАР" },
                    { 56, "HN", "HND", 340L, "РЕСПУБЛИКА ГОНДУРАС", "ГОНДУРАС" },
                    { 57, "HK", "HKG", 344L, "СПЕЦИАЛЬНЫЙ АДМИНИСТРАТИВНЫЙ РЕГИОН КИТАЯ ГОНКОНГ", "ГОНКОНГ" },
                    { 58, "GD", "GRD", 308L, "ГРЕНАДА", "ГРЕНАДА" },
                    { 59, "GL", "GRL", 304L, "ГРЕНЛАНДИЯ", "ГРЕНЛАНДИЯ" },
                    { 60, "GR", "GRC", 300L, "ГРЕЧЕСКАЯ РЕСПУБЛИКА", "ГРЕЦИЯ" },
                    { 61, "GE", "GEO", 268L, "РЕСПУБЛИКА ГРУЗИЯ", "ГРУЗИЯ" },
                    { 62, "GU", "GUM", 316L, "ГУАМ (США)", "ГУАМ" },
                    { 63, "DK", "DNK", 208L, "КОРОЛЕВСТВО ДАНИЯ", "ДАНИЯ" },
                    { 64, "JE", "JEY", 832L, "ДЖЕРСИ", "ДЖЕРСИ" },
                    { 65, "DJ", "DJI", 262L, "РЕСПУБЛИКА ДЖИБУТИ", "ДЖИБУТИ" },
                    { 66, "DM", "DMA", 212L, "СОДРУЖЕСТВО ДОМИНИКИ", "ДОМИНИКА" },
                    { 67, "DO", "DOM", 214L, "ДОМИНИКАНСКАЯ РЕСПУБЛИКА", "ДОМИНИКАНСКАЯ РЕСПУБЛИКА" },
                    { 68, "EG", "EGY", 818L, "АРАБСКАЯ РЕСПУБЛИКА ЕГИПЕТ (АРЕ)", "ЕГИПЕТ" },
                    { 69, "ZM", "ZMB", 894L, "РЕСПУБЛИКА ЗАМБИЯ", "ЗАМБИЯ" },
                    { 70, "EH", "ESH", 732L, "ЗАПАДНАЯ САХАРА", "ЗАПАДНАЯ САХАРА" },
                    { 71, "ZW", "ZWE", 716L, "РЕСПУБЛИКА ЗИМБАБВЕ", "ЗИМБАБВЕ" },
                    { 72, "IL", "ISR", 376L, "ГОСУДАРСТВО ИЗРАИЛЬ", "ИЗРАИЛЬ" },
                    { 73, "IN", "IND", 356L, "РЕСПУБЛИКА ИНДИЯ", "ИНДИЯ" },
                    { 74, "ID", "IDN", 360L, "РЕСПУБЛИКА ИНДОНЕЗИЯ", "ИНДОНЕЗИЯ" },
                    { 75, "JO", "JOR", 400L, "ИОРДАНСКОЕ ХАШИМИТСКОЕ КОРОЛЕВСТВО", "ИОРДАНИЯ" },
                    { 76, "IQ", "IRQ", 368L, "РЕСПУБЛИКА ИРАК", "ИРАК" },
                    { 77, "IR", "IRN", 364L, "ИСЛАМСКАЯ РЕСПУБЛИКА ИРАН", "ИРАН" },
                    { 78, "IE", "IRL", 372L, "ИРЛАНДИЯ", "ИРЛАНДИЯ" },
                    { 79, "IS", "ISL", 352L, "РЕСПУБЛИКА ИСЛАНДИЯ", "ИСЛАНДИЯ" },
                    { 80, "ES", "ESP", 724L, "КОРОЛЕВСТВО ИСПАНИЯ", "ИСПАНИЯ" },
                    { 81, "IT", "ITA", 380L, "ИТАЛЬЯНСКАЯ РЕСПУБЛИКА", "ИТАЛИЯ" },
                    { 82, "YE", "YEM", 887L, "ЙЕМЕНСКАЯ РЕСПУБЛИКА", "ЙЕМЕН" },
                    { 83, "CV", "CPV", 132L, "РЕСПУБЛИКА КАБО-ВЕРДЕ", "КАБО-ВЕРДЕ" },
                    { 84, "KZ", "KAZ", 398L, "РЕСПУБЛИКА КАЗАХСТАН", "КАЗАХСТАН" },
                    { 85, "KY", "CYM", 136L, "ОСТРОВА КАЙМАН", "КАЙМАН" },
                    { 86, "KH", "KHM", 116L, "КОРОЛЕВСТВО КАМБОДЖА", "КАМБОДЖА" },
                    { 87, "CM", "CMR", 120L, "РЕСПУБЛИКА КАМЕРУН", "КАМЕРУН" },
                    { 88, "CA", "CAN", 124L, "КАНАДА", "КАНАДА" },
                    { 89, "QA", "QAT", 634L, "ГОСУДАРСТВО КАТАР", "КАТАР" },
                    { 91, "KE", "KEN", 404L, "РЕСПУБЛИКА КЕНИЯ", "КЕНИЯ" },
                    { 92, "CY", "CYP", 196L, "РЕСПУБЛИКА КИПР", "КИПР" },
                    { 93, "KI", "KIR", 296L, "РЕСПУБЛИКА КИРИБАТИ", "КИРИБАТИ" },
                    { 94, "CN", "CHN", 156L, "КИТАЙСКАЯ НАРОДНАЯ РЕСПУБЛИКА (КНР)", "КИТАЙ" },
                    { 95, "CC", "CCK", 166L, "КОКОСОВЫЕ (КИЛИНГ) ОСТРОВА", "КОКОСОВЫЕ О-ВА" },
                    { 96, "CO", "COL", 170L, "РЕСПУБЛИКА КОЛУМБИЯ", "КОЛУМБИЯ" },
                    { 97, "KM", "COM", 174L, "СОЮЗ КОМОРЫ", "КОМОРЫ" },
                    { 98, "CG", "COG", 178L, "РЕСПУБЛИКА КОНГО", "КОНГО" },
                    { 99, "CD", "COD", 180L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА КОНГО", "КОНГО" },
                    { 100, "KR", "KOR", 410L, "РЕСПУБЛИКА КОРЕЯ", "КОРЕЯ" },
                    { 101, "KP", "PRK", 408L, "КОРЕЙСКАЯ НАРОДНО-ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "КОРЕЯ (КНДР)" },
                    { 102, "CR", "CRI", 188L, "РЕСПУБЛИКА КОСТА-РИКА", "КОСТА-РИКА" },
                    { 103, "CI", "CIV", 384L, "РЕСПУБЛИКА КОТ Д'ИВУАР'", "КОТ Д'ИВУАР'" },
                    { 104, "CU", "CUB", 192L, "РЕСПУБЛИКА КУБА", "КУБА" },
                    { 105, "KW", "KWT", 414L, "ГОСУДАРСТВО КУВЕЙТ", "КУВЕЙТ" },
                    { 106, "KG", "KGZ", 417L, "РЕСПУБЛИКА КЫРГЫЗСТАН", "КЫРГЫЗСТАН" },
                    { 107, "LA", "LAO", 418L, "ЛАОССКАЯ НАРОДНО-ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "ЛАОС" },
                    { 108, "LV", "LVA", 428L, "ЛАТВИЙСКАЯ РЕСПУБЛИКА", "ЛАТВИЯ" },
                    { 109, "LS", "LSO", 426L, "КОРОЛЕВСТВО ЛЕСОТО", "ЛЕСОТО" },
                    { 110, "LR", "LBR", 430L, "РЕСПУБЛИКА ЛИБЕРИЯ", "ЛИБЕРИЯ" },
                    { 111, "LB", "LBN", 422L, "ЛИВАНСКАЯ РЕСПУБЛИКА", "ЛИВАН" },
                    { 112, "LY", "LBY", 434L, "СОЦИАЛИСТИЧЕСКАЯ НАРОДНАЯ ЛИВИЙСКАЯ АРАБСКАЯ ДЖАМАХИРИЯ", "ЛИВИЯ" },
                    { 113, "LT", "LTU", 440L, "ЛИТОВСКАЯ РЕСПУБЛИКА", "ЛИТВА" },
                    { 114, "LI", "LIE", 438L, "КНЯЖЕСТВО ЛИХТЕНШТЕЙН", "ЛИХТЕНШТЕЙН" },
                    { 115, "LU", "LUX", 442L, "ВЕЛИКОЕ ГЕРЦОГСТВО ЛЮКСЕМБУРГ", "ЛЮКСЕМБУРГ" },
                    { 116, "MU", "MUS", 480L, "РЕСПУБЛИКА МАВРИКИЙ", "МАВРИКИЙ" },
                    { 117, "MR", "MRT", 478L, "ИСЛАМСКАЯ РЕСПУБЛИКА МАВРИТАНИЯ", "МАВРИТАНИЯ" },
                    { 118, "MG", "MDG", 450L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА МАДАГАСКАР", "МАДАГАСКАР" },
                    { 119, "YT", "MYT", 175L, "МАЙОТТА", "МАЙОТТА" },
                    { 120, "MO", "MAC", 446L, "СПЕЦИАЛЬНЫЙ АДМИНИСТРАТИВНЫЙ РЕГИОН КИТАЯ МАКАО", "МАКАО" },
                    { 121, "MK", "MKD", 807L, "РЕСПУБЛИКА МАКЕДОНИЯ", "МАКЕДОНИЯ" },
                    { 122, "MW", "MWI", 454L, "РЕСПУБЛИКА МАЛАВИ", "МАЛАВИ" },
                    { 123, "MY", "MYS", 458L, "МАЛАЙЗИЯ", "МАЛАЙЗИЯ" },
                    { 124, "ML", "MLI", 466L, "РЕСПУБЛИКА МАЛИ", "МАЛИ" },
                    { 125, "UM", "UMI", 581L, "МАЛЫЕ ТИХООКЕАНСКИЕ ОТДАЛЕННЫЕ ОСТРОВА (США)", "МАЛЫЕ ТИХООК. ОСТРОВА (США)" },
                    { 126, "MV", "MDV", 462L, "МАЛЬДИВСКАЯ РЕСПУБЛИКА", "МАЛЬДИВЫ" },
                    { 127, "MT", "MLT", 470L, "РЕСПУБЛИКА МАЛЬТА", "МАЛЬТА" },
                    { 128, "MP", "MNP", 580L, "СОДРУЖЕСТВО СЕВЕРНЫХ МАРИАНСКИХ ОСТРОВОВ", "МАРИАНСКИЕ ОСТРОВА" },
                    { 129, "MA", "MAR", 504L, "КОРОЛЕВСТВО МАРОККО", "МАРОККО" },
                    { 130, "MQ", "MTQ", 474L, "МАРТИНИКА (ФР.)", "МАРТИНИКА" },
                    { 131, "MH", "MHL", 584L, "РЕСПУБЛИКА МАРШАЛЛОВЫ ОСТРОВА", "МАРШАЛЛОВЫ ОСТРОВА" },
                    { 132, "MX", "MEX", 484L, "МЕКСИКАНСКИЕ СОЕДИНЕННЫЕ ШТАТЫ", "МЕКСИКА" },
                    { 133, "FM", "FSM", 583L, "ФЕДЕРАТИВНЫЕ ШТАТЫ МИКРОНЕЗИИ", "МИКРОНЕЗИЯ" },
                    { 134, "MZ", "MOZ", 508L, "РЕСПУБЛИКА МОЗАМБИК", "МОЗАМБИК" },
                    { 135, "MD", "MDA", 498L, "РЕСПУБЛИКА МОЛДОВА", "МОЛДОВА" },
                    { 136, "MC", "MCO", 492L, "КНЯЖЕСТВО МОНАКО", "МОНАКО" },
                    { 137, "MN", "MHG", 496L, "МОНГОЛИЯ", "МОНГОЛИЯ" },
                    { 138, "MS", "MSR", 500L, "МОНТСЕРРАТ (БРИТ.)", "МОНТСЕРРАТ" },
                    { 139, "MM", "MMR", 104L, "СОЮЗ МЬЯНМА", "МЬЯНМА" },
                    { 140, "NA", "NAM", 516L, "РЕСПУБЛИКА НАМИБИЯ", "НАМИБИЯ" },
                    { 141, "NR", "NRU", 520L, "РЕСПУБЛИКА НАУРУ", "НАУРУ" },
                    { 142, "NP", "NPL", 524L, "КОРОЛЕВСТВО НЕПАЛ", "НЕПАЛ" },
                    { 143, "NE", "NER", 562L, "РЕСПУБЛИКА НИГЕР", "НИГЕР" },
                    { 144, "NG", "NGA", 566L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА НИГЕРИЯ", "НИГЕРИЯ" },
                    { 145, "AN", "ANT", 530L, "НИДЕРЛАНДСКИЕ АНТИЛЫ", "НИДЕРЛАНДСКИЕ АНТИЛЫ" },
                    { 146, "NL", "NLD", 528L, "КОРОЛЕВСТВО НИДЕРЛАНДЫ", "НИДЕРЛАНДЫ" },
                    { 147, "NI", "NIC", 558L, "РЕСПУБЛИКА НИКАРАГУА", "НИКАРАГУА" },
                    { 148, "NU", "NIU", 570L, "РЕСПУБЛИКА НИУЭ", "НИУЭ" },
                    { 149, "NZ", "NZL", 554L, "НОВАЯ ЗЕЛАНДИЯ", "НОВАЯ ЗЕЛАНДИЯ" },
                    { 150, "NC", "NCL", 540L, "НОВАЯ КАЛЕДОНИЯ", "НОВАЯ КАЛЕДОНИЯ" },
                    { 151, "NO", "NOR", 578L, "КОРОЛЕВСТВО НОРВЕГИЯ", "НОРВЕГИЯ" },
                    { 152, "NF", "NFK", 574L, "ОСТРОВ НОРФОЛК", "НОРФОЛК" },
                    { 153, "AE", "ARE", 784L, "ОБЪЕДИНЕННЫЕ АРАБСКИЕ ЭМИРАТЫ", "ОБЪЕД. АРАБСКИЕ ЭМИРАТЫ" },
                    { 154, "IM", "IMY", 833L, "ОСТРОВ МЭН", "О-В МЭН" },
                    { 155, "CX", "CXR", 162L, "ОСТРОВ РОЖДЕСТВА (АВСТРАЛ.)", "О-В РОЖДЕСТВА" },
                    { 156, "СК", "COK", 184L, "ОСТРОВА КУКА (Н. ЗЕЛ.)", "О-ВА КУКА" },
                    { 157, "OM", "OMN", 512L, "СУЛТАНАТ ОМАН", "ОМАН" },
                    { 158, "PK", "PAK", 586L, "ИСЛАМСКАЯ РЕСПУБЛИКА ПАКИСТАН", "ПАКИСТАН" },
                    { 159, "PW", "PLW", 585L, "РЕСПУБЛИКА ПАЛАУ", "ПАЛАУ" },
                    { 160, "PS", "PSE", 275L, "ОККУПИРОВАННАЯ ПАЛЕСТИНСКАЯ ТЕРРИТОРИЯ", "ПАЛЕСТИНСКАЯ ТЕРРИТОРИЯ, ОККУПИРОВАННАЯ" },
                    { 161, "PA", "PAN", 591L, "РЕСПУБЛИКА ПАНАМА", "ПАНАМА" },
                    { 162, "PG", "PNG", 598L, "ПАПУА - НОВАЯ ГВИНЕЯ", "ПАПУА - НОВАЯ ГВИНЕЯ" },
                    { 163, "PY", "PRY", 600L, "РЕСПУБЛИКА ПАРАГВАЙ", "ПАРАГВАЙ" },
                    { 164, "PE", "PER", 604L, "РЕСПУБЛИКА ПЕРУ", "ПЕРУ" },
                    { 165, "PN", "PCN", 612L, "ПИТКЭРН (БРИТ.)", "ПИТКЭРН" },
                    { 166, "PL", "POL", 616L, "РЕСПУБЛИКА ПОЛЬША", "ПОЛЬША" },
                    { 167, "PT", "PRT", 620L, "ПОРТУГАЛЬСКАЯ РЕСПУБЛИКА", "ПОРТУГАЛИЯ" },
                    { 168, "PR", "PRI", 630L, "ПУЭРТО-РИКО", "ПУЭРТО-РИКО" },
                    { 169, "RE", "REU", 638L, "РЕЮНЬОН", "РЕЮНЬОН" },
                    { 170, "RU", "RUS", 643L, "РОССИЙСКАЯ ФЕДЕРАЦИЯ", "РОССИЯ" },
                    { 171, "RW", "RWA", 646L, "РУАНДИЙСКАЯ РЕСПУБЛИКА", "РУАНДА" },
                    { 172, "RO", "ROM", 642L, "РУМЫНИЯ", "РУМЫНИЯ" },
                    { 173, "WS", "WSM", 882L, "НЕЗАВИСИМОЕ ГОСУДАРСТВО САМОА", "САМОА" },
                    { 174, "ST", "STR", 678L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА САН-ТОМЕ И ПРИНСИПИ", "САН-ТОМЕ И ПРИНСИПИ" },
                    { 175, "SM", "SMR", 674L, "РЕСПУБЛИКА САН-МАРИНО", "САН-МАРИНО" },
                    { 176, "SA", "SAU", 682L, "КОРОЛЕВСТВО САУДОВСКАЯ АРАВИЯ", "САУДОВСКАЯ АРАВИЯ" },
                    { 177, "SZ", "SWZ", 748L, "КОРОЛЕВСТВО СВАЗИЛЕНД", "СВАЗИЛЕНД" },
                    { 178, "SH", "SHN", 654L, "ОСТРОВ СВЯТОЙ ЕЛЕНЫ (БРИТ.)", "СВЯТАЯ ЕЛЕНА" },
                    { 179, "SC", "SYC", 690L, "РЕСПУБЛИКА СЕЙШЕЛЫ", "СЕЙШЕЛЫ" },
                    { 180, "PM", "SPM", 666L, "СЕН-ПЬЕР И МИКЕЛОН (ФР.)", "СЕН-ПЬЕР И МИКЕЛОН" },
                    { 181, "SN", "SEN", 686L, "РЕСПУБЛИКА СЕНЕГАЛ", "СЕНЕГАЛ" },
                    { 182, "VC", "VCT", 670L, "СЕНТ-ВИНСЕНТ И ГРЕНАДИНЫ", "СЕНТ-ВИНСЕНТ И ГРЕНАДИНЫ" },
                    { 183, "KN", "KNA", 659L, "ФЕДЕРАЦИЯ СЕНТ-КИТС (СЕНТ-КРИСТОФЕР) И НЕВИС", "СЕНТ-КИТС И НЕВИС" },
                    { 184, "LC", "LCA", 662L, "СЕНТ-ЛЮСИЯ", "СЕНТ-ЛЮСИЯ" },
                    { 185, "RS", "SRB", 688L, "РЕСПУБЛИКА СЕРБИЯ", "СЕРБИЯ" },
                    { 186, "SG", "SGP", 702L, "РЕСПУБЛИКА СИНГАПУР", "СИНГАПУР" },
                    { 187, "SY", "SYR", 760L, "СИРИЙСКАЯ АРАБСКАЯ РЕСПУБЛИКА", "СИРИЯ" },
                    { 188, "SK", "SVK", 703L, "СЛОВАЦКАЯ РЕСПУБЛИКА", "СЛОВАКИЯ" },
                    { 189, "SI", "SVN", 705L, "РЕСПУБЛИКА СЛОВЕНИЯ", "СЛОВЕНИЯ" },
                    { 190, "GB", "GBR", 826L, "СОЕДИНЕННОЕ КОРОЛЕВСТВО ВЕЛИКОБРИТАНИИ И СЕВЕРНОЙ ИРЛАНДИИ", "СОЕДИНЕННОЕ КОРОЛЕВСТВО" },
                    { 191, "SB", "SLB", 90L, "СОЛОМОНОВЫ ОСТРОВА", "СОЛОМОНОВЫ О-ВА" },
                    { 192, "SO", "SOM", 706L, "СОМАЛИЙСКАЯ РЕСПУБЛИКА", "СОМАЛИ" },
                    { 193, "SD", "SDN", 736L, "РЕСПУБЛИКА СУДАН", "СУДАН" },
                    { 194, "SR", "SUR", 740L, "РЕСПУБЛИКА СУРИНАМ", "СУРИНАМ" },
                    { 195, "US", "USA", 840L, "СОЕДИНЕННЫЕ ШТАТЫ АМЕРИКИ", "США" },
                    { 196, "SL", "SLE", 694L, "РЕСПУБЛИКА СЬЕРРА-ЛЕОНЕ", "СЬЕРРА-ЛЕОНЕ" },
                    { 197, "TJ", "TJK", 762L, "РЕСПУБЛИКА ТАДЖИКИСТАН", "ТАДЖИКИСТАН" },
                    { 198, "TH", "THA", 764L, "КОРОЛЕВСТВО ТАИЛАНД", "ТАИЛАНД" },
                    { 199, "TW", "TWN", 158L, "ТАЙВАНЬ (В СОСТАВЕ КИТАЯ)", "ТАЙВАНЬ" },
                    { 200, "TZ", "TZA", 834L, "ОБЪЕДИНЕННАЯ РЕСПУБЛИКА ТАНЗАНИЯ (ОРТ)", "ТАНЗАНИЯ" },
                    { 201, "TC", "TCA", 796L, "ОСТРОВА ТЕРКС И КАЙКОС (БРИТ.)", "ТЕРКС И КАЙКОС" },
                    { 202, "TP", "TMP", 626L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА ТИМОР-ЛЕСТЕ", "ТИМОР-ЛЕСТЕ" },
                    { 203, "TG", "TGO", 768L, "ТОГОЛЕЗСКАЯ РЕСПУБЛИКА", "ТОГО" },
                    { 204, "TK", "TKL", 772L, "ТОКЕЛАУ (ЮНИОН) (Н. ЗЕЛ.)", "ТОКЕЛАУ" },
                    { 205, "TO", "TON", 776L, "КОРОЛЕВСТВО ТОНГА", "ТОНГА" },
                    { 206, "TT", "TTO", 780L, "РЕСПУБЛИКА ТРИНИДАД И ТОБАГО", "ТРИНИДАД И ТОБАГО" },
                    { 207, "TV", "TUV", 798L, "ТУВАЛУ", "ТУВАЛУ" },
                    { 208, "TN", "TUN", 788L, "ТУНИССКАЯ РЕСПУБЛИКА", "ТУНИС" },
                    { 209, "TM", "TKM", 795L, "ТУРКМЕНИСТАН", "ТУРКМЕНИЯ" },
                    { 210, "TR", "TUR", 792L, "ТУРЕЦКАЯ РЕСПУБЛИКА", "ТУРЦИЯ" },
                    { 211, "UG", "UGA", 800L, "РЕСПУБЛИКА УГАНДА", "УГАНДА" },
                    { 212, "UZ", "UZB", 860L, "РЕСПУБЛИКА УЗБЕКИСТАН", "УЗБЕКИСТАН" },
                    { 213, "UA", "UKR", 804L, "УКРАИНА", "УКРАИНА" },
                    { 214, "WF", "WLF", 876L, "ОСТРОВА УОЛЛИС И ФУТУНА", "УОЛЛИС И ФУТУНА" },
                    { 215, "UY", "URY", 858L, "ВОСТОЧНАЯ РЕСПУБЛИКА УРУГВАЙ", "УРУГВАЙ" },
                    { 216, "FO", "FRO", 234L, "ФАРЕРСКИЕ ОСТРОВА (В СОСТАВЕ ДАНИИ)", "ФАРЕРСКИЕ О-ВА" },
                    { 217, "FJ", "FJI", 242L, "РЕСПУБЛИКА ОСТРОВОВ ФИДЖИ", "ФИДЖИ" },
                    { 218, "PH", "PHL", 608L, "РЕСПУБЛИКА ФИЛИППИНЫ", "ФИЛИППИНЫ" },
                    { 219, "FI", "FIN", 246L, "ФИНЛЯНДСКАЯ РЕСПУБЛИКА", "ФИНЛЯНДИЯ" },
                    { 220, "FK", "FLK", 238L, "ФОЛКЛЕНДСКИЕ ОСТРОВА (МАЛЬВИНСКИЕ)", "ФОЛКЛЕНДСКИЕ О-ВА" },
                    { 221, "TF", "ATF", 260L, "ФРАНЦУЗСКИЕ ЮЖНЫЕ ТЕРРИТОРИИ (ФР.)", "ФР. ЮЖНЫЕ ТЕРРИТОРИИ" },
                    { 222, "FR", "FRA", 250L, "ФРАНЦУЗСКАЯ РЕСПУБЛИКА", "ФРАНЦИЯ" },
                    { 223, "PF", "PYF", 258L, "ФРАНЦУЗСКАЯ ПОЛИНЕЗИЯ (ФР.)", "ФРАНЦУЗСКАЯ ПОЛИНЕЗИЯ" },
                    { 224, "HM", "HMD", 334L, "ОСТРОВ ХЕРД И ОСТРОВА МАКДОНАЛЬД", "ХЕРД И МАКДОНАЛЬД" },
                    { 225, "HR", "HRV", 191L, "РЕСПУБЛИКА ХОРВАТИЯ", "ХОРВАТИЯ" },
                    { 226, "CF", "CAF", 140L, "ЦЕНТРАЛЬНО-АФРИКАНСКАЯ РЕСПУБЛИКА (ЦАР)", "ЦЕНТР. - АФР. РЕСПУБЛИКА" },
                    { 227, "TD", "TCD", 148L, "РЕСПУБЛИКА ЧАД", "ЧАД" },
                    { 228, "ME", "MNE", 499L, "РЕСПУБЛИКА ЧЕРНОГОРИЯ", "ЧЕРНОГОРИЯ" },
                    { 229, "CZ", "CZE", 203L, "ЧЕШСКАЯ РЕСПУБЛИКА", "ЧЕХИЯ" },
                    { 230, "CL", "CHL", 152L, "РЕСПУБЛИКА ЧИЛИ", "ЧИЛИ" },
                    { 231, "CH", "CHE", 756L, "ШВЕЙЦАРСКАЯ КОНФЕДЕРАЦИЯ", "ШВЕЙЦАРИЯ" },
                    { 232, "SE", "SWE", 752L, "КОРОЛЕВСТВО ШВЕЦИЯ", "ШВЕЦИЯ" },
                    { 233, "SJ", "SJM", 744L, "ШПИЦБЕРГЕН И ЯН-МАЙЕН (НОРВ.)", "ШПИЦБЕРГЕН И ЯН-МАЙЕН" },
                    { 234, "LK", "LKA", 144L, "ДЕМОКРАТИЧЕСКАЯ СОЦИАЛИСТИЧЕСКАЯ РЕСПУБЛИКА ШРИ-ЛАНКА", "ШРИ-ЛАНКА" },
                    { 235, "EC", "ECU", 218L, "РЕСПУБЛИКА ЭКВАДОР", "ЭКВАДОР" },
                    { 236, "GQ", "GNQ", 226L, "РЕСПУБЛИКА ЭКВАТОРИАЛЬНАЯ ГВИНЕЯ", "ЭКВАТОРИАЛЬНАЯ ГВИНЕЯ" },
                    { 237, "AX", "ALA", 248L, "ЭЛАНДСКИЕ ОСТРОВА", "ЭЛАНДСКИЕ ОСТРОВА" },
                    { 238, "SV", "SLV", 222L, "РЕСПУБЛИКА ЭЛ-САЛЬВАДОР", "ЭЛЬ-САЛЬВАДОР" },
                    { 239, "ER", "ERI", 232L, "ЭРИТРЕЯ", "ЭРИТРЕЯ" },
                    { 240, "EE", "EST", 233L, "ЭСТОНСКАЯ РЕСПУБЛИКА", "ЭСТОНИЯ" },
                    { 241, "ET", "ETH", 231L, "ФЕДЕРАТИВНАЯ ДЕМОКРАТИЧЕСКАЯ  РЕСПУБЛИКА ЭФИОПИЯ", "ЭФИОПИЯ" },
                    { 242, "ZA", "ZAF", 710L, "ЮЖНО-АФРИКАНСКАЯ РЕСПУБЛИКА", "ЮЖНАЯ АФРИКА" },
                    { 243, "GS", "SGS", 239L, "ЮЖНАЯ ДЖОРДЖИЯ И ЮЖНЫЕ САНДВИЧЕВЫ ОСТРОВА", "ЮЖНАЯ ДЖОРДЖИЯ И ЮЖНЫЕ САНДВИЧЕВЫ ОСТРОВА" },
                    { 244, "JM", "JAM", 388L, "ЯМАЙКА", "ЯМАЙКА" },
                    { 245, "JP", "JPN", 392L, "ЯПОНИЯ", "ЯПОНИЯ" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Code", "ImageId", "Name" },
                values: new object[,]
                {
                    { 1, "windows", null, "Windows" },
                    { 2, "apple", null, "Apple" }
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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGame_GamesId",
                table: "CategoryGame",
                column: "GamesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryId",
                table: "Companies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatform_PlatformsId",
                table: "GamePlatform",
                column: "PlatformsId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CompanyDeveloperId",
                table: "Games",
                column: "CompanyDeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_StaticFileId",
                table: "Games",
                column: "StaticFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_ImageId",
                table: "Platforms",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticFiles_GameId",
                table: "StaticFiles",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CountryId",
                table: "UserProfiles",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_IdentityUserId",
                table: "UserProfiles",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryGame_Games_GamesId",
                table: "CategoryGame",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GamesId",
                table: "GamePlatform",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsId",
                table: "GamePlatform",
                column: "PlatformsId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_StaticFiles_StaticFileId",
                table: "Games",
                column: "StaticFileId",
                principalTable: "StaticFiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaticFiles_Games_GameId",
                table: "StaticFiles");

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
                name: "CategoryGame");

            migrationBuilder.DropTable(
                name: "GamePlatform");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "StaticFiles");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

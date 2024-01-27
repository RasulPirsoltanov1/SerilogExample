using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serilog.DataAccess.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Geyim", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastik Polad Avtomobil" },
                    { 2, "oyunlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Kobud Polad Avtomobil" },
                    { 3, "oyunlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomik Qranit Sviter" },
                    { 4, "gözəllik", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İntellektual Rezin Kulon" },
                    { 5, "Kompyuterlər", "The Football Is Good For Training And Recreational Purposes", "Balaca Beton Sviter" },
                    { 6, "Geyim", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Mükəmməl Rezin Kompyuter" },
                    { 7, "bəzək", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "İnanılmaz Qranit Avtomobil" },
                    { 8, "uşaq üçün", "The Football Is Good For Training And Recreational Purposes", "Mükəmməl Qranit Sviter" },
                    { 9, "Filmlər", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomik Beton Kompyuter" },
                    { 10, "Avtomobil", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Möhtəşəm Pambıq Stul" },
                    { 11, "садинструмент", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Parlaq Beton Kulon" },
                    { 12, "Kompyuterlər", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Balaca Plastik Avtomobil" },
                    { 13, "İdman", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Pambıq Kompyuter" },
                    { 14, "Ayyaqqabı", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Parlaq Qranit Kompyuter" },
                    { 15, "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomik Rezin Stol" },
                    { 16, "Kitablar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Möhtəşəm Polad Stol" },
                    { 17, "oyunlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Balaca Rezin Beret" },
                    { 18, "oyunlar", "The Football Is Good For Training And Recreational Purposes", "Möhtəşəm Pambıq Kulon" },
                    { 19, "Səhiyyə", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Əlverişli Polad Kompyuter" },
                    { 20, "Geyim", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastik Ağac Sviter" },
                    { 21, "gözəllik", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Parlaq Plastik Stul" },
                    { 22, "Avtomobil", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Mükəmməl Pambıq Kompyuter" },
                    { 23, "musiqi", "The Football Is Good For Training And Recreational Purposes", "Balaca Polad Stul" },
                    { 24, "oyunlar", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Kobud Plastik Stul" },
                    { 25, "Elektronika", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Qranit Kulon" },
                    { 26, "Elektronika", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Beton Kulon" },
                    { 27, "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "İnanılmaz Beton Kulon" },
                    { 28, "gözəllik", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Polad Stul" },
                    { 29, "uşaq üçün", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "İntellektual Polad Avtomobil" },
                    { 30, "bəzək", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Plastik Sviter" },
                    { 31, "Geyim", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Balaca Beton Kulon" },
                    { 32, "Filmlər", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "İnanılmaz Pambıq Stol" },
                    { 33, "Avtomobil", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "İnanılmaz Polad Beret" },
                    { 34, "Kitablar", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomik Qranit Stul" },
                    { 35, "Oyuncaqlar", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Polad Kompyuter" },
                    { 36, "Ayyaqqabı", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Balaca Polad Kəmər" },
                    { 37, "Filmlər", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Möhtəşəm Beton Avtomobil" },
                    { 38, "садинструмент", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Kobud Pambıq Kompyuter" },
                    { 39, "Filmlər", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Rezin Avtomobil" },
                    { 40, "uşaq üçün", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Polad Kəmər" },
                    { 41, "Oyuncaqlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Möhtəşəm Pambıq Beret" },
                    { 42, "Filmlər", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Kobud Qranit Sviter" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 43, "Geyim", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Plastik Stol" },
                    { 44, "Filmlər", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomik Rezin Stol" },
                    { 45, "musiqi", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastik Plastik Kəmər" },
                    { 46, "İdman", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Mükəmməl Polad Avtomobil" },
                    { 47, "turizm", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Parlaq Polad Stol" },
                    { 48, "Kitablar", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastik Rezin Kulon" },
                    { 49, "Ev", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "İnanılmaz Qranit Kulon" },
                    { 50, "musiqi", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "İnanılmaz Qranit Beret" },
                    { 51, "Avtomobil", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Balaca Rezin Kulon" },
                    { 52, "Kompyuterlər", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Əlverişli Qranit Kəmər" },
                    { 53, "uşaq üçün", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Möhtəşəm Rezin Sviter" },
                    { 54, "Avtomobil", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Parlaq Qranit Stol" },
                    { 55, "Səhiyyə", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Parlaq Beton Avtomobil" },
                    { 56, "İdman", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Əlverişli Polad Avtomobil" },
                    { 57, "Avtomobil", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomik Rezin Kulon" },
                    { 58, "uşaq üçün", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Balaca Qranit Kulon" },
                    { 59, "Səhiyyə", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomik Plastik Kulon" },
                    { 60, "Filmlər", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Kobud Pambıq Sviter" },
                    { 61, "bəzək", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Əlverişli Plastik Kəmər" },
                    { 62, "gözəllik", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Parlaq Pambıq Stol" },
                    { 63, "gözəllik", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomik Plastik Stol" },
                    { 64, "садинструмент", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Balaca Pambıq Avtomobil" },
                    { 65, "Kitablar", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Ağac Avtomobil" },
                    { 66, "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Parlaq Ağac Kəmər" },
                    { 67, "bəzək", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Pambıq Kəmər" },
                    { 68, "Kitablar", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Plastik Kəmər" },
                    { 69, "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Möhtəşəm Rezin Stol" },
                    { 70, "turizm", "The Football Is Good For Training And Recreational Purposes", "Ergonomik Plastik Beret" },
                    { 71, "Kompyuterlər", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Mükəmməl Polad Stul" },
                    { 72, "turizm", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Rezin Sviter" },
                    { 73, "turizm", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "İntellektual Beton Sviter" },
                    { 74, "İdman", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Əlverişli Plastik Stol" },
                    { 75, "bəzək", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Möhtəşəm Rezin Sviter" },
                    { 76, "Səhiyyə", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Mükəmməl Plastik Kulon" },
                    { 77, "gözəllik", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İnanılmaz Ağac Stul" },
                    { 78, "turizm", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Parlaq Qranit Stol" },
                    { 79, "musiqi", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Plastik Avtomobil" },
                    { 80, "садинструмент", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Əlverişli Rezin Stul" },
                    { 81, "Elektronika", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomik Beton Stol" },
                    { 82, "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Balaca Beton Kulon" },
                    { 83, "Kitablar", "The Football Is Good For Training And Recreational Purposes", "İntellektual Rezin Kəmər" },
                    { 84, "Elektronika", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Rezin Beret" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 85, "Kompyuterlər", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Ağac Stol" },
                    { 86, "Səhiyyə", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İntellektual Pambıq Sviter" },
                    { 87, "musiqi", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Mükəmməl Polad Kəmər" },
                    { 88, "oyunlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Mükəmməl Ağac Avtomobil" },
                    { 89, "Ayyaqqabı", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "İnanılmaz Rezin Stol" },
                    { 90, "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Mükəmməl Rezin Stol" },
                    { 91, "Ev", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Kobud Pambıq Avtomobil" },
                    { 92, "Elektronika", "The Football Is Good For Training And Recreational Purposes", "Möhtəşəm Pambıq Stul" },
                    { 93, "gözəllik", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Mükəmməl Ağac Stol" },
                    { 94, "Ev", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Əlverişli Ağac Sviter" },
                    { 95, "İdman", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Mükəmməl Pambıq Beret" },
                    { 96, "Ayyaqqabı", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Möhtəşəm Beton Avtomobil" },
                    { 97, "Filmlər", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Mükəmməl Polad Kulon" },
                    { 98, "Ayyaqqabı", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Kobud Plastik Sviter" },
                    { 99, "садинструмент", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomik Ağac Kəmər" }
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

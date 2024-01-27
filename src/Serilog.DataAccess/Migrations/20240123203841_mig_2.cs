using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerilogExample.DataAccess.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/nightlife", "Parlaq Rezin Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/people", "Əlverişli Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/transport", "İnanılmaz Pambıq Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/animals", "Əlverişli Qranit Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/nightlife", "İntellektual Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/cats", "Fantastik Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/transport", "Ergonomik Rezin Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/sports", "Kobud Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Səhiyyə", "http://lorempixel.com/640/480/city", "Kobud Qranit Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/cats", "Əlverişli Qranit Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/cats", "İntellektual Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/cats", "Möhtəşəm Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/fashion", "İnanılmaz Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/fashion", "Kobud Plastik Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/sports", "Fantastik Beton Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/animals", "Balaca Pambıq Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/fashion", "Kobud Qranit Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/business", "Parlaq Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/city", "İnanılmaz Qranit Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/business", "İnanılmaz Ağac Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "садинструмент", "http://lorempixel.com/640/480/food", "Parlaq Qranit Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "http://lorempixel.com/640/480/nature", "İntellektual Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/technics", "Əlverişli Rezin Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/nature", "İntellektual Pambıq Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/abstract", "İnanılmaz Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "Image" },
                values: new object[] { "садинструмент", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/business" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "bəzək", "http://lorempixel.com/640/480/people", "İntellektual Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/transport", "Möhtəşəm Beton Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "İdman", "http://lorempixel.com/640/480/nature", "Parlaq Ağac Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/animals", "Fantastik Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/sports", "Fantastik Polad Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/people", "İnanılmaz Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/animals", "İntellektual Plastik Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/abstract", "Mükəmməl Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/nature", "Möhtəşəm Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/nature", "İnanılmaz Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/sports", "Ergonomik Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/technics", "İntellektual Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/sports", "Mükəmməl Beton Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/food", "Ergonomik Pambıq Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/cats", "Balaca Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "http://lorempixel.com/640/480/business", "Parlaq Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/fashion", "Möhtəşəm Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "http://lorempixel.com/640/480/nightlife", "Parlaq Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/transport", "Ergonomik Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/animals", "İntellektual Rezin Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/animals", "Möhtəşəm Polad Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Elektronika", "http://lorempixel.com/640/480/nightlife", "Əlverişli Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/people", "Əlverişli Ağac Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/abstract", "Fantastik Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/transport", "Əlverişli Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/technics", "İntellektual Beton Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/animals", "Parlaq Qranit Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/food", "İnanılmaz Polad Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/abstract", "Ergonomik Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/nature", "Əlverişli Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/cats", "Parlaq Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/food", "Parlaq Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/cats", "İntellektual Beton Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/fashion", "Fantastik Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/nightlife", "Parlaq Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/sports", "İntellektual Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Image", "Name" },
                values: new object[] { "http://lorempixel.com/640/480/nature", "Balaca Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/people", "Fantastik Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/abstract", "Ergonomik Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/business", "Parlaq Beton Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/nightlife", "Ergonomik Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/city", "Fantastik Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/food", "Mükəmməl Qranit Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "gözəllik", "http://lorempixel.com/640/480/animals", "Kobud Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/transport", "Balaca Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Filmlər", "http://lorempixel.com/640/480/sports", "İnanılmaz Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/city", "Əlverişli Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/people", "Mükəmməl Beton Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "http://lorempixel.com/640/480/abstract", "İnanılmaz Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/fashion", "Balaca Rezin Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/fashion", "Fantastik Rezin Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/abstract", "Balaca Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "http://lorempixel.com/640/480/abstract", "İntellektual Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/nature", "Ergonomik Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "http://lorempixel.com/640/480/fashion", "İntellektual Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Kitablar", "http://lorempixel.com/640/480/sports", "Fantastik Beton Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "gözəllik", "http://lorempixel.com/640/480/city", "Əlverişli Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/fashion", "İntellektual Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "http://lorempixel.com/640/480/nightlife", "Kobud Polad Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/sports", "İntellektual Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/nature", "Balaca Qranit Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/sports", "İntellektual Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "http://lorempixel.com/640/480/food", "Fantastik Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/city", "Mükəmməl Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/abstract", "İnanılmaz Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Avtomobil", "http://lorempixel.com/640/480/food", "Əlverişli Rezin Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/sports", "Kobud Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/cats", "Möhtəşəm Polad Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/animals", "Balaca Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/animals", "Mükəmməl Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "uşaq üçün", "http://lorempixel.com/640/480/nature", "Balaca Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/people", "Balaca Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/cats", "Möhtəşəm Plastik Kulon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastik Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "oyunlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Kobud Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "oyunlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomik Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "gözəllik", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İntellektual Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kompyuterlər", "The Football Is Good For Training And Recreational Purposes", "Balaca Beton Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Geyim", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Mükəmməl Rezin Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "bəzək", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "İnanılmaz Qranit Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "Mükəmməl Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Filmlər", "Ergonomik Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Möhtəşəm Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Parlaq Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kompyuterlər", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Balaca Plastik Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "İdman", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Pambıq Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ayyaqqabı", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Parlaq Qranit Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomik Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kitablar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Möhtəşəm Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "oyunlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Balaca Rezin Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "oyunlar", "The Football Is Good For Training And Recreational Purposes", "Möhtəşəm Pambıq Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Səhiyyə", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Əlverişli Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Geyim", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastik Ağac Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Name" },
                values: new object[] { "gözəllik", "Parlaq Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Mükəmməl Pambıq Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "musiqi", "The Football Is Good For Training And Recreational Purposes", "Balaca Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "oyunlar", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Kobud Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Elektronika", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Qranit Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description" },
                values: new object[] { "Elektronika", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Səhiyyə", "İnanılmaz Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "gözəllik", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Name" },
                values: new object[] { "uşaq üçün", "İntellektual Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "bəzək", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Geyim", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Balaca Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Filmlər", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "İnanılmaz Pambıq Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "İnanılmaz Polad Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kitablar", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomik Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Oyuncaqlar", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ayyaqqabı", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Balaca Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Filmlər", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Möhtəşəm Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Kobud Pambıq Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Filmlər", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "İntellektual Rezin Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "uşaq üçün", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Oyuncaqlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Möhtəşəm Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Filmlər", "Kobud Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Geyim", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "İnanılmaz Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Filmlər", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomik Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "musiqi", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastik Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "İdman", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Mükəmməl Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "turizm", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Parlaq Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Kitablar", "Fantastik Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ev", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "İnanılmaz Qranit Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "musiqi", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "İnanılmaz Qranit Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Balaca Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kompyuterlər", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Əlverişli Qranit Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "uşaq üçün", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Möhtəşəm Rezin Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Parlaq Qranit Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Səhiyyə", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Parlaq Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Əlverişli Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Avtomobil", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomik Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "uşaq üçün", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Balaca Qranit Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Səhiyyə", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomik Plastik Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Filmlər", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Kobud Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "bəzək", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Əlverişli Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "gözəllik", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Parlaq Pambıq Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Ergonomik Plastik Stol");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Balaca Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kitablar", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Parlaq Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "bəzək", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomik Pambıq Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kitablar", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Möhtəşəm Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Name" },
                values: new object[] { "turizm", "Ergonomik Plastik Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kompyuterlər", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Mükəmməl Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Name" },
                values: new object[] { "turizm", "Ergonomik Rezin Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "turizm", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "İntellektual Beton Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "İdman", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Əlverişli Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "bəzək", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Möhtəşəm Rezin Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Səhiyyə", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Mükəmməl Plastik Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "gözəllik", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İnanılmaz Ağac Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "turizm", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Parlaq Qranit Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "musiqi", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "İnanılmaz Plastik Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Əlverişli Rezin Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Elektronika", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomik Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Səhiyyə", "Balaca Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Kitablar", "İntellektual Rezin Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Elektronika", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Rezin Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Kompyuterlər", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Mükəmməl Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Səhiyyə", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "İntellektual Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "musiqi", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Mükəmməl Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Mükəmməl Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ayyaqqabı", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "İnanılmaz Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Mükəmməl Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ev", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Kobud Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Elektronika", "Möhtəşəm Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "gözəllik", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Mükəmməl Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ev", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Əlverişli Ağac Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "İdman", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Mükəmməl Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ayyaqqabı", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Möhtəşəm Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Filmlər", "Mükəmməl Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Ayyaqqabı", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Kobud Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "садинструмент", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomik Ağac Kəmər" });
        }
    }
}

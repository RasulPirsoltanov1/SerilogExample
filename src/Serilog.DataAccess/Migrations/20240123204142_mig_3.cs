using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serilog.DataAccess.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://picsum.photos/640/480/?image=1030", "Mükəmməl Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=164", "Balaca Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=969", "İnanılmaz Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=411", "Mükəmməl Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=995", "Mükəmməl Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=225", "İnanılmaz Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=831", "İnanılmaz Plastik Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=515", "Fantastik Rezin Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=541", "Parlaq Rezin Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "oyunlar", "https://picsum.photos/640/480/?image=1037", "İntellektual Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=107", "İnanılmaz Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=28", "İnanılmaz Plastik Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Oyuncaqlar", "https://picsum.photos/640/480/?image=127", "İnanılmaz Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Səhiyyə", "https://picsum.photos/640/480/?image=226", "İntellektual Rezin Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=332", "Möhtəşəm Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "bəzək", "https://picsum.photos/640/480/?image=858", "Möhtəşəm Qranit Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=548", "Fantastik Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=518", "Ergonomik Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=21", "Mükəmməl Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=466", "Əlverişli Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "musiqi", "https://picsum.photos/640/480/?image=748", "Balaca Rezin Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=912", "Kobud Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=125", "Möhtəşəm Qranit Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=782", "Fantastik Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=650", "İnanılmaz Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "oyunlar", "https://picsum.photos/640/480/?image=557", "Ergonomik Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=945", "İnanılmaz Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=732", "İnanılmaz Polad Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=821", "Fantastik Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=164", "Möhtəşəm Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=45", "İntellektual Plastik Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=168", "Fantastik Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=263", "İnanılmaz Rezin Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=128", "Ergonomik Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=443", "Kobud Pambıq Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=188", "Möhtəşəm Plastik Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=438", "İntellektual Polad Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=876", "Parlaq Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Geyim", "https://picsum.photos/640/480/?image=842", "Əlverişli Rezin Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=575", "Ergonomik Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=60", "Ergonomik Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=252", "Ergonomik Pambıq Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=881", "İntellektual Ağac Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=947", "İntellektual Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=747", "Parlaq Qranit Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=348", "Əlverişli Plastik Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=14", "Əlverişli Polad Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=1036", "Möhtəşəm Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=162", "İnanılmaz Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "https://picsum.photos/640/480/?image=69", "Balaca Ağac Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=662", "Möhtəşəm Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=160", "Möhtəşəm Ağac Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=868", "İntellektual Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=715", "İntellektual Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=671", "İnanılmaz Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=847", "Əlverişli Polad Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "turizm", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=909", "Mükəmməl Ağac Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=475", "İntellektual Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=408", "Kobud Ağac Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=1052", "Ergonomik Rezin Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=320", "Balaca Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=420", "Ergonomik Polad Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=18", "Balaca Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=1072", "Parlaq Plastik Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Avtomobil", "https://picsum.photos/640/480/?image=552", "Parlaq Qranit Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=1046", "Balaca Plastik Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "https://picsum.photos/640/480/?image=570", "Balaca Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=476", "İntellektual Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=171", "Fantastik Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=771", "İnanılmaz Beton Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=576", "Möhtəşəm Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=808", "Mükəmməl Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=963", "Fantastik Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=432", "Mükəmməl Polad Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=762", "Parlaq Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=533", "Kobud Plastik Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=331", "Ergonomik Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "https://picsum.photos/640/480/?image=17", "Mükəmməl Polad Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=579", "Möhtəşəm Beton Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=62", "Möhtəşəm Qranit Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=20", "Əlverişli Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Geyim", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=489", "Əlverişli Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "садинструмент", "https://picsum.photos/640/480/?image=180", "İnanılmaz Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Ev", "https://picsum.photos/640/480/?image=920", "Ergonomik Plastik Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=628", "İntellektual Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=290", "Əlverişli Polad Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ev", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=148", "Ergonomik Pambıq Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "садинструмент", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=3", "İnanılmaz Beton Stol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=97", "Balaca Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://picsum.photos/640/480/?image=109", "İntellektual Plastik Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=876", "İnanılmaz Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=167", "Əlverişli Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "musiqi", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=87", "İnanılmaz Qranit Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=1009", "Kobud Ağac Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=789", "Balaca Pambıq Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=45", "Fantastik Polad Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=111", "Balaca Polad Sviter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=1037", "Əlverişli Rezin Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=543", "Kobud Rezin Avtomobil" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Name" },
                values: new object[] { "http://lorempixel.com/640/480/nightlife", "Parlaq Rezin Sviter" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/sports", "Kobud Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Səhiyyə", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/city", "Kobud Qranit Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Filmlər", "http://lorempixel.com/640/480/cats", "Əlverişli Qranit Kəmər" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "садинструмент", "http://lorempixel.com/640/480/fashion", "İnanılmaz Ağac Kəmər" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Kompyuterlər", "http://lorempixel.com/640/480/fashion", "Kobud Plastik Beret" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "gözəllik", "http://lorempixel.com/640/480/animals", "Balaca Pambıq Kulon" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "садинструмент", "http://lorempixel.com/640/480/business", "Ergonomik Beton Kulon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "bəzək", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/people", "İntellektual Ağac Kəmər" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/nature", "Parlaq Ağac Sviter" });

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
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/sports", "Fantastik Polad Sviter" });

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
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/technics", "İntellektual Plastik Stul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "bəzək", "http://lorempixel.com/640/480/sports", "Mükəmməl Beton Beret" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Ayyaqqabı", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/business", "Parlaq Polad Stol" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Elektronika", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/nightlife", "Əlverişli Beton Kulon" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "садинструмент", "http://lorempixel.com/640/480/abstract", "Fantastik Ağac Avtomobil" });

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
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "http://lorempixel.com/640/480/technics", "İntellektual Beton Beret" });

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
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "http://lorempixel.com/640/480/abstract", "Ergonomik Ağac Beret" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "İdman", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "http://lorempixel.com/640/480/nature", "Əlverişli Polad Stul" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/nature", "Balaca Ağac Kəmər" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Geyim", "http://lorempixel.com/640/480/abstract", "Ergonomik Polad Kəmər" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Ev", "http://lorempixel.com/640/480/nightlife", "Ergonomik Plastik Sviter" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "gözəllik", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/animals", "Kobud Polad Kəmər" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Filmlər", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "http://lorempixel.com/640/480/sports", "İnanılmaz Beton Kulon" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Geyim", "http://lorempixel.com/640/480/abstract", "Balaca Plastik Kəmər" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Kitablar", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "http://lorempixel.com/640/480/sports", "Fantastik Beton Sviter" });

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
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "musiqi", "http://lorempixel.com/640/480/fashion", "İntellektual Beton Stol" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "oyunlar", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "http://lorempixel.com/640/480/sports", "İntellektual Beton Stol" });

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
                columns: new[] { "Image", "Name" },
                values: new object[] { "http://lorempixel.com/640/480/city", "Mükəmməl Pambıq Avtomobil" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "Avtomobil", "The Football Is Good For Training And Recreational Purposes", "http://lorempixel.com/640/480/food", "Əlverişli Rezin Kompyuter" });

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
                columns: new[] { "Category", "Description", "Image", "Name" },
                values: new object[] { "uşaq üçün", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "http://lorempixel.com/640/480/nature", "Balaca Ağac Kəmər" });

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
    }
}

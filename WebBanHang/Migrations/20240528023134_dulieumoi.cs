using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Xml.Linq;

namespace WebBanHang.Migrations
{
    public partial class dulieumoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                  table: "Categories",
                  columns: new[] { "Id", "DisplayOrder", "Name" },
                  values: new object[,]
                  {
                    { 1, 1, "Áo thun" },
                    { 2, 2, "Áo khoác" },
                    { 3, 3, "Áo sơ mi" },
                    { 4, 4, "Quần Jean" },
                    { 5, 5, "Quần short" }
                  });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price"},
                values: new object[,]
                {
                    {  1, 1, null,null, "Áo thun cổ tim", 300 },
                    { 2, 1, null, null, "Áo thun cổ tròn", 350 },
                    { 3, 1, null, null, "Áo thun cổ chữ V", 400 },
                    { 4, 1, null, null, "Áo Thun Cổ Trụ", 420 },
                    { 5, 1, null, null, "Áo Thun Cổ Hàn Quốc", 630 },
                    { 6, 2, null, null, "Áo Khoác Bomber", 750},
                    { 7, 2, null, null, "Áo Khoác Lông", 820 },
                    { 8, 2, null, null, "Áo Khoác Phao", 950 },
                    { 9, 2, null, null, "Áo Khoác Phối Mũ", 1200},
                    { 10, 2, null, null, "Áo Khoác Cardigan ", 1450 },
                    { 11, 4, null, null, "Quần Jeans Basics", 750},
                    { 12, 4, null, null, "Quần ống loe", 1250},
                    { 13, 4, null, null, "Quần Jeans Rách gối", 400 },
                    { 14, 4, null, null, "Quần ống rộng", 420 },
                    { 15, 4, null, null, "Quần ống đứng", 630 },
                    { 16, 5, null, null, "Quần Short kaki", 750},
                    { 17, 5, null, null, "Quần short ống rộng", 820},
                    { 18, 5, null, null, "Quần short nam vải tây", 950 },
                    { 19, 5, null, null, "Quần short thun", 1200 },
                    { 20, 5, null, null, "Quần short đi biển ", 1450 },
                  
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 13);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 14);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 15);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 16);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 17);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 18);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 19);
            migrationBuilder.DeleteData(
               table: "Products",
               keyColumn: "Id",
               keyValue: 20);

           
        }
    }
}

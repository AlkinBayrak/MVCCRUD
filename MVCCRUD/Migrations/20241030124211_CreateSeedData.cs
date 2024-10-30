using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCCRUD.Migrations
{
    /// <inheritdoc />
    public partial class CreateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "Id", "Ad", "Email", "Soyad" },
                values: new object[,]
                {
                    { 1, "Ali", "ali.yilmaz@example.com", "Yılmaz" },
                    { 2, "Ayşe", "ayse.kara@example.com", "Kara" },
                    { 3, "Mehmet", "mehmet.demir@example.com", "Demir" },
                    { 4, "Fatma", "fatma.ozturk@example.com", "Öztürk" },
                    { 5, "Hasan", "hasan.celik@example.com", "Çelik" },
                    { 6, "Zeynep", "zeynep.koc@example.com", "Koç" },
                    { 7, "Emre", "emre.aydin@example.com", "Aydın" },
                    { 8, "Seda", "seda.akman@example.com", "Akman" },
                    { 9, "Burak", "burak.sonmez@example.com", "Sönmez" },
                    { 10, "Elif", "elif.yavuz@example.com", "Yavuz" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Fiyat", "UrunAdi" },
                values: new object[,]
                {
                    { 1, 2500m, "Laptop" },
                    { 2, 1500m, "Akıllı Telefon" },
                    { 3, 1200m, "Tablet" },
                    { 4, 300m, "Kulaklık" },
                    { 5, 2000m, "Masaüstü Bilgisayar" },
                    { 6, 800m, "Monitör" },
                    { 7, 400m, "Klavyeli" },
                    { 8, 600m, "Yazıcı" },
                    { 9, 250m, "Modem" },
                    { 10, 500m, "Harici Disk" }
                });

            migrationBuilder.InsertData(
                table: "Siparisler",
                columns: new[] { "Id", "MusteriId", "SiparisTarihi", "UrunId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5568), 1 },
                    { 2, 1, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5587), 2 },
                    { 3, 2, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5588), 3 },
                    { 4, 2, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5589), 4 },
                    { 5, 3, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5590), 5 },
                    { 6, 3, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5592), 6 },
                    { 7, 4, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5593), 7 },
                    { 8, 5, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5594), 8 },
                    { 9, 6, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5596), 9 },
                    { 10, 7, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5597), 10 },
                    { 11, 8, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5598), 1 },
                    { 12, 9, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5855), 2 },
                    { 13, 10, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5860), 3 },
                    { 14, 4, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5862), 5 },
                    { 15, 5, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5863), 6 },
                    { 16, 6, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5865), 7 },
                    { 17, 7, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5866), 8 },
                    { 18, 8, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5868), 9 },
                    { 19, 9, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5869), 10 },
                    { 20, 10, new DateTime(2024, 10, 30, 15, 42, 10, 738, DateTimeKind.Local).AddTicks(5871), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

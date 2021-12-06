using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class student_id_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "student_id",
                table: "student",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 155L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 156L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 157L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 158L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 159L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 160L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 626, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 627, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 618, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 620, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "organization",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 623, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "organization_module_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 623, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "role_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 624, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 624, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 624, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "user_role_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 22, 12, 1, 12, 625, DateTimeKind.Local).AddTicks(8892));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "student_id",
                table: "student");

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 404, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 155L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 156L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 157L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 158L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 159L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 160L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 397, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 399, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "organization",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 401, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "organization_module_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "role_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "user_role_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 404, DateTimeKind.Local).AddTicks(2327));
        }
    }
}

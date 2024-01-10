using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viajeroApi.Migrations
{
    /// <inheritdoc />
    public partial class fifthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                column: "viagem_url",
                value: "https://i.imgur.com/CIjNQEe.jpg");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 2,
                column: "viagem_url",
                value: "https://i.imgur.com/P5T9DC7.jpg");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 3,
                column: "viagem_url",
                value: "https://i.imgur.com/pAKkZQD.jpg");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 4,
                column: "viagem_url",
                value: "https://i.imgur.com/WdI2Tgc.png");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 5,
                column: "viagem_url",
                value: "https://i.imgur.com/sO4DMXL.jpg");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 6,
                column: "viagem_url",
                value: "hhttps://i.imgur.com/BG6Yq8U.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                column: "viagem_url",
                value: "https://imgur.com/a/wqqsrBq");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 2,
                column: "viagem_url",
                value: "https://imgur.com/a/WxOyeTU");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 3,
                column: "viagem_url",
                value: "https://imgur.com/a/9tIC8GJ");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 4,
                column: "viagem_url",
                value: "https://imgur.com/a/grR7Z6C");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 5,
                column: "viagem_url",
                value: "https://imgur.com/a/UE9WX5r");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 6,
                column: "viagem_url",
                value: "https://imgur.com/a/FUaFTQD");
        }
    }
}

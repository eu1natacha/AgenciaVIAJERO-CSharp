using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viajeroApi.Migrations
{
    /// <inheritdoc />
    public partial class fourthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "viagem_url",
                table: "Viagem",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                columns: new[] { "destino", "origem", "viagem_url" },
                values: new object[] { "Undredal - Noruega", "São Paulo - Brasil", "https://imgur.com/a/wqqsrBq" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "viagem_url",
                table: "Viagem");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                columns: new[] { "destino", "origem" },
                values: new object[] { "Undredal, Noruega", "São Paulo, Brasil" });
        }
    }
}

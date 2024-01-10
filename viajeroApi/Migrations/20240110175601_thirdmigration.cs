using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viajeroApi.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "valor_viagem",
                table: "Viagem",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                column: "valor_viagem",
                value: 8.2260000000000009);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 2,
                column: "valor_viagem",
                value: 1.1830000000000001);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 3,
                column: "valor_viagem",
                value: 980.0);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 4,
                column: "valor_viagem",
                value: 1.5049999999999999);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 5,
                column: "valor_viagem",
                value: 3.2549999999999999);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 6,
                column: "valor_viagem",
                value: 2.25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "valor_viagem",
                table: "Viagem",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1,
                column: "valor_viagem",
                value: 8226m);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 2,
                column: "valor_viagem",
                value: 1183m);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 3,
                column: "valor_viagem",
                value: 980m);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 4,
                column: "valor_viagem",
                value: 1505m);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 5,
                column: "valor_viagem",
                value: 3255m);

            migrationBuilder.UpdateData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 6,
                column: "valor_viagem",
                value: 2250m);
        }
    }
}

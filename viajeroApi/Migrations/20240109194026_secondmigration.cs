using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace viajeroApi.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Viagem",
                columns: new[] { "id_viagem", "agencia_transporte", "codigo_transporte", "data_ida", "data_volta", "descricao", "destino", "endereco_hospedagem", "guiaTurismo", "hospedagem", "origem", "qtd_pessoas", "tipo_hospedagem", "tipo_viagem", "valor_viagem" },
                values: new object[,]
                {
                    { 1, "Tam AIrlines", "PL-RL26", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as maravilhas da Noruega", "Undredal, Noruega", "St Polten, 10", "Não", "Hotel Norway Spirit", "São Paulo, Brasil", 2, "3 estrelas", "Lazer", 8226m },
                    { 2, "Gol Airlines", "AV-BL20", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as praias mágicas de Floripa", "Florianópolis - SC", "Rua da praia vermelha, 05", "Sim", "Pousada do Sol", "Rio de Janeiro - RJ", 2, "4 estrelas", "Lazer", 1183m },
                    { 3, "Catedral Turismo", "LSN45L0", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as praias de Paraty no Rio de Janeiro", "Paraty - RJ", "Rua Santa Barbara, 150", "Sim", "Pousada", "São Paulo - SP", 2, "3 estrelas", "Lazer", 980m },
                    { 4, "Azul Airlines", "TN-PL26", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as praias de Salvador", "Salvador - BA", "Rua doe baixo, 1550", "Não", "Hotel Lacerda", "Rio de Janeiro - RJ", 2, "5 estrelas", "Lazer", 1505m },
                    { 5, "Gol Airlines", "OLOG90L0", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as praias paradisíacas de Fernando de Noronha", "Fernando de Noronha - PE", "Ilha da estrela, 95", "Sim", "Hotel Maramar", "São Paulo - SP", 2, "4 estrelas", "Lazer", 3255m },
                    { 6, "Tam Airlines", "FDGHT87", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viagem de lazer para conhecer as maravilhas do Peru", "Machu Picchu - Peru", "Calle Oscar de la Roca, 5658", "Sim", "Hotel La Bela Niña", "São Paulo - SP", 2, "1 estrela", "Lazer", 2250m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id_viagem",
                keyValue: 6);
        }
    }
}

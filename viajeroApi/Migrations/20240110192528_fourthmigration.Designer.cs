﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using viajeroApi.Data;

#nullable disable

namespace viajeroApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240110192528_fourthmigration")]
    partial class fourthmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("viajeroApi.Model.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_viagem");

                    b.Property<string>("AgenciaTransporte")
                        .HasColumnType("longtext")
                        .HasColumnName("agencia_transporte");

                    b.Property<string>("CodigoTransporte")
                        .HasColumnType("longtext")
                        .HasColumnName("codigo_transporte");

                    b.Property<DateTime>("DataIda")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_ida");

                    b.Property<DateTime>("DataVolta")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_volta");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<string>("Destino")
                        .HasColumnType("longtext")
                        .HasColumnName("destino");

                    b.Property<string>("EnderecoHospedagem")
                        .HasColumnType("longtext")
                        .HasColumnName("endereco_hospedagem");

                    b.Property<string>("GuiaTurismo")
                        .HasColumnType("longtext")
                        .HasColumnName("guiaTurismo");

                    b.Property<string>("Hospedagem")
                        .HasColumnType("longtext")
                        .HasColumnName("hospedagem");

                    b.Property<string>("Origem")
                        .HasColumnType("longtext")
                        .HasColumnName("origem");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("int")
                        .HasColumnName("qtd_pessoas");

                    b.Property<string>("TipoHospedagem")
                        .HasColumnType("longtext")
                        .HasColumnName("tipo_hospedagem");

                    b.Property<string>("TipoViagem")
                        .HasColumnType("longtext")
                        .HasColumnName("tipo_viagem");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("valor_viagem");

                    b.Property<string>("ViagemURL")
                        .HasColumnType("longtext")
                        .HasColumnName("viagem_url");

                    b.HasKey("Id");

                    b.ToTable("Viagem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgenciaTransporte = "Tam AIrlines",
                            CodigoTransporte = "PL-RL26",
                            DataIda = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as maravilhas da Noruega",
                            Destino = "Undredal - Noruega",
                            EnderecoHospedagem = "St Polten, 10",
                            GuiaTurismo = "Não",
                            Hospedagem = "Hotel Norway Spirit",
                            Origem = "São Paulo - Brasil",
                            QtdPessoas = 2,
                            TipoHospedagem = "3 estrelas",
                            TipoViagem = "Lazer",
                            Valor = 8.2260000000000009,
                            ViagemURL = "https://imgur.com/a/wqqsrBq"
                        },
                        new
                        {
                            Id = 2,
                            AgenciaTransporte = "Gol Airlines",
                            CodigoTransporte = "AV-BL20",
                            DataIda = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as praias mágicas de Floripa",
                            Destino = "Florianópolis - SC",
                            EnderecoHospedagem = "Rua da praia vermelha, 05",
                            GuiaTurismo = "Sim",
                            Hospedagem = "Pousada do Sol",
                            Origem = "Rio de Janeiro - RJ",
                            QtdPessoas = 2,
                            TipoHospedagem = "4 estrelas",
                            TipoViagem = "Lazer",
                            Valor = 1.1830000000000001,
                            ViagemURL = "https://imgur.com/a/WxOyeTU"
                        },
                        new
                        {
                            Id = 3,
                            AgenciaTransporte = "Catedral Turismo",
                            CodigoTransporte = "LSN45L0",
                            DataIda = new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as praias de Paraty no Rio de Janeiro",
                            Destino = "Paraty - RJ",
                            EnderecoHospedagem = "Rua Santa Barbara, 150",
                            GuiaTurismo = "Sim",
                            Hospedagem = "Pousada",
                            Origem = "São Paulo - SP",
                            QtdPessoas = 2,
                            TipoHospedagem = "3 estrelas",
                            TipoViagem = "Lazer",
                            Valor = 980.0,
                            ViagemURL = "https://imgur.com/a/9tIC8GJ"
                        },
                        new
                        {
                            Id = 4,
                            AgenciaTransporte = "Azul Airlines",
                            CodigoTransporte = "TN-PL26",
                            DataIda = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as praias de Salvador",
                            Destino = "Salvador - BA",
                            EnderecoHospedagem = "Rua doe baixo, 1550",
                            GuiaTurismo = "Não",
                            Hospedagem = "Hotel Lacerda",
                            Origem = "Rio de Janeiro - RJ",
                            QtdPessoas = 2,
                            TipoHospedagem = "5 estrelas",
                            TipoViagem = "Lazer",
                            Valor = 1.5049999999999999,
                            ViagemURL = "https://imgur.com/a/grR7Z6C"
                        },
                        new
                        {
                            Id = 5,
                            AgenciaTransporte = "Gol Airlines",
                            CodigoTransporte = "OLOG90L0",
                            DataIda = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as praias paradisíacas de Fernando de Noronha",
                            Destino = "Fernando de Noronha - PE",
                            EnderecoHospedagem = "Ilha da estrela, 95",
                            GuiaTurismo = "Sim",
                            Hospedagem = "Hotel Maramar",
                            Origem = "São Paulo - SP",
                            QtdPessoas = 2,
                            TipoHospedagem = "4 estrelas",
                            TipoViagem = "Lazer",
                            Valor = 3.2549999999999999,
                            ViagemURL = "https://imgur.com/a/UE9WX5r"
                        },
                        new
                        {
                            Id = 6,
                            AgenciaTransporte = "Tam Airlines",
                            CodigoTransporte = "FDGHT87",
                            DataIda = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataVolta = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Viagem de lazer para conhecer as maravilhas do Peru",
                            Destino = "Machu Picchu - Peru",
                            EnderecoHospedagem = "Calle Oscar de la Roca, 5658",
                            GuiaTurismo = "Sim",
                            Hospedagem = "Hotel La Bela Niña",
                            Origem = "São Paulo - SP",
                            QtdPessoas = 2,
                            TipoHospedagem = "1 estrela",
                            TipoViagem = "Lazer",
                            Valor = 2.25,
                            ViagemURL = "https://imgur.com/a/FUaFTQD"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

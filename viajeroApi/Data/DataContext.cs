using Microsoft.EntityFrameworkCore;
using viajeroApi.Model;

namespace viajeroApi.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Viagem> Viagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Viagem>().HasData(
            new Viagem{
                Id = 1,
                ViagemURL = "https://i.imgur.com/CIjNQEe.jpg",
                Origem = "São Paulo - Brasil",
                Destino = "Undredal - Noruega",
                DataIda = DateTime.Parse("2024-10-10"),
                DataVolta = DateTime.Parse("2024-10-25"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Hotel Norway Spirit",
                TipoHospedagem = "3 estrelas",
                EnderecoHospedagem = "St Polten, 10",
                GuiaTurismo = "Não",
                AgenciaTransporte = "Tam AIrlines",
                CodigoTransporte = "PL-RL26",
                Descricao = "Viagem de lazer para conhecer as maravilhas da Noruega",
                Valor = 8.226
            },
            new Viagem{
                Id = 2,
                ViagemURL = "https://i.imgur.com/P5T9DC7.jpg",
                Origem = "Rio de Janeiro - RJ",
                Destino = "Florianópolis - SC",
                DataIda = DateTime.Parse("2024-01-10"),
                DataVolta = DateTime.Parse("2024-01-15"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Pousada do Sol",
                TipoHospedagem = "4 estrelas",
                EnderecoHospedagem = "Rua da praia vermelha, 05",
                GuiaTurismo = "Sim",
                AgenciaTransporte = "Gol Airlines",
                CodigoTransporte = "AV-BL20",
                Descricao = "Viagem de lazer para conhecer as praias mágicas de Floripa",
                Valor = 1.183
            },
            new Viagem{
                Id = 3,
                ViagemURL = "https://i.imgur.com/pAKkZQD.jpg",
                Origem = "São Paulo - SP",
                Destino = "Paraty - RJ",
                DataIda = DateTime.Parse("2021-03-01"),
                DataVolta = DateTime.Parse("2021-03-15"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Pousada",
                TipoHospedagem = "3 estrelas",
                EnderecoHospedagem = "Rua Santa Barbara, 150",
                GuiaTurismo = "Sim",
                AgenciaTransporte = "Catedral Turismo",
                CodigoTransporte = "LSN45L0",
                Descricao = "Viagem de lazer para conhecer as praias de Paraty no Rio de Janeiro",
                Valor = 980
            },
            new Viagem{
                Id = 4,
                ViagemURL = "https://i.imgur.com/WdI2Tgc.png",
                Origem = "Rio de Janeiro - RJ",
                Destino = "Salvador - BA",
                DataIda = DateTime.Parse("2024-04-10"),
                DataVolta = DateTime.Parse("2024-04-29"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Hotel Lacerda",
                TipoHospedagem = "5 estrelas",
                EnderecoHospedagem = "Rua doe baixo, 1550",
                GuiaTurismo = "Não",
                AgenciaTransporte = "Azul Airlines",
                CodigoTransporte = "TN-PL26",
                Descricao = "Viagem de lazer para conhecer as praias de Salvador",
                Valor = 1.505
            },
            new Viagem{
                Id = 5,
                ViagemURL = "https://i.imgur.com/sO4DMXL.jpg",
                Origem = "São Paulo - SP",
                Destino = "Fernando de Noronha - PE",
                DataIda = DateTime.Parse("2024-02-01"),
                DataVolta = DateTime.Parse("2024-02-10"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Hotel Maramar",
                TipoHospedagem = "4 estrelas",
                EnderecoHospedagem = "Ilha da estrela, 95",
                GuiaTurismo = "Sim",
                AgenciaTransporte = "Gol Airlines",
                CodigoTransporte = "OLOG90L0",
                Descricao = "Viagem de lazer para conhecer as praias paradisíacas de Fernando de Noronha",
                Valor = 3.255
            },
            new Viagem{
                Id = 6,
                ViagemURL = "hhttps://i.imgur.com/BG6Yq8U.jpg",
                Origem = "São Paulo - SP",
                Destino = "Machu Picchu - Peru",
                DataIda = DateTime.Parse("2024-07-10"),
                DataVolta = DateTime.Parse("2024-07-22"),
                TipoViagem = "Lazer",
                QtdPessoas = 2,
                Hospedagem = "Hotel La Bela Niña",
                TipoHospedagem = "1 estrela",
                EnderecoHospedagem = "Calle Oscar de la Roca, 5658",
                GuiaTurismo = "Sim",
                AgenciaTransporte = "Tam Airlines",
                CodigoTransporte = "FDGHT87",
                Descricao = "Viagem de lazer para conhecer as maravilhas do Peru",
                Valor = 2.250
            }

        );
        }



    }
}
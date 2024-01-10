using System.ComponentModel.DataAnnotations.Schema;


namespace viajeroApi.Model
{

    [Table("Viagem")]
    public class Viagem
    {

        [Column("id_viagem")]
        public int Id { get; set; }

        [Column("viagem_url")]
        public string? ViagemURL { get; set; }

        [Column("origem")]
        public string? Origem { get; set; }

        [Column("destino")]
        public string? Destino { get; set; }

        [Column("data_ida")]
        public DateTime DataIda { get; set; }

        [Column("data_volta")]
        public DateTime DataVolta { get; set; }

        [Column("tipo_viagem")]
        public string? TipoViagem { get; set; }   

        [Column("qtd_pessoas")]  
        public int QtdPessoas { get; set; }

        [Column("hospedagem")]
        public string? Hospedagem { get; set; }

        [Column("tipo_hospedagem")]
        public string? TipoHospedagem { get; set; }

        [Column("endereco_hospedagem")]
        public string? EnderecoHospedagem { get; set; }

        [Column("guiaTurismo")]
        public string? GuiaTurismo { get; set; }

        [Column("agencia_transporte")]
        public string? AgenciaTransporte { get; set; }

        [Column("codigo_transporte")]
        public string? CodigoTransporte { get; set; }

        [Column("descricao")]
        public string? Descricao { get; set; }

        [Column("valor_viagem")]
        public double Valor { get; set; }
        



}
}
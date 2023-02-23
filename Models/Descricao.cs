using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CepApi.Models.Enuns;

namespace CepApi.Models
{
    public class Descricao
    {
        public int Id { get; set; }
        public int cep { get; set; }
        public string rua { get; set; } = "Rua Balandia";
        public string complemento { get; set; } = "Rua Frente";
        public string bairro { get; set; } = "Guaianazes";
        public string cidade { get; set; } = "São Paulo";
        public string estado { get; set; } = "SP";
        public int frete { get; set; }

        public ClasseEnum Classe{ get; set; } = ClasseEnum.Cep;


    }
}
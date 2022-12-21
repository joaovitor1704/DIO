using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    public class Suite
    {
        public Suite(string TipoSuite, int Capacidade, decimal ValorDiaria)
        {
            this.TipoSuite = TipoSuite;
            this.ValorDiaria = ValorDiaria;
            this.Capacidade = Capacidade;   
        } 
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set;}
    }
}

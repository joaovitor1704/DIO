using SistemaDeHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int DiasReservados)
        {
            this.DiasReservados = DiasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes; 
            }
            else
            {
                throw new Exception("Quantidade de hospedes maior que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite) => Suite = suite;

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            return (DiasReservados < 10) ? DiasReservados * Suite.ValorDiaria : DiasReservados * Suite.ValorDiaria * (decimal)0.9;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        public List<Hospede> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Hospede> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Desculpe, o número de hospedes é maior do que a capacidade permitida da suite!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if (DiasReservados >= 10)
            {
                decimal desconto = (DiasReservados * Suite.ValorDiaria) * 0.10M;
                valor = DiasReservados * Suite.ValorDiaria;
                valor -= desconto;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcampWEX.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){   }

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospede){
            if(Suite.Capacidade >= hospede.Count ){
                Hospedes = hospede;
            }
            else{
                throw new Exception("A capacidade da suite é menor que o numero de hospedes");
            }

        }

        public void CadastrarSuites (Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        } 

        public decimal CalcularValorDiaria(){
            decimal diaria = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10){
                diaria *= 0.9m;
            }
            return diaria;
        }

    }

}
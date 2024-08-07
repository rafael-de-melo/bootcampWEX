using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcampWEX.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            Numero = numero;
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp}");
        }
    }
}
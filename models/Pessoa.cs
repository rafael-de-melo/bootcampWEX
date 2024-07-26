using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcampWEX.models
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void Greetings(){
            Console.WriteLine($"Olá, meu nome é {Name}/ne eu tenho {Age} anos");
        }
    }
}
using System.Text;
using bootcampWEX.models;
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("1 - Sistema de Hospedagem");
Console.WriteLine("2 - Sistema Celular com Abstração");
Console.WriteLine("exit - Encerrar programa");
string comando = Console.ReadLine().Trim().ToLower();

switch (comando)
{   
    case "1":
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Rafael");
        Pessoa p2 = new Pessoa(nome: "João");
        Pessoa p3 = new Pessoa(nome: "Eduarda");
        Pessoa p4 = new Pessoa(nome: "Rafaela");

        hospedes.Add(p1);
        hospedes.Add(p4);



        Suite suite= new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);
        reserva.CadastrarSuites(suite);
        reserva.CadastrarHospedes(hospedes);


        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria()}");

        break;
    
    case "2":
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
        Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "22222222", memoria: 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("Linkedin\n");

        iphone.Ligar();
        iphone.InstalarAplicativo("Github Mobile");

        break;

    case "exit":
        Console.WriteLine("O programa foi encerrado.");
        break;
    default:
        Console.WriteLine("Selecione uma opção válida.");
        break;
}






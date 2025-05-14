using System;
using System.Globalization;

namespace Atividade1;

public class DataAtual
{
    public void ExibirDataAtual()
    {
        Console.WriteLine("\n" +
            "Olá, nos iremos exibir a data de hoje, por favor escolha como quer que exiba a data?" +
            "\n1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)." +
            "\n2 - Apenas a data no formato (Ex: 01/03/2024.)" +
            "\n3 - Apenas a hora no formato de 24 horas." +
            "\n4 - A data com o mês por extenso.");

        DateTime hoje = DateTime.Now;

        Console.WriteLine("\nEscolha uma opção (1-4):");
        var escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Console.WriteLine($"Formato completo: {hoje.ToString("dddd, dd 'de' MMMM 'de' yyyy - HH:mm:ss", new CultureInfo("pt-BR"))}");
                break;

            case "2":
                Console.WriteLine($"Data: {hoje.ToString("dd/MM/yyyy")}");
                break;

            case "3":
                Console.WriteLine($"Hora: {hoje.ToString("HH:mm")}");
                break;

            case "4":
                Console.WriteLine($"Data com mês por extenso: {hoje.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
                break;

            default:
                Console.WriteLine("Opção inválida. Por favor, escolha entre 1 e 4.");
                break;
        }
            
    }
}


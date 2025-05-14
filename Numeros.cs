namespace Atividade1;

public class Numeros
{
    /* Crie um programa com 2 valores do tipo `double` já declarados que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.
     */

    public void Calculadora()
    {
        Console.WriteLine("\nDigite um numero (n1)");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um numero (n2)");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A soma de {n1} mais {n2} é igual a {n1+n2}");
        Console.WriteLine($"A subtração de {n1} menos {n2} é igual a {n1 - n2}");
        Console.WriteLine($"A Multiplicação de {n1} e {n2} é igual a {n1 * n2}");
        Console.WriteLine($"A Divisão de {n1} e {n2} é igual a {n1 / n2}");
        Console.WriteLine($"A Media de {n1} e {n2} é igual a {(n1+n2)/2}");
    }
}


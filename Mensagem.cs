namespace Atividade1;

public class Mensagem
{
    /* Crie um programa em que o usuário precisa digitar um nome e uma mensagem de 
         * boas vindas personalizada com o nome dele é exibida */
    public void ExibirMensagem()
    {
        Console.WriteLine("\nQual é o seu nome? ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

    /* Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário
     e ao final exiba o nome completo.*/
    public void ExibirNome()
    {
        Console.WriteLine("\nQual é o seu Nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é o seu Sobrenome?");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Olá {nome} {sobrenome}, Seja muito bem-vindo!");
    }

    /* Crie um programa em que o usuário digita uma ou mais palavras e é exibido a 
     quantidade de caracteres que a palavra inserida tem.
     */
    public void ContarCaracteres()
    {
        Console.WriteLine("\nDigite alguma frase ou palavra");
        string caracter = Console.ReadLine();
        if (caracter.Length == 0)
        {
            Console.WriteLine("Não há nenhum caracter");
        }
        else {
            Console.WriteLine($"A frase/palavra {caracter} tem {caracter.Replace(" ","").Length} caracteres");
        }
    }
}


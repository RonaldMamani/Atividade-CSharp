using System.Text.RegularExpressions;

namespace Atividade1;

public class Placa
{
    public void VerificarPlaca()
    {
        Console.WriteLine("\nDigite a placa do veículo");
        string placa = Console.ReadLine();

        bool resultado = VerificarPlacaRegra(placa);
        Console.WriteLine(resultado);
    }

    static bool VerificarPlacaRegra(string placa)
    {
        if (string.IsNullOrEmpty(placa))
        {
            return false;
        }

        placa = placa.Trim().ToUpper();

        Regex regex = new Regex(@"^[A-Z]{3}[0-9]{4}$");

        return regex.IsMatch(placa);
    }
}


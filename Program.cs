namespace Atividade1;

public class Program
{
    static void Main()
    {
        Mensagem mensagem = new Mensagem();
        Numeros numeros = new Numeros();
        Placa placa = new Placa();
        DataAtual dataAtual = new DataAtual();

        //Atividade 1
        mensagem.ExibirMensagem();

        //Atividade 2
        mensagem.ExibirNome();

        //Atividade 3
        numeros.Calculadora();

        //Atividade 4
        mensagem.ContarCaracteres();

        //Atividade 5
        placa.VerificarPlaca();

        //Atividade 6
        dataAtual.ExibirDataAtual();
    }

}

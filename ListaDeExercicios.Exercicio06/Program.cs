namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite a pontuação da primeira prova: ");
            double primeiraProva = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a pontuação da segunda prova: ");
            double segundaProva = Convert.ToDouble(Console.ReadLine());

            //processamento
            double media = (primeiraProva + segundaProva) / 2;

            //output de dados
            Console.WriteLine($"A média do aluno é: {media}");

            Console.ReadLine();
        }
    }
}

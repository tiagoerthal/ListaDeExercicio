namespace ListaDeExercicio.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            //processamento
            double fahrenheit = (celsius * 9 / 5) + 32; 

            //output de dados
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");

            Console.ReadLine();
        }
    }
}

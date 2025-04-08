namespace ListaDeExercicio.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite um número para saber se é par ou ímpar:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número ({numero}) é par.");
            }
            else
            {
                Console.WriteLine($"O número ({numero}) é ímpar.");
            }
            Console.ReadLine();
        }
    }
}

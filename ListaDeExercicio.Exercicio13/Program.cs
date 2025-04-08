namespace ListaDeExercicio.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro não negativo: ");
            int A = int.Parse(Console.ReadLine());

            if (A < 0)
            {
                Console.WriteLine("Por favor, insira um número não negativo.");
                Console.WriteLine("------------------------------------------------");
                return;
            }

            long fatorial = 1;

            Console.WriteLine($"Cálculo do fatorial de {A}:");
            for (int i = 1; i <= A; i++)
            {
                fatorial *= i;
                Console.WriteLine($"{i}! = {fatorial}");
            }

            Console.WriteLine($"O fatorial de {A} é: {fatorial}");

            Console.ReadLine();
        }
    }
}

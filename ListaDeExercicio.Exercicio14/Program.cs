namespace ListaDeExercicio.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.WriteLine("Sequência de Fibonacci até " + numero + ": ");

            while (a <= numero)
            {
                Console.Write(a + " ");
                int proximo = a + b;
                a = b;
                b = proximo;
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

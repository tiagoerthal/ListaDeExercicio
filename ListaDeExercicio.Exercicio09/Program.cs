namespace ListaDeExercicio.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            int a, b, c;

            // Leitura dos valores
            Console.Write("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor:");
            c = int.Parse(Console.ReadLine());

            // Verificação e exibição em ordem decrescente
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"{a}, {b}, {c}");
                }
                else
                {
                    Console.WriteLine($"{a}, {c}, {b}");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b}, {a}, {c}");
                }
                else
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            }

            Console.ReadLine(); 
        }
    }
}

namespace ListaDeExercicio.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //processamento e output de dados
            if (EhPrimo(numero))
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
            Console.ReadLine();
        }

        static bool EhPrimo(int num)
        {
            if (num <= 1) return false; // Números menores ou iguais a 1 não são primos
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false; // Se for divisível por i, não é primo
            }
            return true; // Se não encontrou divisores, é primo
        }
    }
}

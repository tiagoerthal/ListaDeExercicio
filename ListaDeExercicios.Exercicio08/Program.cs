namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Calcule A+B para saber se a escolha C é maior ou menor");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Digite um número(A): ");     
            int numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Digite um número(B): ");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Digite um número(C): ");
            int numeroTres = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int calculo = numeroUm + numeroDois;

            if (calculo > numeroTres)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"A soma ({calculo}) é maior que ({numeroTres}) ");
                Console.WriteLine("-------------------------------------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"A soma ({calculo}) é menor que ({numeroTres}) ");
                Console.WriteLine("-------------------------------------------------------");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}

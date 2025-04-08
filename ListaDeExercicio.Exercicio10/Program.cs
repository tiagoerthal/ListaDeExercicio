namespace ListaDeExercicio.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Calculando seu IMC");
            Console.WriteLine("---------------------------------");

            Console.Write("Digite sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.Write("Digite seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            double resultado = peso / Math.Pow(altura, 2);

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Seu IMC é: {resultado}"); 
            Console.WriteLine("---------------------------------");

            if (resultado < 18.5)
            {
                Console.WriteLine($"Você está abaixo do peso ideal.");
            }
            else if (resultado >= 18.5 && resultado < 24.9)
            {
                Console.WriteLine($"Você está com o peso ideal.");
            }
            else if (resultado >= 25 && resultado < 29.9)
            {
                Console.WriteLine($"Você está acima do peso.");
            }
            else
            {
                Console.WriteLine($"Você está obeso.");
            }

            Console.ReadLine();
        }
    }
}

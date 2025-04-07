using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeExercicio.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite a quilometragem inicial do veículo: ");
            double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível: ");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            //processamento
            double distanciaPercorrida = quilometragemFinal - quilometragemInicial;

            double eficiencia = distanciaPercorrida / gasolina;

            //output de dados
            Console.WriteLine($"A distância percorrida foi de {distanciaPercorrida} km.");
            Console.WriteLine($"A eficiência do combustível é de {eficiencia} km/l.");

            Console.ReadLine();
        }
    }
}

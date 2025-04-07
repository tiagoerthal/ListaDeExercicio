namespace ListaDeExercicio.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            //processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            //output
            Console.WriteLine($"O volume do cilindro é: {volume}."); 
          
            Console.ReadLine();
        }
    }
}

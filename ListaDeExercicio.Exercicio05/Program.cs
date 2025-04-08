namespace ListaDeExercicio.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite o salário base do vendedor: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual ganho do vendedor (em %): ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            //processamento
            double comissao = (vendas * percentual / 100);
            double salarioTotal = salarioBase + comissao;

            //output de dados
            Console.WriteLine($"O salário total do vendedor é: {salarioTotal:C2}");

            Console.ReadLine();
        }
    }
}

namespace ListaDeExercicio.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region input dos dados
            Console.Write("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            decimal largunra = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            decimal resultado = comprimento * largunra * altura;
            #endregion

            #region output dos dados
            Console.WriteLine($"O volume da caixa é de {resultado}.");
            #endregion
            Console.ReadLine();
        }
    }
}

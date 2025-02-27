using System.ComponentModel.Design;

namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1ª nota do Aluno!");
            double notal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2ª Nota do Aluno!");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (notal + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }

            else if (media < 5)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}

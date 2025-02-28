namespace CEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° Número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\nDigite o 2° Número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° Número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            Console.WriteLine($"\n0 Numero {maior} é o maior valor!");
        }
    }
}

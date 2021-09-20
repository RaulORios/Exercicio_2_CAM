using System;
using System.Globalization;

namespace Exercicio_2_CAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionario: {f}");

            Console.WriteLine();
            Console.Write("Digite a procentagem para aumentar o sálario: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f}");

            Console.ReadKey();

        }
    }
}

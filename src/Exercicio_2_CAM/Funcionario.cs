using System;
using System.Globalization;

namespace Exercicio_2_CAM
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double impostos)
        {
            SalarioBruto += ((SalarioBruto * impostos) / 100);
        }

        public override string ToString()
        {
            return ($"{Nome}, $ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}"); 
        }




    }
}

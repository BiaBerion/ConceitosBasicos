using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculoImc
    {

        public double Imc(double peso, double altura)
        {

            return peso / (altura * altura);

        }
    }
}

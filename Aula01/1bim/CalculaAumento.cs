using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaAumento
    {

        public double Aumento(double salario, double percentual)
        {

            return salario * (percentual / 100);

        }

        public double Calc(double aumento, double salario)
        {

            return salario + aumento;

        }

    }
}

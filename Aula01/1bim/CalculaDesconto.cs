using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaDesconto
    {

        public double CalDescon(double valor, double descontoPercentual)
        {

            return valor * (descontoPercentual / 100);

        }

        public double CalResul(double valor, double valorDesconto)
        {

            return valor - valorDesconto;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CarroAluguel
    {

        public double calcKm(double kmInicial, double kmFinal) {

            return  kmFinal - kmInicial;

            

        }

        public double Aluguel(double dias, double kmRodados)
        {

            double precoPorKm = 0.35, diaria = 95.0;

            return  (dias* diaria) + (kmRodados* precoPorKm);

        }

    }
}

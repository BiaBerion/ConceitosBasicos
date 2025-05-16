using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class Multiplos
    {
        public int Resto(int i)
        {

            for (i = 3; 3 < 100; i++)
            {

                if (i % 3 == 0)
                {
                    return i;
                }
            }
        }
    }
}



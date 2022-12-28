using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    
    public class Calculo
    {

        public int valor1;
        public int valor2;
        public int Adicao()
        {
            return valor1 + valor2;
        }
        public int Subtracao()
        {
            return valor1 - valor2;
        }
        public int Multiplicacao()
        {
            return valor1 * valor2;
        }
        public int Divisao()
        {
            return valor1 / valor2;
        }

    }
}

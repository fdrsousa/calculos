using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementar operações aritméticas
    /// </summary>
    internal static class Aritmetica

    {
        
        /// <summary>
        /// Operação Soma.
        /// </summary>
        /// <returns>Retorna a soma de dois valores inteiros</returns>
        public static int Somar(int n1, int n2){
            return n1 + n2;
        }

        /// <summary>
        /// Operação Subtrair.
        /// </summary>
        /// <returns>Retorna a subtração de dois valores inteiros</returns>
        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// Operação Mutiplicar.
        /// </summary>
        /// <returns>Retorna a multiplicação de dois valores inteiros</returns>
        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}

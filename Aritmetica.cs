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
    internal class Aritmetica

    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }
        /// <summary>
        /// Operação Soma.
        /// </summary>
        /// <returns>Retorna a soma de dois valores inteiros</returns>
        public int Somar(int n1, int n2){
            return n1 + n2;
        }

        /// <summary>
        /// Operação Subtrair.
        /// </summary>
        /// <returns>Retorna a subtração de dois valores inteiros</returns>
        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura - 32) / 1.8000;
            }
            else
                return -1;
        }
    }
}

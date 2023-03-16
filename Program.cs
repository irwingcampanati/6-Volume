// Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
// V = 3.14159 * R * R * A
// Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de raio e altura da lata de óleo para encontrarmos seu volume.");
            Console.WriteLine("Valor do raio da lata de óleo: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor da altura da lata de óleo: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double v = 3.14159 * r * r * a;
            Console.WriteLine("O valor do volume da lata de óleo é igual a: " + v);
        }
    }
}
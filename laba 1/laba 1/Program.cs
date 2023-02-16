using System.Runtime.Serialization.Formatters;

namespace laba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введие количество шагов:");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for(int i = 1; i <= n; i++)
            {
                if (n < 0 && x > 1) {
                
                    break;
                }
                else {
                    double a = (2 * i - 1) * Math.Pow(x, 2 * i + 1);
                    double b = (2 * i) * (2 * i + 1);

                    double a1 = a / b;

                    sum += a1;
                    Console.WriteLine(sum);
                }
            }
            if (n > 0 && x < 1)
            {
                Console.WriteLine( 3.14/2 - x + sum);

            }
            else
            {
                Console.WriteLine("Вы ввели отрицательное число шагов или не выполнено условие для x < 1.");
            }
        }
    }
}

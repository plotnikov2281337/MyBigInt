using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MyBigInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое число: ");
            BigInt num1 = new BigInt("300", 1);
            num1.PrintBigInt();
            Console.WriteLine("");

            Console.WriteLine("Второе число: ");
            BigInt num2 = new BigInt("4289", -1);
            num2.PrintBigInt();
            Console.WriteLine("");

            BigInt plus = new BigInt("", 1);
            BigInt minus = new BigInt("", 1);

            BigInteger bigInteger1 = BigInteger.Parse(num1.Byte + num1.Num);
            BigInteger bigInteger2 = BigInteger.Parse(num2.Byte + num2.Num);

            num1.equate(num2);

            
            Console.WriteLine("Сравнение: ");
            num1.More(num2);
            Console.WriteLine("");

            

            Console.WriteLine("Сложение: ");
            plus.PlusFinaly(num1, num2);          
            Console.WriteLine("");

            Console.WriteLine("Вычитание: ");
            minus.MinusFinaly(num1, num2);
            Console.WriteLine("");

            Console.WriteLine("Проверяем равен ли созданный тип данных, типу BigInteger: ");
            Console.WriteLine("Если результаты сложения равны, выведет True, в обратной ситуации False: ");
            BigInteger Sum2 = BigInteger.Parse(plus.Byte+plus.Num);
            BigInteger Sum = bigInteger1 + bigInteger2;
            Console.WriteLine(Sum);
            Console.WriteLine(plus.Byte+plus.Num);
            Console.WriteLine("");
            if (Sum2 == Sum)
            {
                Console.WriteLine("True");
            }
            if (Sum2 != Sum)
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("");

            Console.WriteLine("Если результаты разности равны, выведет True, в обратной ситуации False: ");
            BigInteger Min2 = BigInteger.Parse(minus.Byte+minus.Num);
            BigInteger Min = bigInteger1 - bigInteger2;
            Console.WriteLine(Min);
            Console.WriteLine(minus.Byte+minus.Num);
            Console.WriteLine("");
            if (Min2 == Min)
            {
                Console.WriteLine("True");
            }
            if (Min2 != Min)
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }    
    }
}

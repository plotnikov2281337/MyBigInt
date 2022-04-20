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
            BigInt num1 = new BigInt("100", 1);
            num1.PrintBigInt();

            Console.WriteLine("Второе число: ");
            BigInt num2 = new BigInt("25", 1);
            num2.PrintBigInt();
            BigInt plus = new BigInt("", 1);
            BigInt minus = new BigInt("", 1);

            BigInteger bigInteger = BigInteger.Parse("98495165498495169854984951654984951");
            BigInteger bigInteger2 = BigInteger.Parse("5559198498416519849849");

            Console.WriteLine("");
            num1.More(num2);
            num1.equate(num2);
            plus.equate(num1);
            minus.equate(num1);
            Console.WriteLine("");
            plus.Plus(num1, num2);
            Console.WriteLine("");
            minus.Minus(num1, num2);

            /*BigInteger Sum2 = BigInteger.Parse(plus.Num);
            BigInteger Sum = bigInteger + bigInteger2;
            Console.WriteLine("");
            if (Sum2 == Sum)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }*/
            Console.ReadKey();
        }    
    }
}

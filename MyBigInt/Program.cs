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
            BigInt num1 = new BigInt("5000", 1);
            num1.PrintBigInt();

            Console.WriteLine("Второе число: ");
            BigInt num2 = new BigInt("6000", 1);
            num2.PrintBigInt();
            BigInt plus = new BigInt("", 1);
            BigInt minus = new BigInt("", 1);

            BigInteger bigInteger = BigInteger.Parse("98495165498495169854984951654984951");
            BigInteger bigInteger2 = BigInteger.Parse("5559198498416519849849");

            Console.WriteLine("");
            num1.More(num2);
            Console.WriteLine("");
            plus.Plus(num1, num2);
            Console.WriteLine("");
            minus.Minus(num1, num2);

            Console.ReadLine();
        }    
    }
}

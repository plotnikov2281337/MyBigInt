using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInt
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {

            Console.WriteLine("Первое число: ");
            BigInt num1 = new BigInt("98495165498495169854984951654984951", 1);

            Console.WriteLine("Второе число: ");
            BigInt num2 = new BigInt("4759214729712902472952727225", 1);

            Console.WriteLine("< > == !=: ");
            num1.More(num2);

            Console.WriteLine("Складываем: ");
            num1.Plus(num2);
        }
    }
}

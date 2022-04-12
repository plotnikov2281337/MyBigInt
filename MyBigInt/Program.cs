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

            var num1 = new List<int>();
            var num2 = new List<int>();
            BigInt bigInt = new BigInt();

            bigInt.Insert(num1);
            bigInt.Insert(num2);

            bigInt.Equal(num1, num2);
           
        }
    }
}

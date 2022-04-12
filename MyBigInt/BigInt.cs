using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInt
{
    internal class BigInt
    {

        public void Insert(List<int> list)
        {
            Console.WriteLine("Введите число: ");
            string _value = Console.ReadLine();
            for (int i = 0; i < _value.Length; i++)
            {
                string s = _value[i].ToString();
                list.Add(int.Parse(s));
            }
            Print(list);
            Console.ReadKey();
        }



        public void Print(List<int> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
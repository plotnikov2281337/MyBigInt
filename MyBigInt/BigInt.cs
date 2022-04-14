using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInt
{
    internal class BigInt
    {
        int positiveNum1 = 1;
        int positiveNum2 = 1;

        int Positiv = 1;

        List<int> numbers = new List<int>();

        public BigInt(string num, int positive)
        {
            for (int i = 0; i < num.Length; i++)
            {
                string s = (num[i].ToString());
                numbers.Add(int.Parse(s));
            }
            Positiv = positive;
            Print();
            Console.ReadKey();
        }

        public void Positive(List<int> num, int positive)
        {
            string s = String.Join("", num.ToArray());
            if (s[0] == '-')
            {
                positive = -1;
            }
            else positive = 1;
        }

        public int CompareTo(List<int> num1, List<int> num2)
        {
            Positive(num1, positiveNum1);
            Positive(num2, positiveNum2);
            if (positiveNum1 != positiveNum2) return positiveNum1.CompareTo(positiveNum2);
            if (num1.Count != num2.Count) return num1.Count.CompareTo(num2.Count);

            for (int i = 0; i < num1.Count; i++)
            {
                if (num1[i] > num2[i]) return 1;
                if (num1[i] == num2[i]) return 0;
                if (num1[i] < num2[i]) return -1;
            }


            return 0;
        }

        public void More(List<int> num1, List<int> num2)
        {
            string s1 = String.Join("", num1.ToArray());
            string s2 = String.Join("", num2.ToArray());

            if (CompareTo(num1, num2) == 1) Console.WriteLine($"{s1} > {s2}");
            if (CompareTo(num1, num2) == 0) Console.WriteLine($"{s1} = {s2}");
            if (CompareTo(num1, num2) == -1) Console.WriteLine($"{s1} = {s2}"); 
        }
    

        public void Print()
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        
    }
    
}
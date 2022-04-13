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

          

        }

        public int CompareTo1 (List<int> num1, List<int> num2)
        {
            int cmpVal = num1.CompareTo(num2);
        }

        public void More(List<int> num1, List<int> num2)
        {
            string s1 = String.Join("", num1.ToArray());
            string s2 = String.Join("", num2.ToArray());

            int int1 = num1.ElementAt(0);        
            int int2 = num2.ElementAt(0);

            bool tt;
            bool ff; 

            if (num1.Count > num2.Count)
            {
                Console.WriteLine($"{s1} > {s2}");
            }

            if (num1.Count < num2.Count)
            {
                Console.WriteLine($"{s1} < {s2}");
            }

            else {
                
                for (int i = 0; i < num1.Count; i++)
                {
                    for (int j = 0; j < num2.Count; j++)
                    {
                        if (num1.ElementAt(i) > num2.ElementAt(i))
                        {
                            tt = true;
                            break;
                        }
                        if (num1.ElementAt(i) < num2.ElementAt(i))
                        {
                            ff = true;
                            break;
                        }
                        if (num1.ElementAt(i) == num2.ElementAt(i))
                        {
                            tt = false;
                            ff = false;
                        }
                    }
                } 
                    
                if ( tt = true )
                    Console.WriteLine($"{s1} > {s2}");
                if (ff = true)
                    Console.WriteLine($"{s1} < {s2}");
            }
            
            Console.ReadKey();
        }

        public void Equal(List<int> num1, List<int> num2)
        {
            bool equal = num1.SequenceEqual(num2);
     
            string s1 = String.Join("", num1.ToArray());
            string s2 = String.Join("", num2.ToArray());

            if (equal == true)
            {
                Console.WriteLine($"{s1} == {s2}");
            }
            if (equal == false)
            {
                Console.WriteLine($"{s1} != {s2}");
            }
            Console.ReadKey();
        }

        public void Print(List<int> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
        }

        private void ListToString(List<int> num, string s1)
        {
            s1 = String.Join("", num.ToArray());           
        }
    }
    
}
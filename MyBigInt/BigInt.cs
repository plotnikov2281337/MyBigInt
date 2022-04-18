using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInt
{
    internal class BigInt
    {
        int Positive = 1;
        string Num;
        string Byte;
        string Value;

        List<int> numbers = new List<int>();
        List<int> result = new List<int>();

        List<int> help = new List<int>();

        public BigInt(string num, int positive)
        {
            for (int i = 0; i < num.Length; i++)
            {
                string s = (num[i].ToString());
                numbers.Add(int.Parse(s));
            }
            Positive = positive;
            Value = num;
            Num = num;
            if (positive == 1) Byte = "";
            if (positive != 1) Byte = "-";
            Console.WriteLine($"{Byte}{Num}");


        }

             
        

        public int CompareTo(BigInt num2)
        {
            if (Positive != num2.Positive) return Positive.CompareTo(num2.Positive);
            if (Num.Length != num2.Num.Length) return Num.Length.CompareTo(num2.Num.Length);


            for (int i = 0; i <= Num.Length; i++)
            {

                if (Num[i] > num2.Num[i]) return 1;
                if (Num[i] == num2.Num[i]) return 0;

            }

            for (int i = 0; i <= Num.Length; i++)
            {
                
                if (Num[i] > num2.Num[i]) return 1;

                if (Num[i] < num2.Num[i]) return -1;
            }

            return 0;

        }

        public void More(BigInt num2)
        {
            if (CompareTo(num2) == 1) Console.WriteLine($"{Byte}{Num} > {num2.Byte}{num2.Num}");
            if (CompareTo(num2) == -1) Console.WriteLine($"{Byte}{Num} < {num2.Byte}{num2.Num}");
            if (CompareTo(num2) == 0) Console.WriteLine($"{Byte}{Num} = {num2.Byte}{num2.Num}");

        }

        public void equate(BigInt num2)
        {

            if (Num.Length > num2.Num.Length)
            {
                int numLength = Num.Length - 1 - num2.Num.Length;

                for (int i = 0; i <= numLength; i++)
                {
                    num2.numbers.Insert(0, 0);

                }
                string s = string.Join("", num2.numbers.ToArray());
                num2.Value = s;
            }
            if (Num.Length < num2.Num.Length)
            {
                int numLength = num2.Num.Length - 1 - Num.Length;
                for (int i = 0; i <= numLength; i++)
                {
                    numbers.Insert(0, 0);

                }
                string s = string.Join("", numbers.ToArray());
                Value = s;
            }

        }


        public void Plus(BigInt num2)
        {

            string s = "";
            int True = 0;
            equate(num2);

            for (int i = 0; i <= Value.Length; i++) result.Add(1);
            for (int i = 0; i <= Value.Length; i++) help.Add(1);


            int NumI4;
            int NumI5 = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                string NumS1 = (Value[i].ToString());
                string NumS2 = (num2.Value[i].ToString());

                int NumI1 = int.Parse(NumS1);
                int NumI2 = int.Parse(NumS2);


                if (Positive == num2.Positive)
                {
                    int NumI3 = NumI1 + NumI2 + NumI5;
                    NumI5 = 0;
                    if (NumI3 < 10)
                    {
                        result.Insert(i, NumI3);
                        result.RemoveAt(i+1);
                    }


                    else
                    {
                        if (i == 0)                                                 
                            True = 1;
                        


                        NumI4 = NumI3 - 10;
                        result.Insert(i, NumI4);
                        result.RemoveAt(i+1);
                        NumI4 = 0;
                        
                        NumI5 = 1;
                    
                    }

                }


                if (Positive != num2.Positive)
                {

                    NumI5 = 0;

                    if (CompareTo(num2) == 1)
                    {
                        NumI1 = NumI1 - NumI5;
                        NumI5 = 0;

                        if (NumI1 < NumI2)
                        {
                            int NumI3 = (NumI1 + 10 ) - NumI2;

                            result.Insert(i, NumI3);
                            result.RemoveAt(i+1);

                            NumI5 = 1;
                        }

                        else
                        {
                            int NumI3 = NumI1 - NumI2;
                            result.Insert(i, NumI3);
                            result.RemoveAt(i+1);
                        }

                    }

                    if (CompareTo(num2) == -1)
                    {
                        NumI2 = NumI2 - NumI5;
                        NumI5 = 0;

                        if (NumI2 < NumI1)
                        {
                            int NumI3 = (NumI2 + 10) - NumI1;

                            result.Insert(i, NumI3);
                            result.RemoveAt(i+1);

                            NumI5 = 1;
                        }

                        else
                        {
                            int NumI3 = NumI2 - NumI1;
                            result.Insert(i, NumI3);
                            result.RemoveAt(i+1);
                        }
                    }

                }




                }

            result.RemoveAt(Value.Length);

            if (True == 0)
            {
                s = string.Join("", result.ToArray());
                Console.WriteLine($"{Byte}{Num} + {num2.Byte}{num2.Num} = {s}");
            }

            if (True == 1)
            {
                s = string.Join("", result.ToArray());
                Console.WriteLine($"{Byte}{Num} + {num2.Byte}{num2.Num} = 1{s}");
            }


            Console.ReadKey();
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

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
        int True = 0;
        public string Num;
        public string Byte;
        string Value;
        List<int> numbers = new List<int>();
        List<int> result = new List<int>();


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
        }

        public int Compare(BigInt num2)
        {
            for (int i = 0; i <= Num.Length -1; i++)
            {
                if (Value[i] > num2.Value[i]) return 1;
                if (Value[i] == num2.Value[i]) return 0;
                if (Value[i] < num2.Value[i]) return -1;
            }

            return 0;
        }
        public void Print(List<int> numbers)
        {
            foreach (var month in numbers)
            {
                Console.WriteLine(month);
            }
        }
        public void PrintBigInt()
        {
            Console.WriteLine($"{Byte}{Num}");
        }
        public int CompareTo(BigInt num2)
        {
            if (Positive != num2.Positive) return Positive.CompareTo(num2.Positive);

            for (int i = 0; i <= Value.Length -1; i++)
            {
                if (Positive == -1 || num2.Positive == -1)
                {
                    if (Value[i] < num2.Value[i]) return 1;
                    if (Value[i] > num2.Value[i]) return -1;
                    num2.Print(num2.numbers);
                }

                else
                {
                    if (Value[i] > num2.Value[i]) return 1;
                    if (Value[i] < num2.Value[i]) return -1;
                }
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

            else { };
        }
        public void Minus(BigInt num1, BigInt num2)
        {
            int True = 1;
            for (int i = 0; i <= num1.Value.Length; i++) result.Add(9);
            int NumI5 = 0;
            for (int i = num1.numbers.Count -1; i >= 0; i--)
            {


                string NumS1 = (num1.Value[i].ToString());
                string NumS2 = (num2.Value[i].ToString());
                int NumI1 = int.Parse(NumS1);
                int NumI2 = int.Parse(NumS2);


                if (num1.Compare(num2) == 1)
                {

                    NumI1 = NumI1 - NumI5;
                    NumI5 = 0;


                    NumI5 = 0;

                    if (NumI1 < NumI2)
                    {
                        int NumI3 = (NumI1 + 10) - NumI2;
                        result.Insert(i, NumI3);
                        result.RemoveAt(i + 1);
                        
                        NumI5 = 1;
                    }

                    else
                    {
                        int NumI3 = NumI1 - NumI2;
                        result.Insert(i, NumI3);
                        result.RemoveAt(i + 1);
                        
                    }

                }

                if (num1.Compare(num2) == -1)
                {
                    NumI2 = NumI2 - NumI5;
                    NumI5 = 0;

                    if (NumI1 > NumI2)
                    {
                        int NumI3 = (NumI2 + 10) - NumI1;
                        result.Insert(i, NumI3);
                        result.RemoveAt(i + 1);
                        
                        NumI5 = NumI5 + 1;
                    }

                    else
                    {
                        int NumI3 = NumI2 - NumI1;
                        result.Insert(i, NumI3);
                        result.RemoveAt(i + 1);
                        
                    }

                }

                if (num1.Compare(num2) == 0)
                {

                    NumI1 = NumI1 - NumI5;
                    NumI5 = 0;

                    NumI5 = 0;

                    if (NumI1 < NumI2)
                    {
                        int NumI3 = (NumI1 + 10) - NumI2;
                        result.RemoveAt(i);
                        result.Insert(i, NumI3);
                        NumI5 = 1;
                    }

                    else
                    {
                        int NumI3 = NumI1 - NumI2;
                        result.RemoveAt(i);
                        result.Insert(i, NumI3);
                    }

                }


            }

            if (result[0] == 0)
            {

                result.RemoveAt(0);
            }

        }
        public void Plus(BigInt num1, BigInt num2)
        {
            for (int i = 0; i <= num1.Value.Length; i++) result.Add(9);
            int NumI5 = 0;
            for (int i = num1.numbers.Count -1; i >= 0; i--)
            {


                string NumS1 = (num1.Value[i].ToString());
                string NumS2 = (num2.Value[i].ToString());
                int NumI1 = int.Parse(NumS1);
                int NumI2 = int.Parse(NumS2);


                int NumI3 = NumI1 + NumI2;
                NumI3 = NumI3 + NumI5;
                NumI5 = 0;

                if (NumI3 < 10)
                {
                    result.Insert(i, NumI3);
                    result.RemoveAt(i + 1);

                }

                else
                {

                    NumI3 = NumI3 - 10;

                    result.Insert(i, NumI3);
                    result.RemoveAt(i + 1);

                    NumI5 = 1;

                    if (i == 0)
                        result.Insert(0, 1);
                }
            }
        }
        public BigInt PlusFinaly(BigInt num1, BigInt num2)
        {
            if (num1.Positive == num2.Positive)
            {
                Plus(num1, num2);
            }

            if (num1.Positive != num2.Positive)
            {
                Minus(num1, num2);
            }

            result.RemoveAt(result.Count - 1);

            BigInt num3 = new BigInt("", 1);

            if (result[0] == 0) True = 1;

            if (result.Count == 0)
            {
                Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = 0");
                Num = "0";
                Positive = 1;
                Byte = "";
            }

            if (result[0] == 0)
            {
                Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = 0");
                Num = "0";
                Positive = 1;
                Byte = "";
            }



            if (result[0] != 0)
            {

                if (num1.Positive != num2.Positive)
                {
                    if (num1.Compare(num2) == 1)
                    {
                        Positive = num1.Positive;
                        Byte = num1.Byte;
                    }

                    if (num1.Compare(num2) == -1)
                    {
                        Positive = num2.Positive;
                        Byte = num2.Byte;
                    }
                }

                if (num1.Positive == num2.Positive)
                {
                    if (num1.Compare(num2) == 1)
                    {
                        Positive = num1.Positive;
                        Byte = num1.Byte;
                    }

                    if (num1.Compare(num2) == -1)
                    {
                        Positive = num2.Positive;
                        Byte = num2.Byte;
                    }

                    if(num1.Positive == -1)
                    {
                        Positive = -1;
                        Byte = "-";

                    }
                }


                if (True == 1)
                {
                    result.RemoveAt(0);
                }

                string s = string.Join("", result.ToArray());

                if (True == 2)
                {
                    s = "1" + s;

                }



                Num = s;
                Console.WriteLine($"{num1.Byte}{num1.Num} + {num2.Byte}{num2.Num} = {Byte}{Num}");
            }
            return num3;

        }
        public BigInt MinusFinaly(BigInt num1, BigInt num2)
        {
            if (num1.Positive == num2.Positive)
            {
                Minus(num1, num2);
            }

            if (num1.Positive != num2.Positive)
            {
                Plus(num1, num2);
            }

            result.RemoveAt(result.Count - 1);

            BigInt num3 = new BigInt("", 1);



            if (result[0] == 0)
            {
                Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = 0");
                Num = "0";
                Positive = 1;
                Byte = "";
            }

            if (result[0] != 0)
            {

                if (num1.Positive != num2.Positive)
                {
                    Positive = -1;
                    Byte = "-";

                    if (num2.Positive == -1)
                    {
                        Positive = 1;
                        Byte = "";
                    }
                }


                if (num1.Positive == num2.Positive)
                {
                    if (num1.Compare(num2) == 1)
                    {
                        Positive = num1.Positive;
                        Byte = num1.Byte;
                    }

                    if (num1.Compare(num2) == -1)
                    {
                        Positive = -1;
                        Byte = "-";

                    }
                }

                if (num1.Positive == -1)
                    if (num2.Positive == -1)
                    {
                        if (num1.Compare(num2) == 1)
                        {
                            Positive = -1;
                            Byte = "-";
                        }

                        if (num1.Compare(num2) == -1)
                        {
                            Positive = 1;
                            Byte = "";
                        }

                        if (num1.CompareTo(num2) == 0)
                        {
                            Positive = -1;
                            Byte = "-";
                        }
                    }

                string s = string.Join("", result.ToArray());

                if (True == 2)
                {
                    s = "1" + s;

                }



                Num = s;
                Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = {Byte}{Num}");
            }
            return num3;

        }

    }
}
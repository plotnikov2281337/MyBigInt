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
        }

        public void PrintBigInt()
        {
            Console.WriteLine($"{Byte}{Num}");
        }

        public int CompareTo(BigInt num2)
        {
            if (Positive != num2.Positive) return Positive.CompareTo(num2.Positive);
            if (Num.Length != num2.Num.Length) return Num.Length.CompareTo(num2.Num.Length);
            for (int i = 0; i <= Num.Length; i++)
            {
                if (Positive == -1|| num2.Positive == -1)
                {
                    if (Num[i] < num2.Num[i]) return 1;
                    if (Num[i] == num2.Num[i]) return 0;
                    if (Num[i] > num2.Num[i]) return -1;
                }
                else 
                {
                    if (Num[i] > num2.Num[i]) return 1;
                    if (Num[i] == num2.Num[i]) return 0;
                    if (Num[i] < num2.Num[i]) return -1;
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
        }

        public BigInt Plus(BigInt num1, BigInt num2)
        {
            string s = "";
            int True = 0; // для сложения, если числа из десяток переходят в сотни
            equate(num2); // добавление спереди нолей меньшему числу 
            for (int i = 0; i <= num1.Value.Length; i++) result.Add(1); // заполнение листа единичками для дальнейшей работы
            int NumI4;
            int NumI5 = 0;
            for (int i = numbers.Count - 1; i >= 0; i--) //цикл для всех условий
            {
                string NumS1 = (num1.Value[i].ToString());
                string NumS2 = (num2.Value[i].ToString());

                int NumI1 = int.Parse(NumS1);
                int NumI2 = int.Parse(NumS2);
                if (num1.Positive == num2.Positive) //если знаки равны
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
                if (num1.Positive != num2.Positive) // если знаки не равны, то есть один из знаков -
                {
                    NumI5 = 0;

                    if (num1.numbers[0] > num2.numbers[0]) // если первое число больше второго
                    {
                        NumI1 = NumI1 - NumI5;
                        NumI5 = 0;

                        if (NumI1 < NumI2)
                        {
                            int NumI3 = (NumI1 + 10) - NumI2;

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
                    if (num1.numbers[0] < num2.numbers[0]) //если второе больше
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

            BigInt num3 = new BigInt("", 1);

            if (result.Count == 0)
            {
                Console.WriteLine($"{num1.Byte}{num1.Num} + {num2.Byte}{num2.Num} = 0");
                Num = "0";
                Positive = 1;
                Byte = "";
            }

            else
            {

                string ByteS = "";

                if (num1.Positive == -1)
                {
                    ByteS =  "-";
                    Positive = -1;
                    Byte = "-";
                }

                if (num2.Positive == -1)
                {
                    ByteS =  "-";
                    Positive = -1;
                    Byte = "-";
                }

                if (True == 0)
                {
                    s = string.Join("", result.ToArray());
                    Num = s;
                    Console.WriteLine($"{num1.Byte}{num1.Num} + {num2.Byte}{num2.Num} = {Byte}{Num}");
                    

                }
                if (True == 1)
                {
                    s = "1" + string.Join("", result.ToArray());
                    Num = s;
                    Console.WriteLine($"{num1.Byte}{num1.Num} + {num2.Byte}{num2.Num} = {Byte}{Num}");

                }
            }

            return num3;
        }

        public BigInt Minus(BigInt num1, BigInt num2)
        {
            string s = "";
            int True = 0; // для сложения, если числа из десяток переходят в сотни
            equate(num2); // добавление спереди нолей меньшему числу 
            for (int i = 0; i <= num1.Value.Length; i++) result.Add(1); // заполнение листа единичками для дальнейшей работы
            int NumI4;
            int NumI5 = 0;
            for (int i = numbers.Count - 1; i >= 0; i--) //цикл для всех условий
            {
                string NumS1 = (num1.Value[i].ToString());
                string NumS2 = (num2.Value[i].ToString());
                int NumI1 = int.Parse(NumS1);
                int NumI2 = int.Parse(NumS2);
                if (num1.Positive == num2.Positive) //если знаки равны
                {
                    NumI5 = 0;
                    if (num1.numbers[0] > num2.numbers[0]) // если первое число больше второго
                    {
                        NumI1 = NumI1 - NumI5;
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
                    if (num1.numbers[0] < num2.numbers[0]) //если второе больше
                    {
                        NumI2 = NumI2 - NumI5;
                        NumI5 = 0;
                        if (NumI2 < NumI1)
                        {
                            int NumI3 = (NumI2 + 10) - NumI1;
                            result.Insert(i, NumI3);
                            result.RemoveAt(i + 1);
                            NumI5 = 1;
                        }
                        else
                        {
                            int NumI3 = NumI2 - NumI1;
                            result.Insert(i, NumI3);
                            result.RemoveAt(i + 1);
                        }
                    }
                }
                if (num1.Positive != num2.Positive) // если знаки не равны, то есть один из знаков -
                {
                    int NumI3 = NumI1 + NumI2 + NumI5;
                    NumI5 = 0;
                    if (NumI3 < 10)
                    {
                        result.Insert(i, NumI3);
                        result.RemoveAt(i + 1);
                    }
                    else
                    {
                        if (i == 0)
                            True = 1;
                        NumI4 = NumI3 - 10;
                        result.Insert(i, NumI4);
                        result.RemoveAt(i + 1);
                        NumI4 = 0;
                        NumI5 = 1;
                    }
                }
            }
            result.RemoveAt(Value.Length);
            BigInt num3 = new BigInt("", 1);
            if (result.Count == 0)
            {
                Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = 0");
                Num = "0";
                Positive = 1;
                Byte = "";
            }
            else
            {
                string ByteS = "";
                if (num2.Positive == -1)
                {
                    ByteS = "-";
                    Positive = -1;
                    Byte = "";
                }
                if (num2.Positive == 1)
                {
                    ByteS = "-";
                    Positive = -1;
                    Byte = "-";
                }
                if (True == 0)
                {
                    s = string.Join("", result.ToArray());
                    Num = s;
                    Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = {Byte}{Num}");
                }
                if (True == 1)
                {
                    s = "1" + string.Join("", result.ToArray());
                    Num = s;
                    Console.WriteLine($"{num1.Byte}{num1.Num} - {num2.Byte}{num2.Num} = {Byte}{Num}");
                }
            }
            return num3;
        }
    }
}
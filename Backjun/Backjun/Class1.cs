using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using System.Collections;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Transactions;
using System.Dynamic;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Backjun
{
    public class ToGold
    {
        public static void Alarm()
        {
            string Line;
            for (int k = 1; k <= 14; k++)
            {
                Line = "20221007" + (k + 7).ToString() + "0000111011111011140 11 < AlarmLabel >" + k.ToString() + "교시 시작 ||</AlarmLabel><AlarmSound>Happy</AlarmSound>";
                Console.WriteLine(Line);
                Line = "20221007" + (k + 7).ToString() + "5000111011111011140 11 < AlarmLabel >" + k.ToString() + "교시 끝 ||</AlarmLabel><AlarmSound>Happy</AlarmSound>";
                Console.WriteLine(Line);

            }

        }
        public static void B10869()
        {
            string[] InputA = Console.ReadLine().Split(' ');
            int A = int.Parse(InputA[0]);
            int B = int.Parse(InputA[1]);
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);

        }
        public static void B10926()
        {
            string Sinput = Console.ReadLine();
            Sinput = Sinput + "??!";
            Console.WriteLine(Sinput);
        }
        public static void B18108()
        {
            int Sinput = int.Parse(Console.ReadLine());
            Sinput = Sinput - 543;
            Console.WriteLine(Sinput);
        }
        public static void B3003()
        {
            string[] Inpt = (Console.ReadLine().Split(" "));
            int len_Inpt = Inpt.Length;
            int[] Int_Oupt = new int[len_Inpt];
            int[] correct = { 1, 1, 2, 2, 2, 8 };

            Int_Oupt[0] = correct[0] - int.Parse(Inpt[0]);
            Console.Write(Int_Oupt[0]);
            for (int i = 1; i < len_Inpt; i++)
            {
                Int_Oupt[i] = correct[i] - int.Parse(Inpt[i]);
                Console.Write(" " + Int_Oupt[i]);
            }
        }
        public static void B10430()
        {
            string[] Inpt = (Console.ReadLine().Split(" "));
            int len_Inpt = Inpt.Length;
            int[] Oupt = new int[len_Inpt];
            for (int i = 0; i < len_Inpt; i++)
            {
                Oupt[i] = int.Parse(Inpt[i]);
            }
            Console.WriteLine((Oupt[0] + Oupt[1]) % Oupt[2]);
            Console.WriteLine((Oupt[0] + Oupt[1]) % Oupt[2]);
            Console.WriteLine((Oupt[0] * Oupt[1]) % Oupt[2]);
            Console.WriteLine((Oupt[0] * Oupt[1]) % Oupt[2]);
        }
        public static void B2588()
        {
            int fst = int.Parse(Console.ReadLine());
            int scd = int.Parse(Console.ReadLine());
            Console.WriteLine(scd % 10 * fst);
            Console.WriteLine((scd / 10 % 10) * fst);
            Console.WriteLine((scd / 100) * fst);
            Console.WriteLine(scd * fst);
        }
        public static void B10171()
        {
            Console.WriteLine("\\    /\\");
            Console.WriteLine(" )  ( \')");
            Console.WriteLine("(  /  )");
            Console.WriteLine(" \\(__)|");
        }
        public static void B10172()
        {
            Console.WriteLine("|\\_/|");
            Console.WriteLine("|q p|   /}");
            Console.WriteLine("( 0 )\"\"\"\\");
            Console.WriteLine("|\"^\"`   |");
            Console.WriteLine("||_/=\\\\__|");
        }
        public static void B25083()
        {
            Console.WriteLine("         ,r'\"7");
            Console.WriteLine("r`-_   ,'  ,/");
            Console.WriteLine(" \\. \". L_r'");
            Console.WriteLine("   `~\\/");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
        }
        public static void B1330()
        {
            string[] Inpt = Console.ReadLine().Split(" ");
            int Temp = int.Parse(Inpt[0]) - int.Parse(Inpt[1]);
            if (Temp < 0)
            {
                Console.WriteLine("<");
            }
            else if (Temp > 0)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
        public static void B9498()
        {
            int Inpt = int.Parse(Console.ReadLine());
            if (Inpt >= 90)
            {
                Console.WriteLine("A");
            }
            else if (Inpt >= 80)
            {
                Console.WriteLine("B");
            }
            else if (Inpt >= 70)
            {
                Console.WriteLine("C");
            }
            else if (Inpt >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        public static void B2753()
        {
            int Inpt = int.Parse(Console.ReadLine());
            if (Inpt % 4 != 0)
            {
                Console.WriteLine(0);
            }
            else if (Inpt % 100 != 0)
            {
                Console.WriteLine(1);
            }
            else if (Inpt % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }


        }
        public static void B14681()
        {
            int fst = int.Parse(Console.ReadLine());
            int scd = int.Parse(Console.ReadLine());
            if (fst > 0)
            {
                if (scd > 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (scd > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
        public static void B2884()
        {
            string[] Inpt = Console.ReadLine().Split();
            int fst = int.Parse(Inpt[0]);
            int scd = int.Parse(Inpt[1]);
            if (fst == 0 && scd <= 44)
            {
                Console.WriteLine("23 " + (15 + scd).ToString());
            }
            else if (scd <= 44)
            {
                Console.WriteLine((fst - 1).ToString() + " " + (15 + scd).ToString());
            }
            else
            {
                Console.WriteLine(fst.ToString() + " " + (scd - 45).ToString());
            }
        }
        public static void B2525()
        {

            string[] Inpt = Console.ReadLine().Split();
            double fst = double.Parse(Inpt[0]);
            double scd = double.Parse(Inpt[1]);
            double Inpt2 = double.Parse(Console.ReadLine());

            double Time = fst + scd / 60.0f;

            double NextTime = Time + Inpt2 / 60.0f;

            if (NextTime >= 24.0f)
            {
                NextTime -= 24.0f;
            }

            Console.WriteLine((NextTime - NextTime % 1).ToString() + " " + (Math.Round(NextTime % 1 * 60.0f)).ToString());

        }
        public static void B2480()
        {

            string[] Inpt = Console.ReadLine().Split();
            int fst = int.Parse(Inpt[0]);
            int scd = int.Parse(Inpt[1]);
            int thd = int.Parse(Inpt[2]);

            if (fst == scd && scd == thd)
            {
                Console.WriteLine(10000 + fst * 1000);
            }
            else if (fst == scd || scd == thd)
            {
                Console.WriteLine(1000 + scd * 100);
            }
            else if (fst == thd)
            {
                Console.WriteLine(1000 + thd * 100);
            }
            else
            {
                Console.WriteLine(Math.Max(Math.Max(fst, scd), thd) * 100);
            }

        }
        public static void B2739()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(Inpt.ToString() + " * " + i.ToString() + " = " + (Inpt * i).ToString());
            }
        }
        public static void B10950()
        {
            int inpt = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inpt; i++)
            {
                string[] inpts = Console.ReadLine().Split(" ");
                Console.WriteLine(int.Parse(inpts[0]) + int.Parse(inpts[1]));
            }
        }
        public static void B8393()
        {
            int Inpt = int.Parse(Console.ReadLine());
            Console.WriteLine((Inpt * Inpt + Inpt) / 2);
        }
        public static void B25304()
        {
            int Inpt1 = int.Parse(Console.ReadLine());
            int Inpt2 = int.Parse(Console.ReadLine());
            int Answer = 0;
            for (int i = 1; i <= Inpt2; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                Answer += int.Parse(Inpts[0]) * int.Parse(Inpts[1]);
            }
            if (Answer == Inpt1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void B15552()
        {
            StringBuilder Answer = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(" "); ;


                Answer.AppendLine((int.Parse(s[0]) + int.Parse(s[1])).ToString());
            }
            Console.WriteLine(Answer.ToString());
        }
        public static void B11021()
        {
            StringBuilder SB = new StringBuilder();

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] Inpt = Console.ReadLine().Split(" ");

                SB.AppendLine("Case #" + (i + 1).ToString() + ": " + (int.Parse(Inpt[0]) + int.Parse(Inpt[1])).ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11022()
        {
            StringBuilder SB = new StringBuilder();

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] Inpt = Console.ReadLine().Split(" ");

                SB.AppendLine("Case #" + (i + 1).ToString() + ": " + int.Parse(Inpt[0]).ToString() + " + " + int.Parse(Inpt[1]).ToString() + " = " + (int.Parse(Inpt[0]) + int.Parse(Inpt[1])).ToString());
            }
            Console.WriteLine(SB.ToString());
        }

        public static void B2438()
        {
            StringBuilder SB = new StringBuilder();

            int Inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i < Inpt; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    SB.Append("*");
                }
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B2439()
        {
            StringBuilder SB = new StringBuilder();
            int Inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i < Inpt; i++)
            {
                for (int k = 1; k < Inpt - i; k++)
                {
                    SB.Append(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    SB.Append("*");
                }
                SB.AppendLine("");
            }

            Console.WriteLine(SB.ToString());
        }
        public static void B10871()
        {
            StringBuilder SB = new StringBuilder();
            string[] Inpts = Console.ReadLine().Split(" ");
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);
            string[] Inpts2 = Console.ReadLine().Split(" ");


            for (int i = 0; i < fst; i++)
            {
                if (int.Parse(Inpts2[i]) < scd)
                {
                    SB.Append(Inpts2[i] + " ");
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B10952()
        {
            StringBuilder SB = new StringBuilder();
            while (true)
            {
                string Inpt = Console.ReadLine();
                string[] Inpt_A = Inpt.Split(" ");

                if (Inpt == "0 0")
                {
                    break;
                }

                SB.AppendLine((int.Parse(Inpt_A[0]) + int.Parse(Inpt_A[1])).ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B10951()
        {
            StringBuilder SB = new StringBuilder();

            while (true)
            {

                string Inpt = Console.ReadLine();

                if (Inpt == null)
                {
                    break;
                }
                string[] Inpt_A = Inpt.Split(" ");


                SB.AppendLine((int.Parse(Inpt_A[0]) + int.Parse(Inpt_A[1])).ToString());
            }

            Console.WriteLine(SB.ToString());
        }
        public static void B1110()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int Temp = 0;
            Temp = Inpt;
            int Answer = 0;
            while (true)
            {
                Temp = (Temp % 10) * 10 + (Temp / 10 + Temp % 10) % 10;
                Answer++;
                if (Temp == Inpt) break;
            }
            Console.WriteLine(Answer);
        }
        public static void B10818()
        {
            int i = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int[] Aray = new int[Inpts.Length];
            int t = 0;
            foreach (string temp in Inpts)
            {
                Aray[t] = int.Parse(temp);
                t++;
            }
            Console.WriteLine(Aray.Min().ToString() + " " + Aray.Max().ToString());
        }
        public static void B2562()
        {
            int j = 0;
            int k = 0;
            double t = 0;
            for (int i = 0; i < 9; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                k++;
                if (temp > j)
                {
                    j = temp;
                    t += Math.Pow(2, k);

                }
            }
            Console.WriteLine(j);
            Console.WriteLine(Math.Floor(Math.Log(t, 2)));

        }
        public static void B3052()
        {
            int[] Aray = new int[10] { 43, 43, 43, 43, 43, 43, 43, 43, 43, 43 };
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int Temp = int.Parse(Console.ReadLine());
                foreach (int Temp2 in Aray)
                {
                    if (Temp % 42 == Temp2)
                    {
                        goto First;
                    }
                }

                count++;
            First:

                Aray[i] = Temp % 42;


            }
            Console.WriteLine(count);
        }
        public static void B1546()
        {
            int Inpt = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int[] Aray = new int[Inpt];

            for (int i = 0; i < Inpt; i++)
            {
                Aray[i] = int.Parse(Inpts[i]);
            }
            Console.WriteLine(((double)Aray.Sum() * 100 / (double)Inpt) / (double)Aray.Max());
        }
        public static void B8958()
        {
            int Inpt = int.Parse(Console.ReadLine());


            for (int i = 0; i < Inpt; i++)
            {
                int Temp = 0;
                int Score = 0;
                string Inpts = Console.ReadLine();
                foreach (char Temp2 in Inpts)
                {
                    if (Temp2.Equals('O'))
                    {
                        Temp += 1;
                        Score += Temp;
                    }
                    else
                    {
                        Temp = 0;
                    }
                }

                Console.WriteLine(Score);
            }
        }
        public static void B4344()
        {
            int Inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i < Inpt; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int Students = int.Parse(Inpts[0]);
                int[] Students_Score = new int[Students];
                int Index = 0;

                for (int j = 1; j <= Students; j++)
                {
                    Students_Score[j - 1] = int.Parse(Inpts[j]);
                }
                foreach (int Score in Students_Score)
                {
                    if (Score > Students_Score.Average())
                        Index++;
                }
                string Answer = string.Format("{0:F3}", ((double)Index / (double)Students) * 100);

                Console.WriteLine(Answer + "%");
            }
        }
        public static void B4673()
        {
            StringBuilder SB = new StringBuilder();
            List<int> Inpt = new List<int>();
            int Index = 0;
            for (int i = 1; i <= 10000; i++)
            {
                Inpt.Add(i);
            }
            Inpt.Add(10001);
            for (int i = 0; Inpt[i] <= 10000; i++)
            {
                SB.AppendLine(Inpt[i].ToString());
                int Temp = Inpt[i];
                while (true)
                {
                    Index = Make_Self_Number(Temp);
                    if (Index > 10000) break;
                    Inpt.Remove(Index);
                    Temp = Index;
                }
                Index = 0;
            }
            Console.WriteLine(SB.ToString());
        }
        public static int Make_Self_Number(int Inpt)
        {
            //1 만자리 나눔 천자리 나눔 백자리 나눔 십자리 나눔 일자리 나눔
            int Answer = 0;
            string Temp = Inpt.ToString();
            int[] inpts = new int[Temp.Length];
            int I = 0;
            foreach (char Num in Temp)
            {
                inpts[I] = Num - '0';
                I++;
            }
            Answer = Inpt + inpts.Sum();
            return Answer;
        }

        public static void B1065()
        {
            List<int> Hansu = new List<int> { };
            List<int> Hansu2 = new List<int> { 111, 123, 135, 147, 159, 210, 222, 234, 246, 258, 321, 333, 345, 357, 369, 420, 432, 444, 456, 468, 531, 543, 555, 567, 579, 630, 642, 654, 666, 678, 741, 753, 765, 777, 789, 840, 852, 864, 876, 888, 951, 963, 975, 987, 999 };
            for (int i = 1; i <= 99; i++)
                Hansu.Add(i);
            Hansu.AddRange(Hansu2);
            int Inpt = int.Parse(Console.ReadLine());
            int Count = 0;
            foreach (int hansu in Hansu)
            {
                if (Inpt >= hansu)
                {
                    Count++;
                }
                else if (Inpt < hansu)
                {
                    break;
                }
            }
            Console.WriteLine(Count);
        }
        public static void B11654()
        {
            string Inpt = Console.ReadLine();
            int Answer = Inpt[0];
            Console.WriteLine(Answer);
        }

        public static void B11720()
        {
            int Inpt_Num = int.Parse(Console.ReadLine());
            string Inpt = Console.ReadLine();
            int[] Inpts = new int[Inpt_Num];
            int Index = 0;
            foreach (char Num in Inpt)
            {
                Inpts[Index] = Num - '0';
                Index++;
            }

            Console.WriteLine(Inpts.Sum());
        }

        //97 ~ 122
        public static void B10809()
        {
            string Inpt = Console.ReadLine();
            for (int i = 97; i <= 122; i++)
            {
                int Index = 0;
                int Count = 0;
                foreach (char Alph in Inpt)
                {
                    if (Alph == i)
                    {
                        Index = 1;
                        Console.Write(Count.ToString() + " ");
                        break;
                    }
                    Count++;

                }
                if (Index == 0) Console.Write("-1 ");
            }
        }

        public static void B2675()
        {
            int Repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < Repeat; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int Num = int.Parse(Inpts[0]);
                foreach (char ch in Inpts[1])
                {
                    for (int t = 0; t < Num; t++)
                    {
                        Console.Write(ch);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void B1157()
        {
            string Inpt = Console.ReadLine().ToUpper();
            List<char> Alpha = new List<char>();
            List<int> Beta = new List<int>();
            foreach (char Ch in Inpt)
            {
                if (Alpha.Contains(Ch))
                {
                    Beta[Alpha.IndexOf(Ch)] += 1;
                }
                else
                {
                    Alpha.Add(Ch);
                    Beta.Add(1);
                }
            }
            if (Beta.FindAll(x => x == Beta.Max()).Count() != 1)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(Alpha[Beta.IndexOf(Beta.Max())]);
            }

        }

        public static void B1152()
        {
            string Inpt = Console.ReadLine();
            int count = 0;
            bool IsChar = false;
            foreach (char Ch in Inpt)
            {
                if (!Ch.Equals(' ') && IsChar == false)
                {
                    IsChar = true;
                }
                else if (Ch.Equals(' ') && IsChar == true)
                {
                    count++;
                    IsChar = false;
                }
            }
            if (IsChar == true)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        public static void B2908()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);

            if (100 * (fst % 10) + 10 * (fst / 10 % 10) + fst / 100 > 100 * (scd % 10) + 10 * (scd / 10 % 10) + scd / 100)
            {
                Console.WriteLine(100 * (fst % 10) + 10 * (fst / 10 % 10) + fst / 100);
            }
            else
            {
                Console.WriteLine(100 * (scd % 10) + 10 * (scd / 10 % 10) + scd / 100);
            }
        }
        /*
        ABC 123
        DEF 456
        GHI 789
        JKL 101112
        MNO 131415

        PQRS 16171819
        TUV  202122
        WXYZ 23242526

         
         */
        public static void B5622() //65~90
        {
            string Inpt = Console.ReadLine();
            int Time = 0;
            int answer = 0;
            foreach (char Ch in Inpt)
            {
                Time = 0;

                if (Ch - 64 <= 15)
                {

                    answer += (Ch - 65) / 3 + 3;
                }
                if (Ch - 64 >= 23)
                {
                    answer += 10;
                }
                else if (Ch - 64 >= 20)
                {
                    answer += 9;
                }
                else if (Ch - 64 >= 16)
                {
                    answer += 8;
                }
            }
            Console.WriteLine(answer);
        }
        public static void B2941()
        {
            string Inpt = Console.ReadLine();
            int Count = 0;
            int Pass = 0;
            for (int i = 0; i < Inpt.Length; i++)
            {
                if (Pass != 0)
                {
                    Pass -= 1;
                    continue;
                }
                if (i == Inpt.Length - 1)
                {
                    Count++;
                    continue;
                }
                if (Inpt[i] == 'd')
                {
                    if (Inpt[i + 1] == '-')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else if ((Inpt[i + 1] == 'z'))
                    {
                        if (i == Inpt.Length - 2)
                        {
                            Count++;
                            Count++;
                            break;
                        }
                        if (Inpt[i + 2] == '=')
                        {
                            Count++;
                            Pass = 2;
                            continue;

                        }
                        else
                        {
                            Count++;
                            Count++;
                            Pass = 1;
                            continue;

                        }
                    }
                    else
                    {
                        Count++;
                        continue;
                    }

                }
                else if (Inpt[i] == 'c')
                {
                    if (Inpt[i + 1] == '=')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else if (Inpt[i + 1] == '-')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else
                    {
                        Count++;
                        continue;
                    }
                }
                else if (Inpt[i] == 'l')
                {
                    if (Inpt[i + 1] == 'j')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else
                    {
                        Count++;
                        continue;
                    }
                }
                else if (Inpt[i] == 'n')
                {
                    if (Inpt[i + 1] == 'j')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else
                    {
                        Count++;
                        continue;
                    }
                }
                else if (Inpt[i] == 's')
                {
                    if (Inpt[i + 1] == '=')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else
                    {
                        Count++;
                        continue;
                    }
                }
                else if (Inpt[i] == 'z')
                {
                    if (Inpt[i + 1] == '=')
                    {
                        Count++;
                        Pass = 1;
                        continue;
                    }
                    else
                    {
                        Count++;
                        continue;
                    }
                }
                else
                {
                    Count++;
                }

            }
            Console.WriteLine(Count);
        }
        public static void B1316()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int Count = 0;


            for (int i = 0; i < Inpt; i++)
            {
                bool IsGroup = true;
                char Ch;
                List<int> Alph = new List<int>();
                string Inpts = Console.ReadLine();
                for (int t = 0; t < Inpts.Length; t++)
                {
                    IsGroup = true;
                    if (Alph.Find(x => x == Inpts[t]) == 0)
                    {
                        Alph.Add(Inpts[t]);
                    }
                    else
                    {
                        if (Inpts[t].Equals(Inpts[t - 1]))
                        {
                            continue;
                        }
                        else
                        {
                            IsGroup = false;
                            break;
                        }
                    }

                }
                if (IsGroup)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
        public static void B1712()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            double fst = (double)int.Parse(Inpts[0]);
            double scd = (double)int.Parse(Inpts[1]);
            double thd = (double)int.Parse(Inpts[2]);
            if (scd >= thd) Console.WriteLine("-1");
            else if ((fst / (thd - scd)) % 1 == 0) Console.WriteLine(fst / (thd - scd) + 1);
            else Console.WriteLine(Math.Ceiling(fst / (thd - scd)));
        }
        public static void B2292()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int Index = 0;
            if (Inpt == 1)
            {
                Console.WriteLine(Index + 1);

            }
            else
            {
                while (true)
                {
                    if (Inpt <= 1 + 6 + 6 * Index + 3 * Index * (Index + 1))
                    {
                        break;
                    }
                    Index++;
                }
                Console.WriteLine(Index + 2);
            }

        }
        public static void B1193()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int Index = 1;
            int Level = Index * (Index + 1) / 2;
            while (true)
            {
                if (Inpt <= Index * (Index + 1) / 2)
                {
                    break;
                }
                Index++;
            }
            Level = Index * (Index + 1) / 2;
            if (Index % 2 == 0)
            {
                int Temp = 1 + (Index - 1) * Index / 2;
                Console.WriteLine((1 + Inpt - Temp).ToString() + "/" + (Index - Inpt + Temp).ToString());
            }
            else
            {
                int Temp = 1 + (Index - 1) * Index / 2;
                Console.WriteLine((Index - (Inpt - Temp)).ToString() + "/" + (1 + Inpt - Temp).ToString());
            }
        }
        public static void B2869()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            double fst = (double)int.Parse(Inpts[0]);
            double scd = (double)int.Parse(Inpts[1]);
            double thd = (double)int.Parse(Inpts[2]);

            Console.WriteLine(1 + Math.Ceiling((thd - fst) / (fst - scd)));
        }
        public static void B10250()
        {

            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                if ((int.Parse(Inpts[2]) % int.Parse(Inpts[0]) == 0))
                {
                    Console.WriteLine(100 * (int.Parse(Inpts[0])) + (int.Parse(Inpts[2]) / (int.Parse(Inpts[0]))));
                }
                else
                    Console.WriteLine(100 * (int.Parse(Inpts[2]) % int.Parse(Inpts[0])) + (int.Parse(Inpts[2]) / (int.Parse(Inpts[0])) + 1));
            }
        }
        public static void B2775()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                int fst = int.Parse(Console.ReadLine());
                int scd = int.Parse(Console.ReadLine());
                //FST 층 SCD 호
                int[,] Apart = new int[fst + 1, scd + 1];
                for (int t = 0; t < scd + 1; t++)
                {
                    Apart[0, t] = t + 1;
                }

                for (int t = 1; t < fst + 1; t++)
                {
                    for (int t2 = 0; t2 < scd + 1; t2++)
                    {
                        int sum = 0;
                        for (int t3 = 0; t3 <= t2; t3++)
                        {
                            sum += Apart[t - 1, t3];
                        }
                        Apart[t, t2] = sum;
                    }
                }
                Console.WriteLine(Apart[fst, scd - 1]);

            }
        }
        public static void B2839()
        {
            int Inpt = int.Parse(Console.ReadLine());
            bool Index = true;
            for (int i = 0; 3 * i <= Inpt; i++)
            {
                if ((Inpt - 3 * i) % 5 == 0)
                {
                    Index = false;
                    Console.WriteLine(i + (Inpt - 3 * i) / 5);
                    break;
                }
            }
            if (Index) Console.WriteLine(-1);
        }
        public static void B10757()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            BigInteger fst = BigInteger.Parse(Inpts[0]);
            BigInteger scd = BigInteger.Parse(Inpts[1]);
            Console.WriteLine(fst + scd);

        }
        public static void B1002()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int R1 = int.Parse(Inpts[2]);
                int R2 = int.Parse(Inpts[5]);
                double R3 = Math.Sqrt(Math.Pow((int.Parse(Inpts[0]) - int.Parse(Inpts[3])), 2) + Math.Pow((int.Parse(Inpts[1]) - int.Parse(Inpts[4])), 2));
                if (Inpts[0] == Inpts[3] && Inpts[1] == Inpts[4])
                {
                    if (R1 == R2)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
                else if (R3 < R1 || R3 < R2)
                {
                    if (R1 > R2) // 무조건 R2가 더 크게
                    {
                        int temp = R1;
                        R1 = R2;
                        R2 = temp;
                    }// R2 > R1 > R3

                    if (R1 + R3 < R2) Console.WriteLine(0);
                    else if (R1 + R3 == R2) Console.WriteLine(1);
                    else if (R1 + R3 > R2) Console.WriteLine(2);

                }
                else if (R1 + R2 < R3) Console.WriteLine(0);
                else if (R1 + R2 == R3) Console.WriteLine(1);
                else if (R1 + R2 > R3) Console.WriteLine(2);

            }
        }
        public static void B1003()
        {
            int[,] Fibo = new int[41, 2];
            Fibo[0, 0] = 0;
            Fibo[0, 1] = 1;
            Fibo[1, 0] = 1;
            Fibo[1, 1] = 0;
            for (int i = 2; i <= 40; i++)
            {
                Fibo[i, 0] = Fibo[i - 1, 0] + Fibo[i - 2, 0];
                Fibo[i, 1] = Fibo[i - 1, 1] + Fibo[i - 2, 1];
            }
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                int Inpt2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibo[Inpt2, 1].ToString() + " " + Fibo[Inpt2, 0].ToString());
            }

        }
        public static void B1004()
        {
            int Case = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int Case2 = int.Parse(Console.ReadLine());
                Count = 0;
                for (int t = 0; t < Case2; t++)
                {
                    string[] Planet = Console.ReadLine().Split(" ");
                    double R1 = Math.Sqrt(Math.Pow((int.Parse(Inpts[0]) - int.Parse(Planet[0])), 2) + Math.Pow((int.Parse(Inpts[1]) - int.Parse(Planet[1])), 2));
                    double R2 = Math.Sqrt(Math.Pow((int.Parse(Inpts[2]) - int.Parse(Planet[0])), 2) + Math.Pow((int.Parse(Inpts[3]) - int.Parse(Planet[1])), 2));
                    bool R1_b = true;
                    bool R2_b = true;
                    if (R1 > int.Parse(Planet[2])) R1_b = false;
                    if (R2 > int.Parse(Planet[2])) R2_b = false;
                    if (R1_b ^ R2_b) Count++;
                }
                Console.WriteLine(Count);
            }
        }
        public static void B10807()
        {
            int Inpt = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Find = int.Parse(Console.ReadLine());
            int Count = 0;
            foreach (string Str in Inpts)
            {
                if (int.Parse(Str) == Find) Count++;
            }
            Console.WriteLine(Count);
        }
        public static void B5597()
        {
            bool[] Stu = new bool[30];
            for (int i = 0; i < 28; i++)
            {
                int Temp = int.Parse(Console.ReadLine());
                Stu[Temp - 1] = true;
            }
            int Index = 0;
            foreach (bool Bo in Stu)
            {
                Index++;
                if (Bo == false) Console.WriteLine(Index);
            }
        }
        public static void B2738()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            StringBuilder SB = new StringBuilder();
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);
            int[,] Aray = new int[fst, scd];
            for (int i = 0; i < fst; i++)
            {
                string[] Inpts2 = Console.ReadLine().Split(" ");
                for (int j = 0; j < scd; j++)
                {
                    Aray[i, j] = int.Parse(Inpts2[j]);
                }
            }
            for (int i = 0; i < fst; i++)
            {
                string[] Inpts2 = Console.ReadLine().Split(" ");
                for (int j = 0; j < scd; j++)
                {
                    SB.Append(Aray[i, j] + int.Parse(Inpts2[j]));
                    if (j < scd - 1) SB.Append(" ");
                }
                SB.AppendLine();
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B2566()
        {
            int Max = 0;
            int X_Pos = 0;
            int Y_Pos = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int Index = 0;
                foreach (string Str in Inpts)
                {
                    if (Max <= int.Parse(Str))
                    {
                        Max = int.Parse(Str);
                        X_Pos = i + 1;
                        Y_Pos = Index + 1;
                    }
                    Index++;
                }
            }
            Console.WriteLine(Max);
            Console.WriteLine(X_Pos.ToString() + " " + Y_Pos.ToString());
        }
        public static void B2563()
        {
            int[,] Do = new int[100, 100];
            int Case = int.Parse(Console.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Do[int.Parse(Inpts[0]) + j - 1, int.Parse(Inpts[1]) + k - 1] = 1;
                    }
                }
            }
            int Sum = 0;
            foreach (int Temp in Do) Sum += Temp;
            Console.WriteLine(Sum);
        }
        public static void B1978()
        {
            List<int> Sosu = Make_Sosu(1000);
            int Case = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Count = 0;
            foreach (string Str in Inpts)
            {
                if (Sosu.Find(x => x == int.Parse(Str)) > 0) Count++;
            }
            Console.WriteLine(Count);
        }
        public static void B2581()
        {
            int fst = int.Parse(Console.ReadLine());
            int scd = int.Parse(Console.ReadLine());
            List<int> Sosu = Make_Sosu(scd + 10000);
            int Sum = 0;
            int Min = 0;
            int Index = 0;
            for (int i = Sosu.FindIndex(x => x >= fst); Sosu[i] <= scd; i++)
            {
                if (Index == 0)
                {
                    Min = Sosu[i];
                    Index++;
                }
                Sum += Sosu[i];
            }
            if (Sum == 0) Console.WriteLine(-1);
            else
            {
                Console.WriteLine(Sum);
                Console.WriteLine(Min);
            }
        }
        public static void B11653()
        {
            List<int> Sosu = Make_Sosu(3200);
            int Inpt = int.Parse(Console.ReadLine());
            int Index = 0;
            if (Inpt == 1) ;
            else
            {
                for (int i = 0; i < Sosu.Count; i++)
                {
                    if (Inpt % Sosu[i] == 0)
                    {
                        Console.WriteLine(Sosu[i]);
                        if (Inpt / Sosu[i] == 1) break;
                        Inpt = Inpt / Sosu[i];
                        Index++;
                        i--;
                        continue;
                    }
                }
                if (Inpt > 3200) Console.WriteLine(Inpt);
            }
        }
        public static void B1929()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            bool[] c = Enumerable.Repeat<bool>(false, int.Parse(Inpts[1])).ToArray<bool>();
            StringBuilder SB = new StringBuilder();
            c[0] = true;

            for (int i = 2; i <= int.Parse(Inpts[1]); i++)
            {
                if (c[i - 1] == false)
                {
                    for (int j = i + i; j <= int.Parse(Inpts[1]); j = j + i)
                    {
                        c[j - 1] = true;
                    }
                    if (int.Parse(Inpts[0]) <= i && i <= int.Parse(Inpts[1]))
                    {
                        SB.AppendLine(i.ToString());
                    }
                }
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B4948()
        {
            while (true)
            {
                int Inpt = int.Parse(Console.ReadLine());
                if (Inpt == 0) break;
                int Count = 0;
                bool[] c = Enumerable.Repeat<bool>(false, 2 * Inpt).ToArray<bool>();
                c[0] = true;

                for (int i = 2; i <= 2 * Inpt; i++)
                {
                    if (c[i - 1] == false)
                    {
                        for (int j = i + i; j <= 2 * Inpt; j = j + i)
                        {
                            c[j - 1] = true;
                        }
                        if (Inpt < i && i <= 2 * Inpt)
                        {
                            Count++;
                        }
                    }
                }
                Console.WriteLine(Count);

            }
        }
        public static void B9020()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                int Inpt2 = int.Parse(Console.ReadLine());
                bool[] c = Enumerable.Repeat<bool>(false, Inpt2).ToArray<bool>();
                c[0] = true;

                for (int k = 2; k <= 2 * Inpt2; k++)
                {
                    if (c[k - 1] == false)
                    {
                        for (int j = k + k; j <= Inpt2; j = j + k)
                        {
                            c[j - 1] = true;
                        }
                        if (k >= Inpt2 / 2 && c[Inpt2 - k - 1] == false)
                        {
                            Console.Write(Inpt2 - k);
                            Console.Write(" ");
                            Console.WriteLine(k);
                            break;
                        }
                    }
                }
            }
        }
        public static List<int> Make_Sosu(int Inpt)
        {
            if (Inpt == 2) return new List<int> { 2 };
            if (Inpt == 3) return new List<int> { 2, 3 };
            if (Inpt == 4) return new List<int> { 2, 3 };
            if (Inpt == 5) return new List<int> { 2, 3, 5 };
            if (Inpt == 6) return new List<int> { 2, 3, 5 };
            if (Inpt == 7) return new List<int> { 2, 3, 5, 7 };
            if (Inpt == 8) return new List<int> { 2, 3, 5, 7 };
            if (Inpt == 9) return new List<int> { 2, 3, 5, 7 };
            if (Inpt == 10) return new List<int> { 2, 3, 5, 7 };



            List<int> Sosus = new List<int>();
            for (int i = 1; i <= Inpt; i++)
            {
                Sosus.Add(i);
            }
            Sosus.Remove(1);
            int Index = 0;
            while (true)
            {
                if (Index > Math.Sqrt(Inpt)) break;
                for (int i = 2; i * Sosus[Index] <= Inpt; i++)
                {
                    Sosus.Remove(Sosus[Index] * i);
                }
                Index++;
            }
            return Sosus;

        }
        public static void B1010()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Inpt; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                double fst = int.Parse(Inpts[0]);
                double scd = int.Parse(Inpts[1]);
                double thd = 1;
                double fth = 1;
                if (fst > scd - fst) fst = scd - fst;
                for (int j = 1; j <= fst; j++)
                {
                    thd = thd * (scd + 1 - j);
                    fth = fth * j;
                }
                Console.WriteLine(thd / fth);
            }
        }
        public static void B1009()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                string[] Inpts = Console.ReadLine().Split(" ");
                int b = int.Parse(Inpts[0]) % 10;
                switch (b)
                {
                    case 0:
                        Console.WriteLine(10);
                        break;
                    case 1:
                        Console.WriteLine(1);
                        break;
                    case 2:
                        Console.WriteLine(Math.Pow(2, int.Parse(Inpts[1]) % 4 + 4) % 10);
                        break;
                    case 3:
                        Console.WriteLine(Math.Pow(3, int.Parse(Inpts[1]) % 4 + 4) % 10);
                        break;
                    case 4:
                        Console.WriteLine(Math.Pow(4, int.Parse(Inpts[1]) % 2 + 2) % 10);
                        break;
                    case 5:
                        Console.WriteLine(5);
                        break;
                    case 6:
                        Console.WriteLine(6);
                        break;
                    case 7:
                        Console.WriteLine(Math.Pow(7, int.Parse(Inpts[1]) % 4 + 4) % 10);
                        break;
                    case 8:
                        Console.WriteLine(Math.Pow(8, int.Parse(Inpts[1]) % 4 + 4) % 10);
                        break;
                    case 9:
                        Console.WriteLine(Math.Pow(9, int.Parse(Inpts[1]) % 2 + 2) % 10);
                        break;
                }
            }
        }
        public static void B2750()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] ints = new int[Inpt];
            int Count = 1;

            for (int i = 0; i < Inpt; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            while (Count != 0)
            {
                Count = 0;
                for (int i = 0; i < Inpt - 1; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        int temp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = temp;
                        Count = 1;
                    }
                }
            }
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
        public static void B2587()
        {
            int[] ints = new int[5];
            int Count = 1;

            for (int i = 0; i < 5; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            while (Count != 0)
            {
                Count = 0;
                for (int i = 0; i < 5 - 1; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        int temp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = temp;
                        Count = 1;
                    }
                }
            }
            Console.WriteLine(ints.Sum() / 5);
            Console.WriteLine(ints[2]);

        }
        public static void B25305()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int Inpt = int.Parse(Inpts[0]);
            int[] ints = new int[Inpt];
            int Count = 1;
            string[] Score = Console.ReadLine().Split(" ");
            for (int i = 0; i < Inpt; i++)
            {
                ints[i] = int.Parse(Score[i]);
            }
            while (Count != 0)
            {
                Count = 0;
                for (int i = 0; i < Inpt - 1; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        int temp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = temp;
                        Count = 1;
                    }
                }
            }
            Console.WriteLine(ints[int.Parse(Inpts[0]) - int.Parse(Inpts[1])]);

        }
        public static void B2751()
        {
            int Inpt = int.Parse(Console.ReadLine());
            List<int> Ints = new List<int>();
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < Inpt; i++)
            {
                Ints.Add(int.Parse(Console.ReadLine()));
            }
            Ints.Sort();
            foreach (int i in Ints)
            {
                SB.AppendLine(i.ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        /*
            int Inpt = int.Parse(Console.ReadLine());
            int[] Ints = new int[Inpt];
            int[] Counts = new int[10000];
            StringBuilder SB = new StringBuilder();
            for(int i = 0; i < Inpt; i++)
            {
                Ints[i] = int.Parse(Console.ReadLine());
                Counts[Ints[i]-1]++;
            }
            int[] Double_Counts = new int[10000];
            Double_Counts[0] = Counts[0];
            int[] New_Ints = new int[Inpt+1];
            for( int i = 1; i < 10000; i++)
            {
                Double_Counts[i] = Double_Counts[i - 1] + Counts[i];
            }
            for (int i = Inpt - 1; i >= 0; i -= 1)
            {
                New_Ints[Double_Counts[Ints[i]-1]] = Ints[i] ;
                Double_Counts[Ints[i]-1] -= 1;
            }
            foreach(int i in New_Ints)
            {
                if (i == 0) continue;
                SB.AppendLine(i.ToString());
            }
            Console.WriteLine(SB.ToString());
            */
        public static void B10959()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            int count = Convert.ToInt32(reader.ReadLine());
            int[] list = new int[10001];

            for (int i = 0; i < count; i++)
            {
                list[int.Parse(reader.ReadLine())]++;
            }
            for (int i = 0; i <= 10000; i++)
            {
                if (list[i] != 0)
                {
                    for (int j = 0; j < list[i]; j++)
                    {
                        print.WriteLine(i);
                    }
                }
            }
        }
        public static void B2475()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int fst = (int)Math.Pow(int.Parse(Inpts[0]), 2);
            int scd = (int)Math.Pow(int.Parse(Inpts[1]), 2);
            int thd = (int)Math.Pow(int.Parse(Inpts[2]), 2);
            int foth = (int)Math.Pow(int.Parse(Inpts[3]), 2);
            int fith = (int)Math.Pow(int.Parse(Inpts[4]), 2);
            int temp = fst + scd + thd + foth + fith;

            Console.WriteLine(temp % 10);
        }
        public static void B4153()
        {
            while (true)
            {
                string Inpt = Console.ReadLine();
                if (Inpt == "0 0 0") break;
                string[] Inpts = Inpt.Split(" ");
                List<int> fltmxm = new List<int>();
                fltmxm.Add(int.Parse(Inpts[0]));
                fltmxm.Add(int.Parse(Inpts[1]));
                fltmxm.Add(int.Parse(Inpts[2]));
                fltmxm.Sort();
                int fst = fltmxm[0];
                int scd = fltmxm[1];
                int thd = fltmxm[2];
                if (fst * fst + scd * scd == thd * thd) Console.WriteLine("right");
                else Console.WriteLine("wrong");
            }
        }
        public static void B1018()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);
            bool[,] Chess = new bool[fst, scd];
            int Min = 2600;
            for (int i = 0; i < fst; i++)
            {
                string Inpts2 = Console.ReadLine();
                for (int j = 0; j < scd; j++)
                {
                    if (Inpts2[j] == 'B') Chess[i, j] = false;
                    else Chess[i, j] = true;
                }
            }
            for (int i = 0; i <= fst - 8; i++)
            {
                for (int j = 0; j <= scd - 8; j++)
                {
                    int Temp = Compare_Count(Chess, i, j);
                    if (Min > Temp) Min = Temp;
                }
            }
            Console.WriteLine(Min);
        }
        public static int Compare_Count(bool[,] Chess, int x, int y)
        {
            int Count = 0;
            bool[,] Chess1 = new bool[8, 8] { { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true } };
            bool[,] Chess2 = new bool[8, 8] { { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false }, { false, true, false, true, false, true, false, true }, { true, false, true, false, true, false, true, false } };
            int Temp1 = 0;
            int Temp2 = 0;
            for (int i = x; i < x + 8; i++)
            {
                for (int j = y; j < y + 8; j++)
                {
                    if (Chess[i, j] != Chess1[i - x, j - y])
                    {
                        Temp1++;
                    }
                    else if (Chess[i, j] != Chess2[i - x, j - y])
                    {
                        Temp2++;
                    }
                }
            }
            if (Temp1 == 0 || Temp2 == 0) return 0;
            if (Temp1 >= Temp2) Count = Temp2;
            else Count = Temp1;

            return Count;
        }
        public static void B2920()
        {
            string Inpts = Console.ReadLine();
            if (Inpts == "1 2 3 4 5 6 7 8") Console.WriteLine("ascending");
            else if (Inpts == "8 7 6 5 4 3 2 1") Console.WriteLine("descending");
            else Console.WriteLine("mixed");
        }
        public static void B2742()
        {
            int Inpt = int.Parse(Console.ReadLine());
            StringBuilder SB = new StringBuilder();
            for (int x = Inpt; x > 0; x--)
            {
                SB.AppendLine(x.ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B2577()
        {
            int fst = int.Parse(Console.ReadLine());
            int scd = int.Parse(Console.ReadLine());
            int thd = int.Parse(Console.ReadLine());
            int Temp = fst * scd * thd;
            string temps = Temp.ToString();
            int[] Count = new int[10];
            foreach (char c in temps)
            {
                int t = c - '0';
                Count[t]++;
            }
            foreach (int t in Count)
            {
                Console.WriteLine(t);
            }


        }
        public static void B2741()
        {
            int Inpt = int.Parse(Console.ReadLine());
            StringBuilder SB = new StringBuilder();

            for (int x = 1; x <= Inpt; x++)
            {
                SB.AppendLine(x.ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B2108()
        {
            int Case = int.Parse(Console.ReadLine());
            int[] list = new int[8001];
            int[] list2 = new int[Case];
            int Index = 0;
            bool Indx = false;
            int Remember = 0;
            int Max = 0;
            for (int i = 0; i < Case; i++)
            {

                int Temp = int.Parse(Console.ReadLine()) + 4000;
                list[Temp]++;
                if (Max < list[Temp])
                {
                    Max = list[Temp];
                    Remember = Temp;
                    Indx = false;
                }
                else if (Max == list[Temp])
                {
                    Indx = true;
                    Remember = list[Temp];
                }
            }
            for (int i = 0; i <= 8000; i++)
            {
                if (list[i] != 0)
                {
                    for (int j = 0; j < list[i]; j++)
                    {
                        list2[Index] = i;
                        Index++;
                    }
                }
            }
            if (Math.Round((double)list2.Sum() / (double)Case - 4000, 0) == -0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Round((double)list2.Sum() / (double)Case - 4000, 0));

            }
            Console.WriteLine(list2[(Case + 1) / 2 - 1] - 4000);
            if (Indx)
            {
                int Temp2 = 0;
                for (int i = 0; i < 8001; i++)
                {
                    if (list[i] == Remember)
                    {
                        if (Temp2 == 0)
                        {
                            Temp2++;
                            continue;
                        }

                        Console.WriteLine(i - 4000);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(Remember - 4000);
            }
            Console.WriteLine(list2.Max() - list2.Min());


        }
        public static void B1427()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Num = new int[10];
            int Index = 0;
            while (true)
            {
                if (Math.Pow(10, Index) > Inpt) break;
                if (Index == 0) Num[Inpt % 10]++;
                else
                {
                    Num[((int)(Inpt / Math.Pow(10, Index) % 10))]++;
                }
                Index++;
            }
            for (int i = 0; i < 10; i++)
            {
                while (Num[9 - i] != 0)
                {
                    Console.Write(9 - i);
                    Num[9 - i]--;
                }
            }
        }
        public static void B1650()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            int Case = int.Parse(reader.ReadLine());
            List<double> Doublist = new List<double>();
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = reader.ReadLine().Split(" ");
                Doublist.Add(int.Parse(Inpts[0]) + 1000000 + ((double)int.Parse(Inpts[1]) + 1000000) / 10000000);
            }
            Doublist.Sort();
            foreach (double Temp in Doublist)
            {
                int fst = ((int)Temp - 1000000);
                int scd = (int)(Math.Round((Temp % 1 * 10000000 - 1000000)));
                print.WriteLine(fst.ToString() + " " + scd.ToString());
            }
        }
        public static void B1259()
        {
            StringBuilder SB = new StringBuilder();

            while (true)
            {
                string Inpt = Console.ReadLine();
                if (Inpt == "0") break;
                if (IsPalindrome2(Inpt) == 1) SB.AppendLine("yes");
                else SB.AppendLine("no");
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B1920()
        {
            int Tcase = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Acase = int.Parse(Console.ReadLine());
            string[] Inpts2 = Console.ReadLine().Split(" ");
            bool[] Table1 = new bool[2000000000];// 0부터 20억-1까지
            bool[] Table2 = new bool[2000000000]; // -1부터 -20억까지
            bool[] Table3 = new bool[2000000000]; // 20억부터 그 외/ -20억-1 부터 그 외
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < Tcase; i++)
            {
                int temp = int.Parse(Inpts[i]);
                if (temp >= 0)
                {
                    if (temp >= 2000000000) Table3[temp - 2000000000] = true;
                    else Table1[temp] = true;
                }
                else
                {
                    if (temp < -2000000000) Table3[temp + 4000000000] = true;
                    else Table2[temp + 2000000000] = true;
                }

            }
            foreach (string Inpt in Inpts2)
            {
                int temp = int.Parse(Inpt);
                bool Temp = false;
                if (temp >= 0)
                {
                    if (temp >= 2000000000) Temp = Table3[temp - 2000000000];
                    else Temp = Table1[temp];
                }
                else
                {
                    if (temp < -2000000000) Temp = Table3[temp + 4000000000];
                    else Temp = Table2[temp];
                }
                if (Temp == true) SB.AppendLine("1");
                else SB.AppendLine("0");
            }
            Console.WriteLine(SB.ToString());

        }

        public static int Recursion2(string Inpt, int S, int L)
        {
            if (S >= L) return 1;
            else if (Inpt[S] != Inpt[L]) return 0;
            else return Recursion2(Inpt, S + 1, L - 1);
        }
        public static int IsPalindrome2(string Inpt)
        {
            return Recursion2(Inpt, 0, Inpt.Length - 1);
        }
        public static void B11866()
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("<");
            string[] Inpts = Console.ReadLine().Split();
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);
            bool[] Table = new bool[fst];
            int Index = 0; // table 주소
            int Count = 0; // 3번
            for (int i = 0; i < fst; i++)
            {
                Count = 0;
                while (true)
                {
                    if (Table[Index] == false)
                    {
                        Count++;
                        if (Count == scd)
                        {
                            Table[Index] = true;
                            SB.Append((Index + 1).ToString());
                            if (i != fst - 1) SB.Append(", ");
                            break;
                        }

                        Index++;
                        if (Index == fst) Index = Index - fst;
                    }
                    else  // true 일때 = 이미 없어진 것
                    {
                        Index++;
                        if (Index == fst) Index = Index - fst;
                    }
                }
            }
            SB.Append(">");
            Console.WriteLine(SB.ToString());

        }
        public static void B11050()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int fst = int.Parse(Inpts[0]);
            int scd = int.Parse(Inpts[1]);

            int Answer = 1;
            for (int i = 0; i < scd; i++)
            {
                Answer *= fst - i;
            }
            for (int i = 1; i <= scd; i++)
            {
                Answer = Answer / i;
            }
            Console.WriteLine(Answer);
        }
        public static void B10816()
        {
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Case2 = int.Parse(Console.ReadLine());
            string[] Inpts2 = Console.ReadLine().Split(" ");
            int[] Table = new int[20000002];
            foreach (string str in Inpts)
            {
                Table[int.Parse(str) + 10000000]++;
            }
            for (int i = 0; i < Inpts2.Length; i++)
            {
                int Temp = int.Parse(Inpts2[i]);
                SB.Append(Table[Temp + 10000000]);
                if (i != Inpts2.Length - 1) SB.Append(" ");
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B11382()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            Console.WriteLine(double.Parse(Inpts[0]) + double.Parse(Inpts[1]) + double.Parse(Inpts[2]));
        }
        public static void B2420()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            double fst = double.Parse(Inpts[0]);
            double scd = double.Parse(Inpts[1]);
            Console.WriteLine(Math.Abs(fst - scd));
        }
        public static void B15964()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            double fst = double.Parse(Inpts[0]);
            double scd = double.Parse(Inpts[1]);
            Console.WriteLine(fst * fst - scd * scd);
            string Inpt = Console.ReadLine();
            Console.WriteLine(Inpt.Length);
        }
        public static void B2744()
        {
            string Inpt = Console.ReadLine();
            string Output = "";
            for (int i = 0; i < Inpt.Length; i++)
            {
                if (Inpt[i] > 95)
                {
                    char Temp = (char)(Inpt[i] - 32);
                    Console.Write(Temp);
                }
                else
                {
                    char Temp = (char)(Inpt[i] + 32);
                    Console.Write(Temp);
                }
            }
        }
        public static void B11718()
        {
            for (int i = 0; i < 100; i++)
            {
                string Inpt = "";
                Inpt = Console.ReadLine();
                Console.WriteLine(Inpt);
            }
        }
        public static void B2754()
        {
            string Inpt = Console.ReadLine();
            if (Inpt == "A+") Console.WriteLine("4.3");
            else if (Inpt == "A0") Console.WriteLine("4.0");
            else if (Inpt == "A-") Console.WriteLine("3.7");
            else if (Inpt == "B+") Console.WriteLine("3.3");
            else if (Inpt == "B0") Console.WriteLine("3.0");
            else if (Inpt == "B-") Console.WriteLine("2.7");
            else if (Inpt == "C+") Console.WriteLine("2.3");
            else if (Inpt == "C0") Console.WriteLine("2.0");
            else if (Inpt == "C-") Console.WriteLine("1.7");
            else if (Inpt == "D+") Console.WriteLine("1.3");
            else if (Inpt == "D0") Console.WriteLine("1.0");
            else if (Inpt == "D-") Console.WriteLine("0.7");
            else Console.WriteLine("0.0");



        }
        public static void B9086()
        {
            int Inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Inpt; i++)
            {
                string Inpts = Console.ReadLine();
                string fst = "" + Inpts[0];
                string lst = "" + Inpts[Inpts.Length - 1];
                Console.WriteLine(fst + lst);
            }
        }
        public static void B1181()
        {
            int cnt = int.Parse(Console.ReadLine());

            List<string> slist = new List<string>();


            for (int i = 0; i < cnt; i++)
            {
                string word = Console.ReadLine();
                slist.Add(word.ToLower());
            }

            slist = slist.Distinct().ToList();
            slist.Sort();
            slist = slist.OrderBy(x => x.Length).ToList();

            foreach (string ans in slist)
            {
                Console.WriteLine(ans);
            }


        }
        public static void B10814()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            int Case = int.Parse(reader.ReadLine());
            List<string[]> Inpts = new List<string[]>();
            for (int i = 0; i < Case; i++)
            {
                Inpts.Add(reader.ReadLine().Split(" "));
            }
            Inpts = Inpts.OrderBy(x => int.Parse(x[0])).ToList();
            foreach (string[] Str in Inpts)
            {
                print.WriteLine(Str[0] + " " + Str[1]);
            }
        }
        public static void B18870()
        {
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Index = 0;
            int[] Inpts2 = Array.ConvertAll(Inpts, Int32.Parse);
            int[] Inpts3 = Array.ConvertAll(Inpts.Distinct().ToArray(), Int32.Parse);
            Array.Sort(Inpts3);
            foreach (int dat in Inpts2)
            {
                SB.Append(lower_bound(dat, Inpts3, Inpts3.Length - 1) + " ");
            }
            Console.WriteLine(SB.ToString());
        }
        public static int lower_bound(int target, int[] vdata, int length)
        {
            int left = 0;
            int right = length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (vdata[mid] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }
            return right;
        }
        public static void B10872()
        {
            int Answer = Factorial(1, int.Parse(Console.ReadLine()));
            Console.WriteLine(Answer);
        }
        public static int Factorial(int Answer, int Inpt)
        {
            if (Inpt == 0) return 1;
            if (Inpt == 1)
            {
                return Answer;
            }

            Answer = Answer * Inpt;
            return Factorial(Answer, Inpt - 1);
        }
        public static void B10870()
        {
            int Answer = Pibonachi(0, 1, 2, int.Parse(Console.ReadLine()));
            Console.WriteLine(Answer);
        }
        public static int Pibonachi(int Fst, int Scd, int Index, int Inpt)
        {
            if (Inpt == 0) return 0;
            if (Inpt == 1) return 1;
            if (Inpt == 2) return 1;
            if (Index % 2 == 0)
            {
                Fst = Fst + Scd;
            }
            else
            {
                Scd = Scd + Fst;
            }
            if (Index == Inpt)
            {
                if (Index % 2 == 0) return Fst;
                return Scd;
            }
            Index++;

            return Pibonachi(Fst, Scd, Index, Inpt);
        }
        public static int[] Recursion(string Inpt, int S, int L, int Count)
        {
            Count++;
            if (S >= L) return new int[2] { 1, Count };
            else if (Inpt[S] != Inpt[L]) return new int[2] { 0, Count };
            else return Recursion(Inpt, S + 1, L - 1, Count);
        }
        public static int[] IsPalindrome(string Inpt, int Count)
        {
            return Recursion(Inpt, 0, Inpt.Length - 1, Count);
        }
        public static void B25501()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var Writer = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                int Count = 0;
                string Inpt = Reader.ReadLine();
                Writer.WriteLine(IsPalindrome(Inpt, Count)[0].ToString() + " " + (IsPalindrome(Inpt, Count)[1].ToString()));
            }
        }
        public static void B1085()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            List<int> Num = new List<int>();
            Num.Add(int.Parse(Inpts[0]));
            Num.Add(int.Parse(Inpts[1]));
            Num.Add(int.Parse(Inpts[2]) - int.Parse(Inpts[0]));
            Num.Add(int.Parse(Inpts[3]) - int.Parse(Inpts[1]));
            Console.WriteLine(Num.Min());
        }
        public static void B3009()
        {
            string[] fst = Console.ReadLine().Split(" ");
            string[] scd = Console.ReadLine().Split(" ");
            string[] thd = Console.ReadLine().Split(" ");
            List<int> xA = new List<int>();
            List<int> yA = new List<int>();
            xA.Add(int.Parse(fst[0]));
            xA.Add(int.Parse(scd[0]));
            xA.Add(int.Parse(thd[0]));
            yA.Add(int.Parse(fst[1]));
            yA.Add(int.Parse(scd[1]));
            yA.Add(int.Parse(thd[1]));
            for (int i = 0; i < 3; i++)
            {
                int temp = xA[i];
                if (xA.Where(x => x.Equals(temp)).Count() == 1)
                {

                    Console.Write(xA[i]);
                }
            }
            Console.Write(" ");
            for (int i = 0; i < 3; i++)
            {
                int temp = yA[i];
                if (yA.Where(x => x.Equals(temp)).Count() == 1)
                {
                    Console.WriteLine(yA[i]);
                }
            }


        }
        public static void B2447()
        {
            int Inpt = int.Parse(Console.ReadLine());
            if (Inpt == 3)
            {
                Console.WriteLine("***");
                Console.WriteLine("* *");
                Console.WriteLine("***");
            }
            else
            {
                int Inpt2 = (int)Math.Log(Inpt, 3);
                bool[,] Form = new bool[Inpt, Inpt];
                MakeStar10(Form, 0, 0, Inpt2);
                for (int i = 0; i < Inpt; i++)
                {
                    for (int j = 0; j < Inpt; j++)
                    {
                        if (Form[i, j] == true)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }


        }
        public static void MakeStar10(bool[,] form, int x, int y, int Inpt)
        {
            if (Inpt == 1)
            {
                bool[,] Elmt = new bool[3, 3] { { true, true, true }, { true, false, true }, { true, true, true } };
                Fill(form, Elmt, x, y, 3);
            }
            else
            {
                bool[,] empty = new bool[Inpt - 1, Inpt - 1];
                MakeStar10(form, x, y, Inpt - 1);
                MakeStar10(form, x + (int)Math.Pow(3, Inpt - 1), y, Inpt - 1);
                MakeStar10(form, x + 2 * (int)Math.Pow(3, Inpt - 1), y, Inpt - 1);
                MakeStar10(form, x, y + (int)Math.Pow(3, Inpt - 1), Inpt - 1);
                Fill(form, empty, x + (int)Math.Pow(3, Inpt - 1), y + (int)Math.Pow(3, Inpt - 1), Inpt - 1);
                MakeStar10(form, x + 2 * (int)Math.Pow(3, Inpt - 1), y + (int)Math.Pow(3, Inpt - 1), Inpt - 1);
                MakeStar10(form, x, y + 2 * (int)Math.Pow(3, Inpt - 1), Inpt - 1);
                MakeStar10(form, x + (int)Math.Pow(3, Inpt - 1), y + 2 * (int)Math.Pow(3, Inpt - 1), Inpt - 1);
                MakeStar10(form, x + 2 * (int)Math.Pow(3, Inpt - 1), y + 2 * (int)Math.Pow(3, Inpt - 1), Inpt - 1);

            }
        }
        public static void Fill(bool[,] form, bool[,] Inpt, int x, int y, int size)
        {
            for (int i = y; i < y + size; i++)
            {
                for (int j = x; j < x + size; j++)
                {
                    form[y - 1, x - 1] = Inpt[y - i, x - j];
                }
            }
        }

    }
    public class ToGold2
    {
        public static void B1920()
        {
            int Tcase = int.Parse(Console.ReadLine());
            string[] Inpts = Console.ReadLine().Split(" ");
            int Acase = int.Parse(Console.ReadLine());
            string[] Inpts2 = Console.ReadLine().Split(" ");
            StringBuilder SB = new StringBuilder();
            int[] Table = new int[Tcase];

            for (int i = 0; i < Tcase; i++)
            {
                Table[i] = int.Parse(Inpts[i]);
            }
            Array.Sort(Table);
            foreach (string S in Inpts2)
            {
                int Temp = int.Parse(S);
                if (Array.BinarySearch(Table, Temp) < 0) SB.AppendLine("0");
                else SB.AppendLine("1");
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B2164()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Table = new int[Inpt];
            for (int i = 0; i < Inpt; i++)
            {
                Table[i] = i + 1;
            }
            Console.WriteLine(B2164_1(Table));
        }
        public static int B2164_1(int[] Table)
        {
            if (Table.Length == 1) return Table[0];
            if (Table.Length == 2) return Table[1];
            if (Table.Length == 3) return Table[1];
            if (Table.Length % 2 == 0)
            {
                int[] Temp = new int[Table.Length / 2];
                for (int i = 0; i < Table.Length / 2; i++)
                {
                    Temp[i] = Table[2 * i + 1];
                }
                return B2164_1(Temp);
            }
            else
            {
                int[] Temp = new int[Table.Length / 2];
                for (int i = 0; i < Table.Length / 2; i++)
                {
                    if (i == 0)
                    {
                        Temp[Table.Length / 2 - 1] = Table[2 * i + 1];
                        continue;
                    }
                    Temp[i - 1] = Table[2 * i + 1];
                }
                return B2164_1(Temp);
            }
        }
        public static void B2609()
        {
            string[] Inpt = Console.ReadLine().Split(" ");
            int fst = int.Parse(Inpt[0]);
            int scd = int.Parse(Inpt[1]);
            int Gcf = GCF(fst, scd);
            Console.WriteLine(Gcf);
            int ftmp = fst / Gcf;
            int stmp = scd / Gcf;
            Console.WriteLine(Gcf * ftmp * stmp);


        }
        public static int GCF(int Fst, int Scd)
        {
            int[] Sosu = new int[1229] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1009, 1013, 1019, 1021, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499, 1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583, 1597, 1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697, 1699, 1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789, 1801, 1811, 1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889, 1901, 1907, 1913, 1931, 1933, 1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999, 2003, 2011, 2017, 2027, 2029, 2039, 2053, 2063, 2069, 2081, 2083, 2087, 2089, 2099, 2111, 2113, 2129, 2131, 2137, 2141, 2143, 2153, 2161, 2179, 2203, 2207, 2213, 2221, 2237, 2239, 2243, 2251, 2267, 2269, 2273, 2281, 2287, 2293, 2297, 2309, 2311, 2333, 2339, 2341, 2347, 2351, 2357, 2371, 2377, 2381, 2383, 2389, 2393, 2399, 2411, 2417, 2423, 2437, 2441, 2447, 2459, 2467, 2473, 2477, 2503, 2521, 2531, 2539, 2543, 2549, 2551, 2557, 2579, 2591, 2593, 2609, 2617, 2621, 2633, 2647, 2657, 2659, 2663, 2671, 2677, 2683, 2687, 2689, 2693, 2699, 2707, 2711, 2713, 2719, 2729, 2731, 2741, 2749, 2753, 2767, 2777, 2789, 2791, 2797, 2801, 2803, 2819, 2833, 2837, 2843, 2851, 2857, 2861, 2879, 2887, 2897, 2903, 2909, 2917, 2927, 2939, 2953, 2957, 2963, 2969, 2971, 2999, 3001, 3011, 3019, 3023, 3037, 3041, 3049, 3061, 3067, 3079, 3083, 3089, 3109, 3119, 3121, 3137, 3163, 3167, 3169, 3181, 3187, 3191, 3203, 3209, 3217, 3221, 3229, 3251, 3253, 3257, 3259, 3271, 3299, 3301, 3307, 3313, 3319, 3323, 3329, 3331, 3343, 3347, 3359, 3361, 3371, 3373, 3389, 3391, 3407, 3413, 3433, 3449, 3457, 3461, 3463, 3467, 3469, 3491, 3499, 3511, 3517, 3527, 3529, 3533, 3539, 3541, 3547, 3557, 3559, 3571, 3581, 3583, 3593, 3607, 3613, 3617, 3623, 3631, 3637, 3643, 3659, 3671, 3673, 3677, 3691, 3697, 3701, 3709, 3719, 3727, 3733, 3739, 3761, 3767, 3769, 3779, 3793, 3797, 3803, 3821, 3823, 3833, 3847, 3851, 3853, 3863, 3877, 3881, 3889, 3907, 3911, 3917, 3919, 3923, 3929, 3931, 3943, 3947, 3967, 3989, 4001, 4003, 4007, 4013, 4019, 4021, 4027, 4049, 4051, 4057, 4073, 4079, 4091, 4093, 4099, 4111, 4127, 4129, 4133, 4139, 4153, 4157, 4159, 4177, 4201, 4211, 4217, 4219, 4229, 4231, 4241, 4243, 4253, 4259, 4261, 4271, 4273, 4283, 4289, 4297, 4327, 4337, 4339, 4349, 4357, 4363, 4373, 4391, 4397, 4409, 4421, 4423, 4441, 4447, 4451, 4457, 4463, 4481, 4483, 4493, 4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637, 4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751, 4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903, 4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999, 5003, 5009, 5011, 5021, 5023, 5039, 5051, 5059, 5077, 5081, 5087, 5099, 5101, 5107, 5113, 5119, 5147, 5153, 5167, 5171, 5179, 5189, 5197, 5209, 5227, 5231, 5233, 5237, 5261, 5273, 5279, 5281, 5297, 5303, 5309, 5323, 5333, 5347, 5351, 5381, 5387, 5393, 5399, 5407, 5413, 5417, 5419, 5431, 5437, 5441, 5443, 5449, 5471, 5477, 5479, 5483, 5501, 5503, 5507, 5519, 5521, 5527, 5531, 5557, 5563, 5569, 5573, 5581, 5591, 5623, 5639, 5641, 5647, 5651, 5653, 5657, 5659, 5669, 5683, 5689, 5693, 5701, 5711, 5717, 5737, 5741, 5743, 5749, 5779, 5783, 5791, 5801, 5807, 5813, 5821, 5827, 5839, 5843, 5849, 5851, 5857, 5861, 5867, 5869, 5879, 5881, 5897, 5903, 5923, 5927, 5939, 5953, 5981, 5987, 6007, 6011, 6029, 6037, 6043, 6047, 6053, 6067, 6073, 6079, 6089, 6091, 6101, 6113, 6121, 6131, 6133, 6143, 6151, 6163, 6173, 6197, 6199, 6203, 6211, 6217, 6221, 6229, 6247, 6257, 6263, 6269, 6271, 6277, 6287, 6299, 6301, 6311, 6317, 6323, 6329, 6337, 6343, 6353, 6359, 6361, 6367, 6373, 6379, 6389, 6397, 6421, 6427, 6449, 6451, 6469, 6473, 6481, 6491, 6521, 6529, 6547, 6551, 6553, 6563, 6569, 6571, 6577, 6581, 6599, 6607, 6619, 6637, 6653, 6659, 6661, 6673, 6679, 6689, 6691, 6701, 6703, 6709, 6719, 6733, 6737, 6761, 6763, 6779, 6781, 6791, 6793, 6803, 6823, 6827, 6829, 6833, 6841, 6857, 6863, 6869, 6871, 6883, 6899, 6907, 6911, 6917, 6947, 6949, 6959, 6961, 6967, 6971, 6977, 6983, 6991, 6997, 7001, 7013, 7019, 7027, 7039, 7043, 7057, 7069, 7079, 7103, 7109, 7121, 7127, 7129, 7151, 7159, 7177, 7187, 7193, 7207, 7211, 7213, 7219, 7229, 7237, 7243, 7247, 7253, 7283, 7297, 7307, 7309, 7321, 7331, 7333, 7349, 7351, 7369, 7393, 7411, 7417, 7433, 7451, 7457, 7459, 7477, 7481, 7487, 7489, 7499, 7507, 7517, 7523, 7529, 7537, 7541, 7547, 7549, 7559, 7561, 7573, 7577, 7583, 7589, 7591, 7603, 7607, 7621, 7639, 7643, 7649, 7669, 7673, 7681, 7687, 7691, 7699, 7703, 7717, 7723, 7727, 7741, 7753, 7757, 7759, 7789, 7793, 7817, 7823, 7829, 7841, 7853, 7867, 7873, 7877, 7879, 7883, 7901, 7907, 7919, 7927, 7933, 7937, 7949, 7951, 7963, 7993, 8009, 8011, 8017, 8039, 8053, 8059, 8069, 8081, 8087, 8089, 8093, 8101, 8111, 8117, 8123, 8147, 8161, 8167, 8171, 8179, 8191, 8209, 8219, 8221, 8231, 8233, 8237, 8243, 8263, 8269, 8273, 8287, 8291, 8293, 8297, 8311, 8317, 8329, 8353, 8363, 8369, 8377, 8387, 8389, 8419, 8423, 8429, 8431, 8443, 8447, 8461, 8467, 8501, 8513, 8521, 8527, 8537, 8539, 8543, 8563, 8573, 8581, 8597, 8599, 8609, 8623, 8627, 8629, 8641, 8647, 8663, 8669, 8677, 8681, 8689, 8693, 8699, 8707, 8713, 8719, 8731, 8737, 8741, 8747, 8753, 8761, 8779, 8783, 8803, 8807, 8819, 8821, 8831, 8837, 8839, 8849, 8861, 8863, 8867, 8887, 8893, 8923, 8929, 8933, 8941, 8951, 8963, 8969, 8971, 8999, 9001, 9007, 9011, 9013, 9029, 9041, 9043, 9049, 9059, 9067, 9091, 9103, 9109, 9127, 9133, 9137, 9151, 9157, 9161, 9173, 9181, 9187, 9199, 9203, 9209, 9221, 9227, 9239, 9241, 9257, 9277, 9281, 9283, 9293, 9311, 9319, 9323, 9337, 9341, 9343, 9349, 9371, 9377, 9391, 9397, 9403, 9413, 9419, 9421, 9431, 9433, 9437, 9439, 9461, 9463, 9467, 9473, 9479, 9491, 9497, 9511, 9521, 9533, 9539, 9547, 9551, 9587, 9601, 9613, 9619, 9623, 9629, 9631, 9643, 9649, 9661, 9677, 9679, 9689, 9697, 9719, 9721, 9733, 9739, 9743, 9749, 9767, 9769, 9781, 9787, 9791, 9803, 9811, 9817, 9829, 9833, 9839, 9851, 9857, 9859, 9871, 9883, 9887, 9901, 9907, 9923, 9929, 9931, 9941, 9949, 9967, 9973 };
            int Min = Math.Min(Fst, Scd);
            int Answer = 1;
            int Index = 0;
            int factor = 0;
            while (factor == 0)
            {
                Index = 0;
                Min = Math.Min(Fst, Scd);
                while (true)
                {
                    if (Min < Sosu[Index])
                    {
                        factor = 1;
                        break;
                    }
                    if (Fst % Sosu[Index] == 0 && Scd % Sosu[Index] == 0)
                    {
                        Answer *= Sosu[Index];
                        Fst = Fst / Sosu[Index];
                        Scd = Scd / Sosu[Index];
                        break;
                    }
                    Index++;
                }
            }


            return Answer;
        }
        public static void B2798()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            string[] Inpts2 = Console.ReadLine().Split(" ");
            int[] Table = new int[Inpts2.Length];
            int Fst = int.Parse(Inpts[0]);
            int Scd = int.Parse(Inpts[1]);
            int Max = 0;
            int Temp = 0;
            for (int i = 0; i < Fst; i++)
            {
                Table[i] = int.Parse(Inpts2[i]);
            }
            for (int i = 0; i < Fst; i++)
            {
                for (int j = i + 1; j < Fst; j++)
                {
                    for (int k = j + 1; k < Fst; k++)
                    {
                        Temp = Table[i] + Table[j] + Table[k];
                        if (Temp <= Scd && Temp > Max) Max = Temp;
                    }
                }
            }
            Console.WriteLine(Max);
        }
        public static void B9012()
        {
            int Case = int.Parse(Console.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string Inpts = Console.ReadLine();
                int Lcount = 0;
                int Rcount = 0;
                foreach (char chr in Inpts)
                {
                    if (chr.Equals('(') == true)
                    {
                        Lcount++;
                    }
                    else
                    {
                        Rcount++;
                        if (Rcount > Lcount)
                        {
                            break;
                        }
                    }
                }
                if (Lcount == Rcount)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        public static void B10828()
        {
            StringBuilder SB = new StringBuilder();
            Stack<int> BStack = new Stack<int>();
            int Case = int.Parse(Console.ReadLine());

            for (int i = 0; i < Case; i++)
            {
                string Inpts = Console.ReadLine();
                if (Inpts[0] == 'p')
                {
                    if (Inpts[1] == 'u')
                    {
                        string[] Inpts2 = Inpts.Split(" ");
                        BStack.Push(int.Parse(Inpts2[1]));
                    }
                    else //pop
                    {
                        if (BStack.Count == 0)
                        {
                            SB.AppendLine("-1");
                        }
                        else
                        {
                            int Temp = BStack.Pop();
                            SB.AppendLine(Temp.ToString());
                        }

                    }
                }
                else if (Inpts[0] == 's')
                {
                    SB.AppendLine(BStack.Count.ToString());
                }
                else if (Inpts[0] == 'e')
                {
                    if (BStack.Count == 0)
                    {
                        SB.AppendLine("1");
                    }
                    else
                    {
                        SB.AppendLine("0");
                    }
                }
                else
                {
                    if (BStack.Count == 0)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine(BStack.Peek().ToString());
                    }
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B10866()
        {
            int[] Deque = new int[0];
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Console.ReadLine());

            for (int i = 0; i < Case; i++)
            {
                string Inpts = Console.ReadLine();
                if (Inpts[0] == 'p')
                {
                    if (Inpts[1] == 'u') // push front , back
                    {
                        int[] Temp = new int[Deque.Length + 1];
                        string[] Inpts2 = Inpts.Split(" ");
                        if (Inpts[5] == 'f')
                        {
                            Temp[0] = int.Parse(Inpts2[1]);
                            for (int j = 1; j <= Deque.Length; j++)
                            {
                                Temp[j] = Deque[j - 1];
                            }
                        }
                        else
                        {
                            Temp[Deque.Length] = int.Parse(Inpts2[1]);
                            for (int j = 0; j < Deque.Length; j++)
                            {
                                Temp[j] = Deque[j];
                            }
                        }
                        Deque = new int[Deque.Length + 1];
                        Array.Copy(Temp, Deque, Deque.Length);
                    }
                    else //pop front, back
                    {
                        if (Deque.Length == 0)
                        {
                            SB.AppendLine("-1");
                        }
                        else
                        {
                            int[] Temp = new int[Deque.Length - 1];

                            if (Inpts[4] == 'f')// front
                            {
                                SB.AppendLine(Deque[0].ToString());
                                for (int j = 1; j < Deque.Length; j++)
                                {
                                    Temp[j - 1] = Deque[j];
                                }
                            }

                            else // back
                            {
                                SB.AppendLine(Deque[Deque.Length - 1].ToString());
                                for (int j = 0; j < Deque.Length - 1; j++)
                                {
                                    Temp[j] = Deque[j];
                                }
                            }
                            Deque = new int[Deque.Length - 1];
                            Array.Copy(Temp, Deque, Deque.Length);

                        }


                    }
                }
                else if (Inpts[0] == 's') // size
                {
                    SB.AppendLine(Deque.Length.ToString());
                }
                else if (Inpts[0] == 'e') // empty
                {
                    if (Deque.Length == 0)
                    {
                        SB.AppendLine("1");
                    }
                    else
                    {
                        SB.AppendLine("0");
                    }
                }
                else if (Inpts[0] == 'f') // front
                {
                    if (Deque.Length == 0)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine(Deque[0].ToString());
                    }
                }
                else // back
                {
                    if (Deque.Length == 0)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine(Deque[Deque.Length - 1].ToString());
                    }
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B10845()
        {
            StringBuilder SB = new StringBuilder();
            Queue<int> BQueue = new Queue<int>();
            int Case = int.Parse(Console.ReadLine());

            for (int i = 0; i < Case; i++)
            {
                string Inpts = Console.ReadLine();
                if (Inpts[0] == 'p')
                {
                    if (Inpts[1] == 'u')
                    {
                        string[] Inpts2 = Inpts.Split(" ");
                        BQueue.Enqueue(int.Parse(Inpts2[1]));
                    }
                    else //pop
                    {
                        if (BQueue.Count == 0)
                        {
                            SB.AppendLine("-1");
                        }
                        else
                        {
                            int Temp = BQueue.Dequeue();
                            SB.AppendLine(Temp.ToString());
                        }

                    }
                }
                else if (Inpts[0] == 's')
                {
                    SB.AppendLine(BQueue.Count.ToString());
                }
                else if (Inpts[0] == 'e')
                {
                    if (BQueue.Count == 0)
                    {
                        SB.AppendLine("1");
                    }
                    else
                    {
                        SB.AppendLine("0");
                    }
                }
                else if (Inpts[0] == 'f')// FRONT
                {
                    if (BQueue.Count == 0)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine(BQueue.First().ToString());
                    }
                }
                else // back
                {
                    if (BQueue.Count == 0)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine(BQueue.Last().ToString());
                    }
                }
            }
            Console.WriteLine(SB.ToString());
        }

        public static void B2231()
        {
            string Inpt = Console.ReadLine();
            int Tinpt = int.Parse(Inpt);
            int Answer = 0;
            bool Trigger = false;

            if (Tinpt > 65)
            {
                for (int i = Tinpt - 65; i < Tinpt; i++)
                {
                    string Temp = i.ToString();
                    foreach (char chr in Temp)
                    {
                        Answer += chr - '0';
                    }
                    Answer += i;
                    if (Answer == Tinpt)
                    {
                        Answer = i;
                        Trigger = true;
                        break;
                    }
                    else
                    {
                        Answer = 0;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= Tinpt; i++)
                {
                    string Temp = i.ToString();
                    foreach (char chr in Temp)
                    {
                        Answer += chr - '0';
                    }
                    Answer += i;
                    if (Answer == Tinpt)
                    {
                        Answer = i;
                        Trigger = true;
                        break;
                    }
                    else
                    {
                        Answer = 0;
                    }
                }
            }
            if (Trigger == false)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Answer);
            }

        }
        public static void B1436()
        {
            // int[] Six = new int[10010]
            // int Inpt = int.Parse(Console.ReadLine());
            //Console.WriteLine(Six[Inpt-1]);
        }
        public static void Make666()
        {
            int Count = 1;
            int[] SixList = new int[10001];
            while (Count <= 10010)
            {
                bool Trigger = true;

                for (int i = SixList[Count - 1] + 1; Trigger; i++)
                {
                    int SCOUNT = 0;
                    string Temp = i.ToString();
                    foreach (char ch in Temp)
                    {
                        if (ch == '6')
                        {
                            SCOUNT++;
                            if (SCOUNT == 3)
                            {
                                SixList[Count] = i;
                                Trigger = false;
                                Count++;
                                break;
                            }
                        }
                        else
                        {
                            SCOUNT = 0;
                        }
                    }
                }
            }
            /*string savepath = @"C:\Users\d2640\source\repos\Backjun\Backjun";
            string tetvalue = "wq";
            System.IO.File.WriteAllText(savepath, tetvalue, Encoding.Default);*/
            foreach (int i in SixList)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
        public static void B7568()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            int Case = int.Parse(reader.ReadLine());
            int[] Rank = new int[Case];
            int[,] Table = new int[Case, 2];
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = reader.ReadLine().Split(" ");
                Table[i, 0] = int.Parse(Inpts[0]);
                Table[i, 1] = int.Parse(Inpts[1]);
            }
            for (int i = 0; i < Case; i++)
            {
                int Scount = 0;
                for (int j = 0; j < Case; j++)
                {
                    if (Table[i, 0] < Table[j, 0] && Table[i, 1] < Table[j, 1])
                    {
                        Scount++;
                    }
                }
                Rank[i] = Scount + 1;
            }
            for (int i = 0; i < Case; i++)
            {
                Console.Write(Rank[i]);
                if (i != Case - 1)
                {
                    Console.Write(" ");
                }
            }
        }
        public static void B15829()
        {
            int Inpt = int.Parse(Console.ReadLine());
            string Inpts = Console.ReadLine();
            long Sum = 0;
            long mod = 1234567891;
            long Sibal = 1;
            for (int i = 0; i < Inpt; i++)
            {
                long Temp = (Inpts[i] - 'a' + 1) * Sibal;
                Sum = Sum + Temp;

                Sibal *= 31;
                Sibal %= mod;
                Sum = Sum % mod;
            }
            long temp = Sum % mod;
            Console.WriteLine(temp);
        }
        public static void B4949()
        {
            StringBuilder SB = new StringBuilder();
            while (true)
            {
                string Inpts = Console.ReadLine();
                Stack<int> Stacks = new Stack<int>();
                if (Inpts == ".") break;

                int Lcount = 0;
                int Rcount = 0;
                int Lc = 0;
                int Rc = 0;
                int State = 0; /// 1일때 대괄호 2일때 괄호
                bool tstate = true;

                for (int i = 0; i < Inpts.Length; i++)
                {
                    if (Inpts[i] == '[')
                    {
                        Lcount++;
                        Stacks.Push(1); // 
                    }
                    else if (Inpts[i] == ']')
                    {
                        Rcount++;
                        if (Stacks.Count == 0 || Stacks.Peek() == 2)
                        {
                            SB.AppendLine("no");
                            tstate = false;
                            break;
                        }
                        if (Rcount > Lcount)
                        {
                            SB.AppendLine("no");
                            tstate = false;

                            break;
                        }
                        Stacks.Pop();
                    }
                    else if (Inpts[i] == '(')
                    {
                        Lc++;
                        Stacks.Push(2);
                    }
                    else if (Inpts[i] == ')')
                    {
                        Rc++;

                        if (Stacks.Count == 0 || Stacks.Peek() == 1)
                        {
                            SB.AppendLine("no");
                            tstate = false;

                            break;
                        }
                        if (Rc > Lc)
                        {
                            SB.AppendLine("no");
                            tstate = false;

                            break;
                        }
                        Stacks.Pop();

                    }
                }
                bool temp = Lc == Rc && Lcount == Rcount;
                if (temp)
                {
                    SB.AppendLine("yes");
                }
                else if (tstate == true)
                {
                    SB.AppendLine("no");
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B10773()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            int Case = int.Parse(Console.ReadLine());
            Stack<int> Stacks = new Stack<int>();
            for (int i = 0; i < Case; i++)
            {
                int Inpt = int.Parse(reader.ReadLine());
                if (Inpt == 0)
                {
                    Stacks.Pop();
                }
                else
                {
                    Stacks.Push(Inpt);
                }

            }
            print.WriteLine(Stacks.Sum());
        }
        public static void B1966()
        {
            int Case = int.Parse(Console.ReadLine());
            int Count = 0;

            for (int i = 0; i < Case; i++)
            {
                Queue<int> Bqueue = new Queue<int>();
                string[] Inpt1 = Console.ReadLine().Split(" ");
                string[] Inpt2 = Console.ReadLine().Split(" ");
                int Index = int.Parse(Inpt1[1]);
                Count = 0;
                for (int j = 0; j < int.Parse(Inpt1[0]); j++)
                {
                    Bqueue.Enqueue(int.Parse(Inpt2[j]));
                }
                while (true)
                {

                    if (Bqueue.Peek() >= Bqueue.Max())
                    {
                        if (Index == 0)
                        {
                            Count++;
                            break;
                        }
                        Count++;
                        Bqueue.Dequeue();
                        Index--;
                    }
                    else
                    {
                        if (Index == 0)
                        {
                            Index = Bqueue.Count - 1;
                            Bqueue.Enqueue(Bqueue.Dequeue());
                            continue;
                        }
                        Index--;
                        Bqueue.Enqueue(Bqueue.Dequeue());
                    }
                }
                Console.WriteLine(Count);

            }
        }
        public static void B1654()
        {

            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] Inpts = reader.ReadLine().Split(" ");
            int Case = int.Parse(Inpts[0]);
            int Goal = int.Parse(Inpts[1]);
            long[] Table = new long[Case];

            for (int i = 0; i < Case; i++)
            {
                Table[i] = long.Parse(reader.ReadLine());
            }
            long Right = Table.Max();
            long Left = 1;
            long Mid = 0;
            long Count = 0;
            long MostL = (Left + Right) / 2;
            long low = 1, high = (1L << 31);
            while (Left <= Right)
            {
                long Sum = 0;
                foreach (long elmt in Table)
                {
                    long Temp = (Left + Right) / 2;
                    Mid = Temp;
                    Sum += (elmt / Mid);
                }
                if (Sum >= Goal)
                {
                    Left = Mid + 1;
                    Count++;
                }
                else if (Sum < Goal)
                {
                    Right = Mid - 1;
                    Count++;
                }
            }
            Console.WriteLine(Left - 1);
        }
        public static void B2805()
        {

            string[] Inpt = Console.ReadLine().Split(" ");
            string[] Inpts = Console.ReadLine().Split(" ");
            int Case = int.Parse(Inpt[0]);
            int[] Table = new int[Case];
            int Goal = int.Parse(Inpt[1]);
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = int.Parse(Inpts[i]);
            }
            long Left = 1;
            long Right = Table.Max();
            long Mid = (Left + Right) / 2;
            long Sum = 0;
            while (Left <= Right)
            {
                Sum = 0;
                Mid = (Left + Right) / 2;
                for (int i = 0; i < Case; i++)
                {
                    if (Table[i] > Mid)
                    {
                        Sum += Table[i] - Mid;
                    }
                }

                if (Sum >= Goal)
                {
                    Left = Mid + 1;
                }
                else
                {
                    Right = Mid - 1;
                }
            }
            Console.WriteLine(Left - 1);
        }
        public static void B1874()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(reader.ReadLine());
            int[] Table = new int[Case];
            Stack<int> Bstack = new Stack<int>();
            Queue<int> Bqueue = new Queue<int>();
            for (int i = 0; i < Case; i++)
            {
                Table[i] = int.Parse(reader.ReadLine());

                Bqueue.Enqueue(i + 1);
            }
            int count = 0;
            int Now = 0;
            int Index = 0;
            bool trigger = true;
            while (count < Case)
            {
                if (Table[Index] > Now)
                {
                    int NTemp = Now;

                    while (true)
                    {
                        int Temp = Bqueue.Dequeue();
                        Now = Temp;
                        Bstack.Push(Temp);
                        SB.AppendLine("+");
                        if (Temp == Table[Index])
                        {
                            break;
                        }
                    }
                    Bstack.Pop();
                    count++; Index++;
                    SB.AppendLine("-");

                }
                else if (Table[Index] < Now)
                {
                    int Temp = Bstack.Pop();
                    SB.AppendLine("-");
                    if (Temp != Table[Index])
                    {
                        trigger = false;
                        break;
                    }
                    count++; Now--; Index++;

                }
            }
            if (trigger)
            {
                Console.WriteLine(SB.ToString());
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
        public static void B18111()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int Fst = int.Parse(Inpts[0]);
            int Scd = int.Parse(Inpts[1]);
            int Thd = int.Parse(Inpts[2]);
            int Sum = 0;
            int Min = 2147483646;
            int Flr = 0;
            int Time = 0;
            int[,] Table = new int[Fst, Scd];
            for (int i = 0; i < Fst; i++)
            {
                string[] Temp_Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Scd; j++)
                {
                    int Temp = int.Parse(Temp_Inpts[j]);
                    Table[i, j] = Temp;
                    Sum += Temp;
                }
            }
            for (int i = 0; i < 257; i++)
            {
                Time = B18111_1(Table, Sum, Thd, Fst * Scd, i);
                if (Time == -1)
                {
                    continue;
                }
                if (Time < Min)
                {
                    Flr = i;
                    Min = Time;
                }
                else if (Time == Min)
                {
                    if (Flr < i)
                    {
                        Flr = i;
                    }
                }
            }
            Console.WriteLine(Min + " " + Flr);

        }
        public static int B18111_1(int[,] Table, int Sum, int Have_Block, int Area, int Floor)
        {// 만들 때 시간 출력
            int Require_Block = Area * Floor;
            if (Sum + Have_Block >= Require_Block)
            {
                int Time = 0;
                foreach (int Elmt in Table)
                {
                    if (Elmt >= Floor)
                    {
                        Time += (Elmt - Floor) * 2;
                    }
                    else
                    {
                        Time += (Floor - Elmt);
                    }
                }
                return Time;
            }
            else
            {
                return -1;
            }
        }
        public static void B1676()
        {
            int Inpt = int.Parse(Console.ReadLine());
            Console.WriteLine(Inpt / 5 + Inpt / 25 + Inpt / 125);
        }
        public static void B11047()
        {
            String[] Inpts = Console.ReadLine().Split(" ");
            int Case = int.Parse(Inpts[0]);
            int Goal = int.Parse(Inpts[1]);
            int[] Value = new int[Case];
            int[] Counts = new int[Case];

            for (int i = 0; i < Case; i++)
            {
                Value[i] = int.Parse(Console.ReadLine());
            }
            for (int i = Case - 1; i >= 0; i--)
            {
                Counts[i] = Goal / Value[i];
                Goal = Goal % Value[i];
            }
            Console.WriteLine(Counts.Sum());


        }
        public static void B1764()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();


            string[] Inpts = Reader.ReadLine().Split(" ");
            int Fst = int.Parse(Inpts[0]);
            int Scd = int.Parse(Inpts[1]);
            int Min = Math.Min(Fst, Scd);
            string[] Table = new string[Min];
            string[] Answer = new string[Min];

            Dictionary<string, bool> Dic = new Dictionary<string, bool>();
            if (Fst > Scd)
            {
                for (int i = 0; i < Fst; i++)
                {
                    Dic.Add(Reader.ReadLine(), true);
                }
                for (int i = 0; i < Scd; i++)
                {
                    Table[i] = Reader.ReadLine();
                }
            }
            else // scd > fst   
            {
                for (int i = 0; i < Fst; i++)
                {
                    Table[i] = Reader.ReadLine();
                }
                for (int i = 0; i < Scd; i++)
                {
                    Dic.Add(Reader.ReadLine(), true);
                }
            }
            Array.Sort(Table);
            int Count = 0;
            for (int i = 0; i < Min; i++)
            {
                bool Temp = false;
                if (Dic.TryGetValue(Table[i], out bool asd))
                {
                    Count++;
                    SB.AppendLine(Table[i]);
                }

            }
            Console.WriteLine(Count);
            Console.WriteLine(SB.ToString());


        }
        public static void B11723()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            int Case = int.Parse(Console.ReadLine());
            List<int> Table = new List<int>();

            for (int i = 0; i < Case; i++)
            {
                string Inpts = Reader.ReadLine();
                string[] Inpts2;
                if (Inpts[0] == 'a') //add , all
                {
                    if (Inpts[1] == 'd')
                    {
                        Inpts2 = Inpts.Split(" ");
                        if (Table.Find(x => x == int.Parse(Inpts2[1])) != 0)
                        {
                        }
                        else
                        {
                            Table.Add(int.Parse(Inpts2[1])); ;
                        }

                    }
                    else
                    {
                        Table = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                    }
                }
                else if (Inpts[0] == 'c')// check
                {
                    Inpts2 = Inpts.Split(" ");
                    if (Table.Find(x => x == int.Parse(Inpts2[1])) != 0)
                    {
                        SB.AppendLine("1");
                    }
                    else
                    {
                        SB.AppendLine("0");
                    }


                }
                else if (Inpts[0] == 'e') //empty
                {
                    Table = new List<int>();
                }
                else if (Inpts[0] == 't') //toggle
                {
                    Inpts2 = Inpts.Split(" ");
                    if (Table.Find(x => x == int.Parse(Inpts2[1])) != 0)
                    {
                        Table.Remove(int.Parse(Inpts2[1]));
                    }
                    else
                    {
                        Table.Add(int.Parse(Inpts2[1]));
                    }
                }
                else //remove
                {
                    Inpts2 = Inpts.Split(" ");
                    if (Table.Find(x => x == int.Parse(Inpts2[1])) != 0)
                    {
                        Table.Remove(int.Parse(Inpts2[1]));
                    }
                    else
                    {
                    }
                }

            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11723_2()
        {
            int Tpower20 = 1048576;
            string Table = Convert.ToString(Tpower20, toBase: 2);
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            int Case = int.Parse(Reader.ReadLine());

            for (int i = 0; i < Case; i++)
            {
                Table = Convert.ToString(Tpower20, toBase: 2);
                string Inpts = Reader.ReadLine();

                if (Inpts[0] == 'a') //add , all
                {
                    if (Inpts[1] == 'd')
                    {
                        string[] Inpts2 = Inpts.Split(" ");
                        int Index = int.Parse(Inpts2[1]);
                        if (Table[21 - Index] == '1')
                        {
                        }
                        else
                        {
                            Tpower20 += (int)Math.Pow(2, Index - 1);
                        }
                    }
                    else
                    {
                        Tpower20 = 2097151;
                    }
                }
                else if (Inpts[0] == 'c')// check
                {
                    string[] Inpts2 = Inpts.Split(" ");
                    int Index = int.Parse(Inpts2[1]);
                    if (Table[21 - Index] == '1')
                    {
                        SB.AppendLine("1");
                    }
                    else
                    {
                        SB.AppendLine("0");
                    }

                }
                else if (Inpts[0] == 'e') //empty
                {
                    Tpower20 = 1048576;
                }
                else if (Inpts[0] == 't') //toggle
                {
                    string[] Inpts2 = Inpts.Split(" ");
                    int Index = int.Parse(Inpts2[1]);
                    if (Table[21 - Index] == '1')
                    {
                        Tpower20 -= (int)Math.Pow(2, Index - 1);
                    }
                    else
                    {
                        Tpower20 += (int)Math.Pow(2, Index - 1);
                    }
                }
                else //remove
                {
                    string[] Inpts2 = Inpts.Split(" ");
                    int Index = int.Parse(Inpts2[1]);
                    if (Table[21 - Index] == '1')
                    {
                        Tpower20 -= (int)Math.Pow(2, Index - 1);
                    }
                    else
                    {
                    }
                }

            }
            Console.WriteLine(SB.ToString());

        }
        public static void B1620()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            Dictionary<string, int> Dic = new Dictionary<string, int>();
            string[] Inpt = Reader.ReadLine().Split(" ");
            string[] Table = new string[int.Parse(Inpt[0])];
            for (int i = 0; i < int.Parse(Inpt[0]); i++)
            {
                string Temp = Reader.ReadLine();
                Dic.Add(Temp, i + 1);
                Table[i] = Temp;
            }
            for (int i = 0; i < int.Parse(Inpt[1]); i++)
            {
                string Temp = Reader.ReadLine();
                if (Temp[0] < 59)
                {
                    SB.AppendLine(Table[int.Parse(Temp) - 1]);
                }
                else
                {
                    int Answer = Dic.GetValueOrDefault(Temp);
                    SB.AppendLine(Answer.ToString());
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11399()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Case];
            for (int i = 0; i < Case; i++)
            {
                Table[i] = int.Parse(Inpts[i]);
            }
            int Sum = 0;
            Array.Sort(Table);
            for (int i = 0; i < Case; i++)
            {
                Sum += Table[i] * (Case - i);
            }
            Console.WriteLine(Sum);
        }
        public static void B17218()
        {
            string Fst = Console.ReadLine();
            string Scd = Console.ReadLine();
            string[,] dinamic = new string[40, 40];
            bool Trigger = false;

            for (int i = 0; i < Fst.Length; i++)
            {
                if (Fst[i] == Scd[0] || Trigger)
                {
                    dinamic[i, 0] = Scd[0].ToString();
                    Trigger = true;
                }
            }
            Trigger = false;
            for (int i = 0; i < Scd.Length; i++)
            {
                if (Fst[0] == Scd[i] || Trigger)
                {
                    dinamic[0, i] = Fst[0].ToString();
                    Trigger = true;
                }
            }
            for (int i = 1; i < Fst.Length; i++)
            {
                for (int j = 1; j < Scd.Length; j++)
                {
                    if (Fst[i] == Scd[j])
                    {
                        dinamic[i, j] = dinamic[i - 1, j - 1] + Fst[i];
                    }
                    else
                    {
                        string a = dinamic[i - 1, j];
                        string b = dinamic[i, j - 1];
                        if (a.Length < b.Length)
                        {
                            dinamic[i, j] = dinamic[i, j - 1];
                        }
                        else
                        {
                            dinamic[i, j] = dinamic[i - 1, j];
                        }
                    }
                }
            }
            Console.WriteLine(dinamic[Fst.Length - 1, Scd.Length - 1]);
        }
        public static void B17219()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Inpts = Reader.ReadLine().Split(" ");
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            for (int i = 0; i < int.Parse(Inpts[0]); i++)
            {
                string[] Inpt = Reader.ReadLine().Split(" ");
                Dic.Add(Inpt[0], Inpt[1]);
            }
            for (int i = 0; i < int.Parse(Inpts[1]); i++)
            {
                string Inpt = Reader.ReadLine();
                SB.AppendLine(Dic[Inpt]);
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B1463()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Dinamic = new int[Inpt + 4];
            Dinamic[1] = 0;
            Dinamic[2] = 1;
            Dinamic[3] = 1;
            int Index = 4;
            int[] Table;
            while (Index <= Inpt)
            {

                if (Index % 2 == 0)
                {
                    if (Index % 3 == 0)
                    {//2,3
                        Table = new int[3];
                        Table[0] = Dinamic[Index - 1];
                        Table[1] = Dinamic[Index / 2];
                        Table[2] = Dinamic[Index / 3];
                    }
                    else
                    {//2만
                        Table = new int[2];
                        Table[0] = Dinamic[Index - 1];
                        Table[1] = Dinamic[Index / 2];
                    }
                }
                else if (Index % 3 == 0)
                {//3만
                    Table = new int[2];
                    Table[0] = Dinamic[Index - 1];
                    Table[1] = Dinamic[Index / 3];
                }
                else
                { //만
                    Table = new int[1];
                    Table[0] = Dinamic[Index - 1];
                }
                Dinamic[Index] = Table.Min() + 1;
                Index++;
            }
            Console.WriteLine(Dinamic[Inpt]);
        }
        public static void B2579()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int[] Stairs = new int[Case + 4];
            for (int i = 0; i < Case; i++)
            {
                Stairs[i + 1] = int.Parse(Reader.ReadLine());
            }
            int[] Dinamic = new int[Case + 4];
            Dinamic[0] = 0;
            Dinamic[1] = Stairs[1];
            Dinamic[2] = Stairs[1] + Stairs[2];
            int Index = 3;
            while (Index <= Case)
            {
                int Fst = Dinamic[Index - 2];
                int Scd = Dinamic[Index - 3] + Stairs[Index - 1];
                if (Fst > Scd)
                {
                    Dinamic[Index] = Fst + Stairs[Index];
                }
                else
                {
                    Dinamic[Index] = Scd + Stairs[Index];

                }
                Index++;
            }
            Console.WriteLine(Dinamic[Case]);
        }
        public static void B2606()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());

            int Computer = int.Parse(Reader.ReadLine());
            int Case = int.Parse(Reader.ReadLine());
            bool[,] Relate = new bool[Computer + 1, Computer + 1];
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                Relate[int.Parse(Inpts[0]), int.Parse(Inpts[1])] = true;
                Relate[int.Parse(Inpts[1]), int.Parse(Inpts[0])] = true;
            }
            Queue<int> Bqueue = new Queue<int>();
            bool[] Marked = new bool[Computer + 1];
            Marked[1] = true;
            Bqueue.Enqueue(1);
            int Count = 0;
            while (Bqueue.Count != 0)
            {
                int Temp = Bqueue.Dequeue();
                for (int i = 1; i <= Computer; i++)
                {
                    if (Relate[Temp, i] && Marked[i] == false)
                    {
                        Marked[i] = true;
                        Bqueue.Enqueue(i);
                        Count++;
                    }
                }
            }
            Console.WriteLine(Count);
        }
        public static void B9095()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int[] Inpts = new int[Case];
            for (int i = 0; i < Case; i++)
            {
                Inpts[i] = int.Parse(Reader.ReadLine());
            }
            int[] Dinamic = new int[12];
            Dinamic[1] = 1;
            Dinamic[2] = 2;
            Dinamic[3] = 4;
            int Index = 4;
            while (Index <= 11)
            {
                Dinamic[Index] += Dinamic[Index - 1];
                Dinamic[Index] += Dinamic[Index - 2];
                Dinamic[Index] += Dinamic[Index - 3];
                Index++;
            }
            foreach (int i in Inpts)
            {
                Console.WriteLine(Dinamic[i]);
            }


        }
        public static void B9375()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < Case; i++)
            {
                int ClothCount = int.Parse(Reader.ReadLine());
                Dictionary<string, int> Dic = new Dictionary<string, int>();

                for (int j = 0; j < ClothCount; j++)
                {
                    int Count = 10;
                    string[] Inpts = Reader.ReadLine().Split(" ");
                    string Gear = Inpts[1];
                    Dic.TryGetValue(Gear, out Count);
                    if (Count == 0)
                    {
                        Dic.Add(Gear, 1);
                    }
                    else
                    {
                        Dic[Gear] += 1;
                    }
                }
                string[] Keys = Dic.Keys.ToArray();
                int Multiple = 1;
                if (Keys.Length == 1)
                {
                    SB.AppendLine((Dic[Keys[0]]).ToString());
                }
                else
                {
                    for (int k = 0; k < Keys.Length; k++)
                    {
                        Multiple *= Dic[Keys[k]] + 1;
                    }
                    Multiple -= 1;
                    SB.AppendLine(Multiple.ToString());
                }

            }
            Console.WriteLine(SB.ToString());
        }
        public static void B9461()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            int[] Inpts = new int[Case];
            for (int i = 0; i < Case; i++)
            {
                Inpts[i] = int.Parse(Reader.ReadLine());
            }
            long[] Dinamic = new long[104];
            Dinamic[1] = 1;
            Dinamic[2] = 1;
            Dinamic[3] = 1;
            Dinamic[4] = 2;
            Dinamic[5] = 2;
            Dinamic[6] = 3;
            Dinamic[7] = 4;
            Dinamic[8] = 5;
            Dinamic[9] = 7;
            Dinamic[10] = 9;
            int Index = 11;
            while (Index <= 101)
            {
                Dinamic[Index] = Dinamic[Index - 1] + Dinamic[Index - 5];
                Index++;
            }
            foreach (int i in Inpts)
            {
                SB.AppendLine(Dinamic[i].ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11659()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Cases = Reader.ReadLine().Split(" ");
            int Fst = int.Parse(Cases[0]);
            int Scd = int.Parse(Cases[1]);
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] SumTable = new int[Fst];
            SumTable[0] = int.Parse(Inpts[0]);
            for (int i = 1; i < Fst; i++)
            {
                SumTable[i] = SumTable[i - 1] + int.Parse(Inpts[i]);
            }
            for (int k = 0; k < Scd; k++)
            {
                string[] Inpt = Reader.ReadLine().Split(" ");
                int Alpha = int.Parse(Inpt[0]);
                int Beta = int.Parse(Inpt[1]);
                if (Alpha == 1)
                {
                    SB.AppendLine(SumTable[Beta - 1].ToString());
                }
                else
                {
                    SB.AppendLine((SumTable[Beta - 1] - SumTable[Alpha - 2]).ToString());
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11726()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Dinamic = new int[Inpt + 4];
            Dinamic[1] = 1;
            Dinamic[2] = 2;
            int Index = 3;
            while (Index <= Inpt)
            {
                Dinamic[Index] += Dinamic[Index - 1] + Dinamic[Index - 2];
                Dinamic[Index] = Dinamic[Index] % 10007;
                Index++;
            }
            Console.WriteLine(Dinamic[Inpt]);
        }
        public static void B11727()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Dinamic = new int[Inpt + 4];
            Dinamic[1] = 1;
            Dinamic[2] = 3;
            int Index = 3;
            while (Index <= Inpt)
            {
                Dinamic[Index] += Dinamic[Index - 1] + 2 * Dinamic[Index - 2];
                Dinamic[Index] = Dinamic[Index] % 10007;
                Index++;
            }
            Console.WriteLine(Dinamic[Inpt]);
        }
        public static void B17626()
        {
            int Inpt = int.Parse(Console.ReadLine());
            int[] Dinamic = new int[Inpt + 5];
            Dinamic[1] = 1;
            Dinamic[2] = 2;
            Dinamic[3] = 3;
            for (int i = 4; i <= Inpt; i++)
            {
                int Index = (int)Math.Sqrt(i);
                int Min = 6;
                bool Trigger = false;
                if (i == Index * Index)
                {
                    Dinamic[i] = 1;
                    continue;
                }
                for (int j = Index; j > 0; j--)
                {
                    int Temp = Dinamic[i - j * j] + 1;

                    if (Temp == 5)
                    {
                        continue;
                    }

                    if (Temp == 2)
                    {
                        Trigger = true;
                        break;
                    }

                    if (Min > Temp)
                    {
                        Min = Temp;
                    }
                }
                if (Trigger) Dinamic[i] = 2;
                else Dinamic[i] = Min;
            }
            Console.WriteLine(Dinamic[Inpt]);

        }
        public static void B10121()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string[] Condition = Reader.ReadLine().Split(" ");
                int Table_X = int.Parse(Condition[0]);
                int Table_Y = int.Parse(Condition[1]);
                int Baechu_Count = int.Parse(Condition[2]);
                int[,] Table = new int[Table_X + 2, Table_Y + 2];
                int Count = 0;
                Queue<int> Bqueue = new Queue<int>();
                for (int j = 0; j < Baechu_Count; j++)
                {
                    string[] Inpts = Reader.ReadLine().Split(" ");
                    Table[int.Parse(Inpts[0]) + 1, int.Parse(Inpts[1]) + 1] = 1;
                    Bqueue.Enqueue((int.Parse(Inpts[0]) + 1) * 100 + int.Parse(Inpts[1]) + 1);
                }
                while (Bqueue.Count >= 1)
                {
                    Queue<int> Cqueue = new Queue<int>();
                    int BTemp = Bqueue.Dequeue();
                    int BX = BTemp / 100;
                    int BY = BTemp % 100;
                    if (Table[BX, BY] == 2) continue;
                    Count++;
                    Cqueue.Enqueue(BTemp);
                    Table[BX, BY] = 2;
                    while (Cqueue.Count >= 1)
                    {
                        int CTemp = Cqueue.Dequeue();
                        int CX = CTemp / 100;
                        int CY = CTemp % 100;
                        if (Table[CX - 1, CY] == 1)
                        {
                            Cqueue.Enqueue(100 * (CX - 1) + CY);
                            Table[CX - 1, CY] = 2;

                        }
                        if (Table[CX, CY - 1] == 1)
                        {
                            Cqueue.Enqueue(100 * (CX) + CY - 1);
                            Table[CX, CY - 1] = 2;

                        }
                        if (Table[CX + 1, CY] == 1)
                        {
                            Cqueue.Enqueue(100 * (CX + 1) + CY);
                            Table[CX + 1, CY] = 2;

                        }
                        if (Table[CX, CY + 1] == 1)
                        {
                            Cqueue.Enqueue(100 * (CX) + CY + 1);
                            Table[CX, CY + 1] = 2;
                        }
                    }
                }
                Console.WriteLine(Count);

            }
        }
        public static void B1927()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();
            int[] Heap = new int[1];

            for (int i = 0; i < Case; i++)
            {
                int Inpt = int.Parse(Reader.ReadLine());
                if (Inpt == 0)
                {
                    if (Heap.Length == 1) SB.AppendLine("0");
                    else
                    { //최소 빼기
                        SB.AppendLine(Heap[1].ToString());
                        int Index = Heap.Length;
                        int[] Heap2 = new int[Index - 1];
                        for (int j = 1; j < Index - 1; j++)
                        {
                            if (j == 1)
                            {
                                Heap2[j] = Heap[Index - 1];
                                continue;
                            }
                            Heap2[j] = Heap[j];
                        }
                        int Temp_Index = 1;
                        Heap = Heap2;
                        while (true)
                        {
                            if (2 * Temp_Index > Index - 2) // 자식 트리가 더 이상 없을때
                            {
                                break;
                            }
                            else if (2 * Temp_Index == Index - 2) // 자식 트리가 한 개 일대
                            {
                                if (Heap2[Temp_Index] > Heap2[2 * Temp_Index])
                                {
                                    int Temp = Heap2[Temp_Index];
                                    Heap2[Temp_Index] = Heap2[2 * Temp_Index];
                                    Heap2[2 * Temp_Index] = Temp;
                                    Temp_Index *= 2;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else //자식 트리가 2개 일때
                            {
                                if (Heap2[Temp_Index] > Heap2[2 * Temp_Index] && Heap2[Temp_Index] > Heap2[2 * Temp_Index + 1])
                                {//둘다 큼
                                    break;
                                }
                                else if (Heap2[Temp_Index] < Heap2[2 * Temp_Index] && Heap2[Temp_Index] < Heap2[2 * Temp_Index + 1])
                                { //둘 다 작음
                                    if (Heap2[2 * Temp_Index] < Heap2[2 * Temp_Index + 1])
                                    {//왼쪽이 작음
                                        int Temp = Heap2[Temp_Index];
                                        Heap2[Temp_Index] = Heap2[2 * Temp_Index];
                                        Heap2[2 * Temp_Index] = Temp;
                                        Temp_Index *= 2;
                                    }
                                    else
                                    {//오른쪽이 작음
                                        int Temp = Heap2[Temp_Index];
                                        Heap2[Temp_Index] = Heap2[2 * Temp_Index + 1];
                                        Heap2[2 * Temp_Index + 1] = Temp;
                                        Temp_Index = 2 * Temp_Index + 1;
                                    }
                                }
                                else
                                {//1개만 작음
                                    if (Heap2[Temp_Index] < Heap2[2 * Temp_Index])
                                    {//왼쪽
                                        int Temp = Heap2[Temp_Index];
                                        Heap2[Temp_Index] = Heap2[2 * Temp_Index];
                                        Heap2[2 * Temp_Index] = Temp;
                                        Temp_Index *= 2;
                                    }
                                    else
                                    {//오른쪽
                                        int Temp = Heap2[Temp_Index];
                                        Heap2[Temp_Index] = Heap2[2 * Temp_Index + 1];
                                        Heap2[2 * Temp_Index + 1] = Temp;
                                        Temp_Index = 2 * Temp_Index + 1;
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {//1개 더하기

                    int Index = Heap.Length;
                    int[] Heap2 = new int[Index + 1];
                    for (int q = 0; q < Index; q++)
                    {
                        Heap2[q] = Heap[q];
                    }
                    Heap2[Index] = Inpt;
                    Heap = Heap2;
                    if (Index == 1)
                    {
                        continue;
                    }
                    else if (Index % 2 == 0)
                    {
                        while (true)
                        {
                            if (Heap2[Index] < Heap2[Index / 2]) //  부모가 더 큼
                            {
                                int Temp = Heap2[Index];
                                Heap2[Index] = Heap2[Index / 2];
                                Heap2[Index / 2] = Temp;
                                Index = Index / 2;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            if (Heap2[Index] < Heap2[(Index - 1) / 2]) //  부모가 더 큼
                            {
                                int Temp = Heap2[Index];
                                Heap2[Index] = Heap2[(Index - 1) / 2];
                                Heap2[Index / 2] = Temp;
                                Index = (Index - 1) / 2;
                                Heap = Heap2;

                            }
                            else
                            {
                                break;
                            }
                        }
                    }



                }
            }
            Console.WriteLine(SB.ToString());


        }
        public static void B1927_1()
        {
            Min_Heap MHeap = new Min_Heap();
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < Case; i++)
            {
                int Inpt = int.Parse(Reader.ReadLine());
                if (Inpt == 0)
                {
                    int Temp = MHeap.Pop();
                    SB.AppendLine(Temp.ToString());
                }
                else
                {
                    MHeap.Add(Inpt);
                }
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B1927_2()
        {

            PriorityQueue<int, int> PQ = new PriorityQueue<int, int>();
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < Case; i++)
            {
                int Inpt = int.Parse(Reader.ReadLine());

                if (Inpt == 0)
                {
                    int Temp = 0;
                    PQ.TryDequeue(out Temp, out int rasd);
                    SB.AppendLine(Temp.ToString());
                }
                else
                {
                    PQ.Enqueue(Inpt, Inpt);
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11279()
        {
            PriorityQueue<int, int> PQ = new PriorityQueue<int, int>();
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < Case; i++)
            {
                int Inpt = int.Parse(Reader.ReadLine());

                if (Inpt == 0)
                {
                    int Temp = 0;
                    PQ.TryDequeue(out Temp, out int rasd);
                    SB.AppendLine(Temp.ToString());
                }
                else
                {
                    PQ.Enqueue(Inpt, -Inpt);
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11286()
        {
            PriorityQueue<long, double> PQ = new PriorityQueue<long, double>();
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < Case; i++)
            {
                long Inpt = long.Parse(Reader.ReadLine());

                if (Inpt == 0)
                {
                    long Temp = 0;
                    PQ.TryDequeue(out Temp, out double rasd);
                    SB.AppendLine(Temp.ToString());
                }
                else
                {
                    if (Inpt > 0)
                    {
                        PQ.Enqueue(Inpt, Math.Abs(Inpt) + 0.1f);

                    }
                    else
                    {
                        PQ.Enqueue(Inpt, Math.Abs(Inpt) - 0.1f);
                    }
                }
            }
            Console.WriteLine(SB.ToString());
        }
    }
    public class ToPlatinum
    {
        public static void B11724()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int Node = int.Parse(Inpts[0]);
            int Line = int.Parse(Inpts[1]);
            bool[,] Table = new bool[Node + 1, Node + 1];
            Queue<int> Nodes = new Queue<int>();
            Queue<int> Nodes2 = new Queue<int>();

            bool[] Nodes_Mark = new bool[Node + 1];
            for (int i = 1; i <= Node; i++)
            {
                Nodes.Enqueue(i);
            }
            for (int i = 0; i < Line; i++)
            {
                string[] Inpt = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpt[0]);
                int Scd = int.Parse(Inpt[1]);
                Table[Fst, Scd] = true;
                Table[Scd, Fst] = true;
            }
            int Count = 0;
            while (Nodes.Count > 0)
            {
                int Start_Node = Nodes.Dequeue();
                if (Nodes_Mark[Start_Node] == true) continue;
                Nodes2.Enqueue(Start_Node);
                Nodes_Mark[Start_Node] = true;
                while (Nodes2.Count > 0)
                {
                    int Temp_Node = Nodes2.Dequeue();

                    for (int i = 1; i <= Node; i++)
                    {
                        if (Table[Temp_Node, i] == true && Nodes_Mark[i] == false)
                        {
                            Nodes2.Enqueue(i);
                            Nodes_Mark[i] = true;
                        }
                    }
                }
                Count++;
            }
            Console.WriteLine(Count);
        }
        public static int B2630_1(bool[,] Table, int Scale, int Trigger)
        {
            if (Trigger != 0) return Trigger;
            if (Scale == 2)
            { // 파랑이 true = 1 하양이 false = 0
                int Temp_Answer = 0;
                if (Table[0, 0] == true) Temp_Answer += 100000;
                else Temp_Answer += 1;
                if (Table[0, 1] == true) Temp_Answer += 100000;
                else Temp_Answer += 1;
                if (Table[1, 0] == true) Temp_Answer += 100000;
                else Temp_Answer += 1;
                if (Table[1, 1] == true) Temp_Answer += 100000;
                else Temp_Answer += 1;
                return Temp_Answer;
            }
            int Hscale = Scale / 2;
            bool Basic_Color1 = Table[0, 0];
            int[] Quarter = new int[4] { 1, 1, 1, 1 };
            bool[,] QuarterTable1 = new bool[Hscale, Hscale];
            for (int i = 0; i < Hscale; i++)
            {
                for (int j = 0; j < Hscale; j++)
                {
                    if (Table[i, j] != Basic_Color1)
                    {
                        Quarter[0] = 0;
                    }
                    QuarterTable1[i, j] = Table[i, j];
                }
            }
            bool Basic_Color2 = Table[Hscale, 0];
            bool[,] QuarterTable2 = new bool[Hscale, Hscale];

            for (int i = Hscale; i < Scale; i++)
            {
                for (int j = 0; j < Hscale; j++)
                {
                    if (Table[i, j] != Basic_Color2)
                    {
                        Quarter[1] = 0;
                    }
                    QuarterTable2[i - Hscale, j] = Table[i, j];
                }
            }
            bool Basic_Color3 = Table[0, Hscale];
            bool[,] QuarterTable3 = new bool[Hscale, Hscale];

            for (int i = 0; i < Hscale; i++)
            {
                for (int j = Hscale; j < Scale; j++)
                {
                    if (Table[i, j] != Basic_Color3)
                    {
                        Quarter[2] = 0;
                    }
                    QuarterTable3[i, j - Hscale] = Table[i, j];

                }
            }
            bool Basic_Color4 = Table[Hscale, Hscale];
            bool[,] QuarterTable4 = new bool[Hscale, Hscale];

            for (int i = Hscale; i < Scale; i++)
            {
                for (int j = Hscale; j < Scale; j++)
                {
                    if (Table[i, j] != Basic_Color4)
                    {
                        Quarter[3] = 0;
                    }
                    QuarterTable4[i - Hscale, j - Hscale] = Table[i, j];

                }
            }
            bool[] Basic_Colors = new bool[4] { Basic_Color1, Basic_Color2, Basic_Color3, Basic_Color4 };

            for (int i = 0; i < 4; i++)
            {
                if (Quarter[i] == 1)
                { // 안 섞임
                    if (Basic_Colors[i] == true) Quarter[i] = 100000;
                    else Quarter[i] = 1;
                }
            }
            return B2630_1(QuarterTable1, Scale / 2, Quarter[0]) + B2630_1(QuarterTable2, Scale / 2, Quarter[1]) + B2630_1(QuarterTable3, Scale / 2, Quarter[2]) + B2630_1(QuarterTable4, Scale / 2, Quarter[3]);
        }

        public static void B2630()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            bool[,] Table = new bool[Side, Side];
            int Trigger = 0;
            for (int i = 0; i < Side; i++)
            {
                string[] Inpts = Reader.ReadLine().Split();
                for (int j = 0; j < Side; j++)
                {

                    if (int.Parse(Inpts[j]) == 1)
                    {
                        Trigger++;
                        Table[i, j] = true;
                    }
                    else Table[i, j] = false;
                }
            }
            if (Trigger == 0) // 전부 하양
            {
                Console.WriteLine(1);
                Console.WriteLine(0);
            }
            else if (Trigger == Side * Side) // 전부 검정
            {
                Console.WriteLine(0);
                Console.WriteLine(1);
            }
            else
            {
                int Answer = B2630_1(Table, Side, 0);
                Console.WriteLine(Answer % 100000);
                Console.WriteLine(Answer / 100000);
            }


        }
        public static void B1074()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int Scale = int.Parse(Inpts[0]);

            int[] Inpt = new int[2];
            Inpt[1] = int.Parse(Inpts[1]);
            Inpt[0] = int.Parse(Inpts[2]);

            int Answer = B1074_1(Scale, Inpt, 0);
            Console.WriteLine(Answer);
        }
        public static int B1074_1(int Scale, int[] Inpt, int Start)
        {//0이 x 1이 y
            if (Scale == 1)
            {
                if (Inpt[0] == 0 & Inpt[1] == 0) return Start;
                else if (Inpt[0] == 1 & Inpt[1] == 0) return Start + 1;
                else if (Inpt[0] == 0 & Inpt[1] == 1) return Start + 2;
                else return Start + 3;
            }
            int HScale = Scale - 1;
            int Interval = (int)Math.Pow(2, HScale);
            int Block = Interval * Interval;
            int NStart = Start;
            int[] NInpt = Inpt;
            if (Interval <= Inpt[0])
            {
                NInpt[0] -= Interval;
                NStart += Block;
            }
            if (Interval <= Inpt[1])
            {
                NInpt[1] -= Interval;
                NStart += 2 * Block;
            }
            return B1074_1(Scale - 1, NInpt, NStart);
        }
        public static void B1697()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int Start = int.Parse(Inpts[0]);
            int Goal = int.Parse(Inpts[1]);
            if (Start >= Goal) Console.WriteLine(Start - Goal);
            else
            {
                bool Trigger = true;
                bool[] Table = new bool[100002];
                int Phase = 0;
                Queue<int> BQueue = new Queue<int>();
                Queue<int> TQueue = new Queue<int>();
                BQueue.Enqueue(Start);
                Table[Start] = true;
                while (true)
                {
                    while (BQueue.Count > 0)
                    {
                        int Temp = BQueue.Dequeue();
                        if (Temp <= 99999 && Table[Temp + 1] == false)
                        {
                            Table[Temp + 1] = true;
                            TQueue.Enqueue(Temp + 1);
                        }
                        if (Temp > 1 && Table[Temp - 1] == false)
                        {
                            Table[Temp - 1] = true;
                            TQueue.Enqueue(Temp - 1);
                        }
                        if (Temp <= 50000 && Table[Temp * 2] == false)
                        {
                            Table[Temp * 2] = true;
                            TQueue.Enqueue(Temp * 2);
                        }
                    }
                    int TQCount = TQueue.Count;
                    for (int i = 0; i < TQCount; i++)
                    {
                        BQueue.Enqueue(TQueue.Dequeue());
                    }
                    Phase++;
                    if (Table[Goal] == true)
                    {
                        break;
                    }
                }
                Console.WriteLine(Phase);
            }

        }
        public static void B1931()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            string[] TimeTable = new string[Case];
            bool[] MarkedArray = new bool[Case];
            int Max = 0;
            Queue<string> BQueue = new Queue<string>();
            for (int i = 0; i < Case; i++)
            {
                TimeTable[i] = Reader.ReadLine();
            }
            TimeTable = TimeTable.OrderBy(x => int.Parse(x.Split(" ")[1])).ToArray();
            TimeTable = TimeTable.OrderBy(x => int.Parse(x.Split(" ")[0])).ToArray();
            for (int i = 0; i < Case; i++)
            {
                if (MarkedArray[i] == true) continue;
                BQueue.Enqueue(TimeTable[i]);
                BQueue.Enqueue(i.ToString());
                BQueue.Enqueue("1");
                while (BQueue.Count != 0)
                {
                    string Inpt = BQueue.Dequeue();
                    string[] Inpt_Temp = Inpt.Split(" ");
                    int Fst = int.Parse(Inpt_Temp[0]);
                    int Scd = int.Parse(Inpt_Temp[1]);
                    int Index = int.Parse(BQueue.Dequeue());
                    int Phase = int.Parse(BQueue.Dequeue());

                    for (int j = Index + 1; j < Case; j++)
                    {
                        if (int.Parse(TimeTable[j].Split(" ")[0]) >= Scd)
                        {
                            MarkedArray[Index + 1] = true;
                            BQueue.Enqueue(TimeTable[j]);
                            BQueue.Enqueue(j.ToString());
                            BQueue.Enqueue((Phase + 1).ToString());
                        }
                    }
                    if (Phase > Max) Max = Phase;
                }

            }
            Console.WriteLine(Max);
        }
        public static void B1931_1()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            string[] TimeTable = new string[Case];
            int Max = 0;
            for (int i = 0; i < Case; i++)
            {
                TimeTable[i] = Reader.ReadLine();
            }
            TimeTable = TimeTable.OrderBy(x => int.Parse(x.Split(" ")[0])).ToArray();
            TimeTable = TimeTable.OrderBy(x => int.Parse(x.Split(" ")[1])).ToArray();
            int Start = 0;
            int count = 0;
            for (int i = 0; i < Case; i++)
            {
                string[] Temp = TimeTable[i].Split(" ");
                if (int.Parse(Temp[0]) >= Start)
                {
                    Start = int.Parse(Temp[1]);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void B12851()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int Start = int.Parse(Inpts[0]);
            int Goal = int.Parse(Inpts[1]);
            if (Start >= Goal) Console.WriteLine(Start - Goal);
            else
            {
                bool Trigger = true;
                bool[] Table = new bool[100002];
                int Phase = 0;
                Queue<int> BQueue = new Queue<int>();
                Queue<int> TQueue = new Queue<int>();
                BQueue.Enqueue(Start);
                Table[Start] = true;
                int TTCount = 0;
                while (true)
                {
                    while (BQueue.Count > 0)
                    {
                        int Temp = BQueue.Dequeue();
                        if (Temp <= 99999 && Table[Temp + 1] == false)
                        {
                            Table[Temp + 1] = true;
                            TQueue.Enqueue(Temp + 1);
                        }
                        if (Temp > 1 && Table[Temp - 1] == false)
                        {
                            Table[Temp - 1] = true;
                            TQueue.Enqueue(Temp - 1);
                        }
                        if (Temp <= 50000 && Table[Temp * 2] == false)
                        {
                            Table[Temp * 2] = true;
                            TQueue.Enqueue(Temp * 2);
                        }
                    }
                    int TQCount = TQueue.Count;
                    TTCount = 0;
                    for (int i = 0; i < TQCount; i++)
                    {
                        int Temp2 = TQueue.Dequeue();
                        BQueue.Enqueue(Temp2);
                        if (Temp2 == Goal) TTCount++;
                    }
                    Phase++;
                    if (Table[Goal] == true)
                    {
                        break;
                    }
                }
                Console.WriteLine(Phase);
                Console.WriteLine(TTCount);
            }
        }
        public static void B7576()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Sizes = Reader.ReadLine().Split(" ");
            int Width = int.Parse(Sizes[0]);
            int Height = int.Parse(Sizes[1]);
            int[,] Table = new int[Height, Width];
            bool[,] MarkedTable = new bool[Height, Width];
            Queue<int> BQueue = new Queue<int>();

            for (int i = 0; i < Height; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Width; j++)
                {
                    int Temp = int.Parse(Inpts[j]);
                    if (Temp == 1)
                    {
                        BQueue.Enqueue(10000 * i + j);
                        Table[i, j] = 1;
                    }
                    else if (Temp == 0)
                    {
                        Table[i, j] = 0;
                    }
                    else
                    {
                        Table[i, j] = -1;
                    }

                }
            }
            Queue<int> CQueue = new Queue<int>();
            Queue<int> DQueue = new Queue<int>();

            int Phase = 0;
            int Max = 0;
            while (BQueue.Count > 0)
            {
                int Temp = BQueue.Dequeue();
                if (MarkedTable[Temp / 10000, Temp % 10000] == true) break;
                CQueue.Enqueue(Temp);
                MarkedTable[Temp / 10000, Temp % 10000] = true;
                Table[Temp / 10000, Temp % 10000] = 1;
                Phase = 0;
                while (CQueue.Count > 0)
                {
                    while (CQueue.Count > 0)
                    {
                        int Temp2 = CQueue.Dequeue();
                        int Temp_X = Temp2 / 10000;
                        int Temp_Y = Temp2 % 10000;
                        if (Temp_X < 0 && MarkedTable[Temp_X - 1, Temp_Y] == false && Table[Temp_X - 1, Temp_Y] == 0)
                        {
                            DQueue.Enqueue(10000 * (Temp_X - 1) + Temp_Y);
                            Table[Temp_X - 1, Temp_Y] = 1;
                            MarkedTable[Temp_X - 1, Temp_Y] = true;
                        }
                        if (Temp_Y < 0 && MarkedTable[Temp_X, Temp_Y - 1] == false && Table[Temp_X, Temp_Y - 1] == 0)
                        {
                            DQueue.Enqueue(10000 * (Temp_X) + Temp_Y - 1);
                            Table[Temp_X, Temp_Y - 1] = 1;
                            MarkedTable[Temp_X, Temp_Y - 1] = true;
                        }
                        if (Temp_X < Height - 1 && MarkedTable[Temp_X + 1, Temp_Y] == false && Table[Temp_X + 1, Temp_Y] == 0)
                        {
                            DQueue.Enqueue(10000 * (Temp_X + 1) + Temp_Y);
                            Table[Temp_X + 1, Temp_Y] = 1;
                            MarkedTable[Temp_X + 1, Temp_Y] = true;
                        }
                        if (Temp_Y < Width - 1 && MarkedTable[Temp_X, Temp_Y + 1] == false && Table[Temp_X, Temp_Y + 1] == 0)
                        {
                            DQueue.Enqueue(10000 * (Temp_X) + Temp_Y + 1);
                            Table[Temp_X, Temp_Y + 1] = 1;
                            MarkedTable[Temp_X, Temp_Y + 1] = true;
                        }
                    }
                    int DCount = DQueue.Count;
                    for (int i = 0; i < DCount; i++)
                    {
                        CQueue.Enqueue(DQueue.Dequeue());
                    }
                    Phase++;
                }
                if (Max < Phase) Max = Phase;
            }
            Console.WriteLine(Max);

        }
        public static void B7576_1()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Sizes = Reader.ReadLine().Split(" ");
            int Width = int.Parse(Sizes[0]);
            int Height = int.Parse(Sizes[1]);
            int[,] Table = new int[Height, Width];
            Queue<int> BQueue = new Queue<int>();

            for (int i = 0; i < Height; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Width; j++)
                {
                    int Temp = int.Parse(Inpts[j]);
                    if (Temp == 1)
                    {
                        BQueue.Enqueue(10000 * i + j);
                        Table[i, j] = 1;
                    }
                    else
                    {
                        Table[i, j] = Temp;
                    }
                }
            }
            Queue<int> CQueue = new Queue<int>();

            int Phase = 0;
            while (BQueue.Count > 0)
            {
                int BCount = BQueue.Count;
                for (int i = 0; i < BCount; i++)
                {
                    CQueue.Enqueue(BQueue.Dequeue());
                }
                while (CQueue.Count > 0)
                {
                    int QueTemp = CQueue.Dequeue();
                    int BX = QueTemp / 10000;
                    int BY = QueTemp % 10000;
                    if (BX > 0 && Table[BX - 1, BY] == 0)
                    {
                        Table[BX - 1, BY] = 1;
                        BQueue.Enqueue(10000 * (BX - 1) + BY);
                    }
                    if (BY > 0 && Table[BX, BY - 1] == 0)
                    {
                        Table[BX, BY - 1] = 1;
                        BQueue.Enqueue(10000 * (BX) + BY - 1);
                    }
                    if (BX < Height - 1 && Table[BX + 1, BY] == 0)
                    {
                        Table[BX + 1, BY] = 1;
                        BQueue.Enqueue(10000 * (BX + 1) + BY);
                    }
                    if (BY < Width - 1 && Table[BX, BY + 1] == 0)
                    {
                        Table[BX, BY + 1] = 1;
                        BQueue.Enqueue(10000 * (BX) + BY + 1);
                    }
                }
                Phase++;
            }
            bool Trigger = false;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Table[i, j] == 0)
                    {
                        Trigger = true;
                        break;
                    }
                }
            }
            if (Trigger)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(Phase - 1);
            }
        }
        public static void B4999()
        {
            string Fst = Console.ReadLine();
            string Scd = Console.ReadLine();
            if (Fst.Length >= Scd.Length) Console.WriteLine("go");
            else Console.WriteLine("no");
        }
        public static void B7662()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            for(int i = 0; i < Case; i++)
            {
                int Count = int.Parse(Reader.ReadLine());
                DMinHeap dMinHeap = new DMinHeap(); DMaxHeap dMaxHeap = new DMaxHeap();
                for (int j = 0; j < Count; j++) 
                {
                    string[] Inpts = Reader.ReadLine().Split(" ");
                    if (Inpts[0] == "I")
                    {
                        int Inpt = int.Parse(Inpts[1]);
                        dMinHeap.Add(Inpt); 
                        dMaxHeap.Add(Inpt);
                    }
                    else
                    {
                        if(Inpts[1] == "1")
                        {
                            int Max = dMaxHeap.Top();
                            dMaxHeap.Remove(Max);
                            dMinHeap.Remove(Max);
                        }
                        else
                        {
                            int Min = dMinHeap.Top();
                            dMaxHeap.Remove(Min);
                            dMinHeap.Remove(Min);
                        }
                    }
                }
                if(dMaxHeap.Count() == 0)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    Console.Write(dMaxHeap.Top());
                    Console.Write(" ");
                    Console.WriteLine(dMinHeap.Top());
                }
            }
        }
        public static void B7662_1()
        {

        }
        public static void B24444()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] First_Inpt = Reader.ReadLine().Split(" ");

            int Node_Count = int.Parse(First_Inpt[0]);
            int Case = int.Parse(First_Inpt[1]);
            int Start_Node = int.Parse(First_Inpt[2]);

            Queue<int> BFS = new Queue<int>();
            int[] Counts = new int[Node_Count + 1];
            bool[,] Table = new bool[Node_Count + 1, Node_Count + 1];
            bool[] MarkedTable = new bool[Node_Count + 1];
            List<int>[] Adj_List = new List<int>[Node_Count + 1];

            for (int i = 1; i <= Node_Count; i++)
            {
                Adj_List[i] = new List<int>();
            }
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                Adj_List[int.Parse(Inpts[0])].Add(int.Parse(Inpts[1]));
            }
            BFS.Enqueue(Start_Node);
            while (BFS.Count > 0)
            {

            }


        }
        public static void B1260()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] First_Inpt = Reader.ReadLine().Split(" ");
            int Node_Count = int.Parse(First_Inpt[0]);
            int Case = int.Parse(First_Inpt[1]);
            int Start_Node = int.Parse(First_Inpt[2]);
            Queue<int> BFS = new Queue<int>();
            Stack<int> DFS = new Stack<int>();

            bool[,] Table = new bool[Node_Count + 1, Node_Count + 1];
            bool[] MarkedTable = new bool[Node_Count + 1];
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpts[0]);
                int Scd = int.Parse(Inpts[1]);
                Table[Fst, Scd] = true; Table[Scd, Fst] = true;
            }
            MarkedTable[Start_Node] = true;
            ////////////////////// DFS
            //1.방문 안 한 노드를 찾아서 간다.
            //2.더 이상 방문할 노드가 없으면 스택을 빼면서 다른 노드가 있는지 살핀다
            int Start = Start_Node;
            DFS.Push(0);

            int Marked_Count = 1;
            SB.Append(Start.ToString());
            while (Start != 0)
            {
                DFS.Push(Start);
                int Marked_Start = Start;
                while (true)
                {
                    int Count = 0;
                    for (int i = 1; i <= Node_Count; i++)
                    {
                        if (Table[Start, i] == true && MarkedTable[i] == false)
                        {
                            DFS.Push(i);
                            MarkedTable[i] = true;
                            Start = i;
                            SB.Append(" ");
                            SB.Append(Start.ToString());
                            break;
                        }
                        Count++;
                    }
                    if (Count == Node_Count) break;
                }
                Start = DFS.Pop();
                if (Start == Marked_Start)
                {
                    Start = DFS.Pop();
                }
            }
            SB.AppendLine();
            ////////////////////// BFS
            MarkedTable = new bool[Node_Count + 1];
            BFS.Enqueue(Start_Node);
            MarkedTable[Start_Node] = true;
            SB.Append(Start_Node);
            while (BFS.Count > 0)
            {
                int BFS_Start = BFS.Dequeue();
                for (int i = 1; i <= Node_Count; i++)
                {
                    if (Table[BFS_Start, i] == true && MarkedTable[i] == false)
                    {
                        BFS.Enqueue(i);
                        MarkedTable[i] = true;
                        SB.Append(" ");
                        SB.Append(i.ToString());
                    }
                }
            }
            SB.AppendLine("");

            Console.WriteLine(SB.ToString());
        }
        public static void B10815()
        {
            int Case1 = int.Parse(Console.ReadLine());
            string[] Inpts1 = Console.ReadLine().Split(" ");
            int Case2 = int.Parse(Console.ReadLine());
            string[] Inpts2 = Console.ReadLine().Split(" ");
            var result = Inpts1.Intersect(Inpts2).ToList();

        }
        public static void B3053()
        {
            double Inpt = double.Parse(Console.ReadLine());
            double Result1 = Inpt * Inpt * Math.PI;
            double Result2 = Inpt * Inpt * 2;
            string result1 = string.Format("{0:0.#####0}", Result1);
            string result2 = string.Format("{0:0.#####0}", Result2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
        public static void B1541()
        {
            string Inpt = Console.ReadLine();
            int Length = Inpt.Length;
            Queue<char> BQueue = new Queue<char>();
            bool Trigger = false;
            bool IsMinus = false;
            int Sum = 0;
            int TempSum = 0;
            int DecimalCount = 0;
            for (int i = 0; i < Length; i++)
            {
                char Chr = Inpt[i];
                if (Trigger == false && Chr.Equals('0'))
                { // 생략하는 0
                    continue;
                }
                if (Chr >= 48 && i != Length - 1)
                {
                    Trigger = true;
                    BQueue.Enqueue(Chr);
                    DecimalCount++;
                    continue;
                }
                else if (i == Length - 1)
                {
                    BQueue.Enqueue(Chr);
                    DecimalCount++;
                }
                Trigger = false;
                int Temp = 0;
                for (int j = 1; j <= DecimalCount; j++)
                {
                    Temp += (BQueue.Dequeue() - '0') * (int)Math.Pow(10, DecimalCount - j);
                }
                DecimalCount = 0;
                if (IsMinus)
                {
                    Sum -= Temp;
                }
                else
                {
                    if (Chr.Equals('-'))
                    {
                        IsMinus = true;
                    }
                    Sum += Temp;
                }

            }
            Console.WriteLine(Sum);
        }
        public static void B1780()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            int[,] Table = new int[Side, Side];
            int Tem2 = 0;
            bool Trigger = true;
            for (int i = 0; i < Side; i++)
            {
                string[] Temp = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Side; j++)
                {
                    Table[i, j] = int.Parse(Temp[j]);
                    if (Table[0, 0] != Table[i, j])
                    {
                        Trigger = false;
                    }
                }
            }
            if (Trigger)
            {
                if (Table[0, 0] == -1)
                {
                    Console.WriteLine(1);
                    Console.WriteLine(0);
                    Console.WriteLine(0);

                }
                else if (Table[0, 0] == 0)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(1);
                    Console.WriteLine(0);
                }
                else if (Table[0, 0] == 1)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(0);
                    Console.WriteLine(1);
                }
            }
            else
            {
                decimal Answer = B1780_1(Table, 0, Side, 2);
                int Fst = (int)(Answer % 1 * 10000000);
                int Scd = (int)(Answer % 10000000);
                int Thd = (int)(Answer / 10000000);
                Console.WriteLine(Fst);
                Console.WriteLine(Scd);
                Console.WriteLine(Thd);
            }

        }
        public static decimal B1780_1(int[,] Table, int Start, int Side, decimal Answer)
        {//size 는 한 변
            if (Answer != 2) return Answer;
            Answer = 0;
            decimal[] Answer_Table = new decimal[9];
            int[] Start_Table = new int[9];
            int Triside = Side / 3;
            if (Side == 3)
            {
                int X = Start / 10000;
                int Y = Start % 10000;
                for (int i = Y; i < Y+3; i++)
                {
                    for(int j = X; j < X + 3; j++)
                    {
                        if(Table[i, j] == 0)
                        {
                            Answer += 1;
                        }
                        else if (Table[i,j] == 1)
                        {
                            Answer += 10000000;
                        }
                        else
                        {
                            Answer += 0.0000001m;
                        }
                    }
                }
                return Answer;
            }
            else
            {
                int X = Start / 10000;
                int Y = Start % 10000;
                for (int i = 0; i < 9; i++)
                {
                    int TempElmt = Table[Y + Triside * (i / 3), X + Triside * (i % 3)];
                    Answer_Table[i] = TempElmt;
                    bool Trigger = true;
                    
                    Start_Table[i] = Y + Triside * (i / 3)+ (X + Triside * (i % 3))*10000;
                    int NY = Y + Triside * (i / 3);
                    int NX = X + Triside * (i % 3);
                    for (int j = NY; j < NY + Triside && Trigger; j++)
                    {
                        for (int k = NX; k < NX + Triside && Trigger; k++)
                        {
                            if (Table[j, k] != TempElmt)
                            {
                                Answer_Table[i] = 2;
                                Trigger = false;
                            }
                        }
                    }
                    if (Answer_Table[i] == 0)
                    {
                        Answer_Table[i] = 1;   
                    }
                    else if (Answer_Table[i] == 1) 
                    {
                        Answer_Table[i] = 10000000;
                    }
                    else if (Answer_Table[i] == -1)
                    {
                        Answer_Table[i] = 0.0000001m;
                    }
                }

                return B1780_1(Table, Start_Table[0],Triside,Answer_Table[0])+ B1780_1(Table, Start_Table[1], Triside, Answer_Table[1])+ B1780_1(Table, Start_Table[2], Triside, Answer_Table[2])+ B1780_1(Table, Start_Table[3], Triside, Answer_Table[3])+ B1780_1(Table, Start_Table[4], Triside, Answer_Table[4])+ B1780_1(Table, Start_Table[5],Triside, Answer_Table[5])+ B1780_1(Table, Start_Table[6], Triside, Answer_Table[6])+ B1780_1(Table, Start_Table[7], Triside, Answer_Table[7])+ B1780_1(Table, Start_Table[8], Triside, Answer_Table[8]);
            }
         
        }
        public static void B1389()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Node_Count = int.Parse(Condition[0]);  int Line_Count = int.Parse(Condition[1]);
            int[,] Table = new int[Node_Count+1, Node_Count+1];
            for (int j = 1; j <= Node_Count; j++)
            {
                for (int k = 1; k <= Node_Count; k++)
                {
                    Table[j, k] = 10000;
                }
            }
            for (int i = 0; i < Line_Count; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
                Table[Fst, Scd] = 1; Table[Scd, Fst] = 1;
            }

            for(int i = 1; i <= Node_Count; i++)
            {
                for(int j = 1; j <= Node_Count; j++)
                {
                    for(int k = 1;k <= Node_Count; k++)
                    {
                        Table[j, k] = Math.Min(Table[j, k], Table[j, i] + Table[i, k]);
                    }
                }
            }
            int[] Answer_Table = new int[Node_Count + 1];
            Answer_Table[0] = 10000;
            for (int j = 1; j <= Node_Count; j++)
            {
                for (int k = 1; k <= Node_Count; k++)
                {
                    Answer_Table[j] += Table[j, k];
                }
            }
            int Min = Answer_Table.Min();
            int Index = Array.FindIndex(Answer_Table, x => x ==  Min);
            Console.WriteLine(Index);
        }
        public static void B1992()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            if(Side == 1)
            {
                Console.WriteLine(Reader.ReadLine());
            }
            else
            {
                bool[,] Table = new bool[Side, Side];
                bool Temp = false;
                bool Trigger = true;
                for (int i = 0; i < Side; i++)
                {
                    string Inpts = Reader.ReadLine();
                    if (i == 0 && Inpts[0].Equals('1')) Temp = true;
                    for (int j = 0; j < Side; j++)
                    {
                        if (Inpts[j].Equals('1')) Table[i, j] = true;
                        else Table[i, j] = false;
                        if (Temp != Table[i, j])
                        {
                            Trigger = false;
                        }
                    }
                }
                string Answer = "";
                if (Trigger)
                {
                    if (Temp) Console.WriteLine("1");
                    else Console.WriteLine("0");
                }
                else
                {
                    Answer = B1992_1(Table, 0, Side, "2");
                    Console.WriteLine(Answer);
                }
            }
         



        }
        public static string B1992_1(bool[,] Table, int Start, int Side, string Answer)
        {
            if (int.Parse(Answer) < 2) return Answer;
            if (Side == 2)
            {

                int tX = Start / 1000; int tY = Start % 1000;
                Answer = "(";
                if (Table[tY, tX] == true) Answer += "1";
                else Answer += "0";
                if (Table[tY, tX + 1] == true) Answer += "1";
                else Answer += "0";
                if (Table[tY + 1, tX] == true) Answer += "1";
                else Answer += "0";
                if (Table[tY + 1, tX + 1] == true) Answer += "1";
                else Answer += "0";
                Answer += ")";
                return Answer;
            }
            int HalfSide = Side / 2;
            int X = Start / 1000; int Y = Start % 1000;
            int[] AnswerTable = new int[4]; int[] StartTable = new int[4]; bool[] SampleTable = new bool[4];
            for (int k = 0; k < 4; k++)
            {
                StartTable[k] = Y + HalfSide * (k / 2) + (X + HalfSide * (k % 2)) * 1000;
                SampleTable[k] = Table[Y + HalfSide * (k / 2), X + HalfSide * (k % 2)];
                bool Temp = SampleTable[k]; bool Trigger = true;
                if (Temp == true) AnswerTable[k] = 1;
                else AnswerTable[k] = 0;
                for (int i = Y + HalfSide * (k / 2); i < Y + HalfSide + HalfSide * (k / 2) && Trigger; i++)
                {
                    for (int j = X + HalfSide * (k % 2); j < X + HalfSide + HalfSide * (k % 2) && Trigger; j++)
                    {
                        if (Table[i, j] != Temp)
                        {
                            Trigger = false;
                            AnswerTable[k] = 2;
                        }
                    }
                }
            }
            return "(" + B1992_1(Table, StartTable[0], HalfSide, AnswerTable[0].ToString()) + B1992_1(Table, StartTable[1], HalfSide, AnswerTable[1].ToString()) + B1992_1(Table, StartTable[2], HalfSide, AnswerTable[2].ToString()) + B1992_1(Table, StartTable[3], HalfSide, AnswerTable[3].ToString()) + ")";
        }
        public static void B2178()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Width = int.Parse(Condition[1]); int Height = int.Parse(Condition[0]);
            bool[,] Table = new bool[Height+1, Width+1];
            for(int i = 0; i < Height; i++)
            {
                string Inpts = Reader.ReadLine();
                for(int j = 0; j < Width; j++)
                {
                    Table[i, j] = Inpts[j].Equals('1');
                }
            }
            Queue<int> BQueue = new Queue<int>();
            Queue<int> CQueue = new Queue<int>();

            bool Trigger = true; int Stage = 0;
            BQueue.Enqueue(0);
            while (Trigger) 
            {
                while (BQueue.Count > 0)
                {
                    int Temp = BQueue.Dequeue();
                    int X = Temp / 100;
                    int Y = Temp % 100;
                    if(X > 0 && Table[X-1,Y])
                    {
                        Table[X - 1, Y] = false;
                        CQueue.Enqueue((X - 1) * 100 + Y);
                    }
                    if (Y > 0 && Table[X, Y-1])
                    {
                        Table[X, Y-1] = false;
                        CQueue.Enqueue((X) * 100 + Y-1);
                    }
                    if (X < Height-1 && Table[X + 1, Y])
                    {
                        Table[X + 1, Y] = false;
                        CQueue.Enqueue((X + 1) * 100 + Y);
                    }
                    if (Y < Width-1 && Table[X, Y+1])
                    {
                        Table[X , Y+1] = false;
                        CQueue.Enqueue((X) * 100 + Y+1);
                    }

                }
                int CCount = CQueue.Count();
                for(int i = 0;i < CCount; i++)
                {
                    BQueue.Enqueue(CQueue.Dequeue());
                }
                Stage++;
                if (Table[Height-1,Width-1] == false)
                {
                    Stage++;
                    Trigger = false;
                }
            }
            Console.WriteLine(Stage);

        }
        public static void B2667()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            int Side = int.Parse(Reader.ReadLine());
            int[,] Table = new int[Side, Side];
            Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>();
            for(int Y = 0;Y < Side; Y++)
            {
                string Inpts = Reader.ReadLine();
                for(int X = 0;X < Side; X++)
                {
                    Table[Y, X] = Inpts[X] - '0';
                    if (Inpts[X].Equals('1')) BQueue.Enqueue(Y + X * 100);
                }
            }
            int Compliation = 0; int Count = 0;
            while (BQueue.Count > 0)
            {
                int BDeque = BQueue.Dequeue();
                if (Table[BDeque % 100, BDeque / 100] > 100) continue;
                CQueue.Enqueue(BDeque); Count++;
                Table[BDeque % 100, BDeque / 100] = 100 + Count;
                while (CQueue.Count > 0)
                {
                    int CDeque = CQueue.Dequeue();
                    int Y = CDeque % 100;
                    int X = CDeque / 100;
                    if (Y > 0 && Table[Y - 1, X] > 0 && Table[Y - 1, X] < 100)
                    {
                        Table[Y - 1, X] = 100 + Count;
                        CQueue.Enqueue((X) * 100 + Y - 1);
                    }
                    if (X > 0 && Table[Y, X-1] > 0 && Table[Y, X-1] < 100)
                    {
                        Table[Y, X-1] = 100 + Count;
                        CQueue.Enqueue((X-1) * 100 + Y);
                    }
                    if (Y < Side-1 && Table[Y + 1, X] > 0 && Table[Y + 1, X] < 100)
                    {
                        Table[Y + 1, X] = 100 + Count;
                        CQueue.Enqueue((X) * 100 + Y + 1);
                    }
                    if (X < Side-1 && Table[Y, X+1] > 0 && Table[Y, X+1] < 100)
                    {
                        Table[Y, X+1] = 100 + Count;
                        CQueue.Enqueue((X+1) * 100 + Y);
                    }
                }
            }
            int[] AnswerTable = new int[Count];
            for (int Y = 0; Y < Side; Y++)
            {
                for (int X = 0; X < Side; X++)
                {
                    int temp = Table[Y, X];
                    if(temp != 0)
                    {
                        AnswerTable[temp-101]++;
                    }
                }
            }
            Array.Sort(AnswerTable);
            SB.AppendLine(Count.ToString());
            foreach(int i in AnswerTable)
            {
                SB.AppendLine(i.ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B5525()
        {
            int Case = int.Parse(Console.ReadLine());
            int Len = int.Parse(Console.ReadLine());
            string Table = Console.ReadLine();

            if (Case * 2 + 1 > Len)
            {
                Console.WriteLine(0);
            }
            else
            {

                string PString = "I";
                for (int i = 0; i < Case; i++)
                {
                    PString += "OI";
                }
                int Answer = 0; int PL = Case * 2 + 1; int Index = 0;
                while (Len - Index >= PL)
                {
                    int Temp = B5525_1(Table, PString, Index);
                    Answer += Temp;
                    if (Temp == 1)
                    {
                        while (true)
                        {
                            if (Len - Index >= PL + 2)
                            {
                                if (Table[Index + PL].Equals('O') && Table[Index + PL + 1].Equals('I'))
                                {
                                    Index += 2;
                                    Answer += 1;
                                }
                                else
                                {
                                    Index += PL;
                                    break;
                                }
                            }
                            else
                            {
                                Index++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Index++;
                    }
                }
                Console.WriteLine(Answer);
            }

        }
        public static int B5525_1(string Table, string Pstring, int Start_Index)
        {
            int PLength = Pstring.Length;
            bool Trigger = false;
            for (int i = Start_Index; i < Start_Index + PLength; i++)
            {
                if (!Table[i].Equals(Pstring[i - Start_Index]))
                {
                    return 0;
                }
            }
            return 1;
        }
        public static void B5525_2()
        {
            int Case = int.Parse(Console.ReadLine());
            int Len = int.Parse(Console.ReadLine());
            string Table = Console.ReadLine();

            if (Case * 2 + 1 > Len)
            {
                Console.WriteLine(0);
            }
            else
            {
                string PString = "I";
                string NTable = "";
                for (int i = 0; i < Len; i++)
                {
                    if (Table[i].Equals('O'))
                    {
                        if (i < Len - 1 && Table[i + 1].Equals('I'))
                        {
                            i++;
                            NTable += 'X';
                            continue;
                        }
                    }
                    NTable += Table[i];
                }

                Len = NTable.Length ; int Answer = 0; int PL = Case+1; int Index = 0; bool Trigger = false;int Count = 0;
                while (Len > Index)
                {
                    if (NTable[Index].Equals('X') )
                    {
                        if (Trigger)
                        {
                            Count++;
                            if (Count >= Case)
                            {
                                Answer++;
                            }
                        }
                        else
                        {

                        }


                    }
                    else if ((NTable[Index].Equals('I')) )
                    {
                        Count = 0;
                    }
                    else
                    {
                        Trigger = false;
                    }

                    if (NTable[Index].Equals('X') && Trigger)
                    {
                        Count++;
                        if (Count >= Case)
                        {
                            Answer++;
                        }
                        
                    }
                    else if((NTable[Index].Equals('X')||(NTable[Index].Equals('I'))) && !Trigger)
                    {
                        Count = 0;
                        Trigger = true;
                    }
                    else if ((NTable[Index].Equals('I')) && Trigger)
                    {
                        Count = 0;
                    }
                    else
                    {
                        Trigger = false;
                    }
                    Index++;
                }
                Console.WriteLine(Answer);
            }
            
        }
        public static void B5525_3()
        {
            int Case = int.Parse(Console.ReadLine());
            int Len = int.Parse(Console.ReadLine());
            string Table = Console.ReadLine();

            Queue<int> BQueue = new Queue<int>();
            for(int i = 0; i < Len; i++)
            {
                if (Table[i] == 'I')
                {
                    BQueue.Enqueue(i);
                }
            }
            int Index = BQueue.Dequeue(); int Answer = 0;int Count = 0;
            while (BQueue.Count > 0)
            {
                int Peek = BQueue.Peek();
                if(Peek - 2 == Index)
                {
                    Count++;
                }
                else
                {
                    Count = 0;
                }
                if(Count >= Case)
                {
                    Answer++;
                }
                Index = BQueue.Dequeue();
            }
            Console.WriteLine(Answer);
        }
        public static void B10815_1() 
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            string[] Inpt = Reader.ReadLine().Split(" ");
            int Case2 = int.Parse(Reader.ReadLine());
            string[] Inpt2 = Reader.ReadLine().Split(" ");
            int[] Table = new int[Case];
            for(int i = 0; i < Case; i++) Table[i] = int.Parse(Inpt[i]);
            Array.Sort(Table);
            if(Case == 1)
            {
                for (int i = 0; i < Case2; i++)
                {
                    int Answer = 0;
                    int Temp = int.Parse(Inpt2[i]);
                    if(Temp == Table[0])
                    {
                        Answer = 1;
                    }
                    SB.Append(Answer);
                    if (i != Case2 - 1) SB.Append(" ");

                }
                SB.AppendLine("");

            }
            else
            {
                for (int i = 0; i < Case2; i++)
                {
                    int Answer = 0;
                    int Temp = int.Parse(Inpt2[i]);
                    int LeftIndex = 0;
                    int RightIndex = Case - 1;
                    while (LeftIndex <= RightIndex)
                    {
                        int MidIndex = (LeftIndex + RightIndex) / 2;
                        if (Table[MidIndex] == Temp)
                        {
                            Answer = 1;
                            break;
                        }
                        if (Table[MidIndex] > Temp)
                        {
                            RightIndex = MidIndex - 1;
                        }
                        else
                        {
                            LeftIndex = MidIndex + 1;
                        }
                    }

                    SB.Append(Answer);
                    if (i != Case2 - 1) SB.Append(" ");

                }
                SB.AppendLine("");

            }
            Console.WriteLine(SB.ToString());

        }
    }



    public class Min_Heap
    {
        private int[] Table = new int[1];

        public void Add(int Value)
        {
            int Length = Table.Length;
            int[] NTable = new int[Length + 1];
            for (int i = 0; i < Length; i++)
            {
                NTable[i] = Table[i];
            }
            NTable[Length] = Value;
            Table = NTable;
            //Length에 있음
            if (Table.Length == 2)
            {

            }
            else
            {
                while (true)
                {
                    int Parent_Index = Length / 2;
                    if (Table[Length] < Table[Parent_Index])
                    {
                        Swap(Length, Parent_Index);
                        Length = Parent_Index;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public int Pop()
        {
            if (Table.Length == 1) return 0;

            int Length = Table.Length;
            int Answer = Table[1];
            int[] NTable = new int[Length - 1]; //NTable의 끝 인덱스는 length-2
            if (Length == 2)
            {
                Table = NTable;
                return Answer;
            }
            NTable[1] = Table[Length - 1];
            for (int i = 2; i < Length - 1; i++)
            {
                NTable[i] = Table[i];
            }
            Table = NTable;
            /////////////////////////////////
            int Index = 1;
            int Last_Index = Length - 2;
            while (true)
            {
                int Child_Index = Index * 2;
                if (Child_Index < Last_Index && Table[Child_Index] > Table[Child_Index + 1])
                {
                    Child_Index++;
                }

                if (Child_Index > Last_Index || Table[Index] <= Table[Child_Index]) break;
                Swap(Index, Child_Index);
                Index = Child_Index;

            }

            return Answer;
        }
        private void Swap(int i, int j)
        {
            int Temp = Table[i];
            Table[i] = Table[j];
            Table[j] = Temp;
        }
        public int Top()
        {
            return Table[1];
        }
        public int Count()
        {
            return Table.Length;
        }
    }
    public class Max_Heap
    {
        private int[] Table = new int[1] { 2147483647 };
        public void Add(int Value)
        {
            int Length = Table.Length;
            int[] NTable = new int[Length + 1];
            for (int i = 0; i < Length; i++)
            {
                NTable[i] = Table[i];
            }
            NTable[Length] = Value;
            Table = NTable;
            Table[0] = 2147483647;
            if (Table.Length == 2)
            {

            }
            else
            {
                while (true)
                {
                    int Parent_Index = Length / 2;
                    if (Table[Length] > Table[Parent_Index])
                    {
                        Swap(Length, Parent_Index);
                        Length = Parent_Index;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //Length에 있음

        }
        public int Pop()
        {
            if (Table.Length == 1) return 0;

            int Length = Table.Length;
            int Answer = Table[1];
            int[] NTable = new int[Length - 1]; //NTable의 끝 인덱스는 length-2
            if (Length == 2)
            {
                Table = NTable;
                return Answer;
            }
            NTable[1] = Table[Length - 1];
            for (int i = 2; i < Length - 1; i++)
            {
                NTable[i] = Table[i];
            }
            Table = NTable;
            Table[0] = 2147483647;
            /////////////////////////////////
            int Index = 1;
            int Last_Index = Length - 2;
            while (true)
            {
                int Child_Index = Index * 2;
                if (Child_Index < Last_Index && Table[Child_Index] < Table[Child_Index + 1])
                {
                    Child_Index++;
                }

                if (Child_Index > Last_Index || Table[Index] >= Table[Child_Index]) break;
                Swap(Index, Child_Index);
                Index = Child_Index;

            }

            return Answer;
        }
        private void Swap(int i, int j)
        {
            int Temp = Table[i];
            Table[i] = Table[j];
            Table[j] = Temp;
        }
        public int Top()
        {
            return Table[1];
        }
        public int Count()
        {
            return Table.Length;
        }

    }
    public class DMinHeap
    {
        private Min_Heap data;
        private Min_Heap deleted;

        public DMinHeap()
        {
            data = new Min_Heap();
            deleted = new Min_Heap();
        }
        public void Add(int Value)
        {
            data.Add(Value);
        }
        public void Remove(int Value)
        {
            deleted.Add(Value);
        }
        public int Top()
        {
            Deleting();
            return data.Top();
        }
        public void Deleting()
        {
            while(deleted.Count()>1&& data.Top() == deleted.Top())
            {
                data.Pop();
                deleted.Pop();
            }
        }
        public int Count()
        {
            Deleting();
            return data.Count();
        }
    }
    public class DMaxHeap
    {
        private Max_Heap data;
        private Max_Heap deleted;
        public DMaxHeap()
        {
            data = new Max_Heap();
            deleted = new Max_Heap();
        }
        public void Add(int Value)
        {
            data.Add(Value);
        }
        public void Remove(int Value)
        {
            deleted.Add(Value);
        }
        public int Top()
        {
            Deleting();
            return data.Top();
        }
        public void Deleting()
        {
            while (deleted.Count() > 1 && data.Top() == deleted.Top())
            {
                data.Pop();
                deleted.Pop();
            }
        }
        public int Count()
        {
            Deleting();
            return data.Count();
        }
    }

    public class B7662_2
    {
        private int[] Table = new int[0];
        public void Add(int Value)
        {
            int Len = Table.Length;
            int[] NTable = new int[Len + 1];
            if (Len < 5)
            {
                if (Len == 0)
                {
                    NTable[0] = Value;
                    Table = NTable;
                    return;
                }
                else if (Len == 1)
                {
                    if (Value > Table[0])
                    {
                        NTable[0] = Table[0];
                        NTable[1] = Value;
                    }
                    else
                    {
                        NTable[0] = Value;
                        NTable[1] = Table[0];
                    }
                    Table = NTable;
                    return;
                }
                else if (Len == 2)
                {

                }
                else if (Len == 3)
                {

                }
                else if (Len == 4)
                {

                }
            }
            else
            {

            }
        }


    }

    public class Heap
    {
        public Heap(IComparer<int> comp)
        {
            comparer = comp;
        }

        public int Count => data.Count;

        public void Push(int value)
        {
            data.Add(value);

            int now = data.Count - 1;
            while (now != 0 && comparer.Compare(data[(now - 1) / 2], data[now]) < 0)
            {
                Swap(now, (now - 1) / 2);
                now = (now - 1) / 2;
            }
        }

        public int Peek()
        {
            return data[0];
        }

        public int Pop()
        {
            var result = data[0];
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);

            if (data.Count == 0)
                return result;

            int now = 0;
            while (true)
            {
                int c = now * 2 + 1;

                if (c + 1 < data.Count && comparer.Compare(data[c], data[c + 1]) < 0)
                    c++;

                if (c >= data.Count)
                    break;

                if (comparer.Compare(data[now], data[c]) < 0)
                    Swap(now, c);

                now = c;
            }

            return result;
        }

        void Swap(int l, int r)
        {
            int tmp = data[l];
            data[l] = data[r];
            data[r] = tmp;
        }

        IComparer<int> comparer;
        readonly List<int> data = new List<int>();
    }

}
namespace Programers
{
    public class Study
    {
        public int solution(int[] sides)
        {
            Array.Sort(sides);
            int answer = 1;

            if (sides[0] + sides[1] <= sides[2])
            {
                answer = 2;
            }

            return answer;
        }
    }
}
namespace ConsoleApp1
{
    public class Heap
    {
        public Heap(IComparer<int> comp)
        {
            comparer = comp;
        }

        public int Count => data.Count;

        public void Push(int value)
        {
            data.Add(value);

            int now = data.Count - 1;
            while (now != 0 && comparer.Compare(data[(now - 1) / 2], data[now]) < 0)
            {
                Swap(now, (now - 1) / 2);
                now = (now - 1) / 2;
            }
        }

        public int Peek()
        {
            return data[0];
        }

        public int Pop()
        {
            var result = data[0];
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);

            if (data.Count == 0)
                return result;

            int now = 0;
            while (true)
            {
                int c = now * 2 + 1;

                if (c + 1 < data.Count && comparer.Compare(data[c], data[c + 1]) < 0)
                    c++;

                if (c >= data.Count)
                    break;

                if (comparer.Compare(data[now], data[c]) < 0)
                    Swap(now, c);

                now = c;
            }

            return result;
        }

        void Swap(int l, int r)
        {
            int tmp = data[l];
            data[l] = data[r];
            data[r] = tmp;
        }

        IComparer<int> comparer;
        readonly List<int> data = new List<int>();
    }

    public class DHeap
    {
        public DHeap(IComparer<int> comp)
        {
            data = new Heap(comp);
            deleted = new Heap(comp);
        }
        public int Count
        {
            get
            {
                Adjust();
                return data.Count;
            }
        }

        public void Push(int val)
        {
            data.Push(val);
        }

        public void Remove(int val)
        {
            deleted.Push(val);
        }

        public int Peek()
        {
            Adjust();
            return data.Peek();
        }

        public void Adjust()
        {
            while (deleted.Count > 0 && data.Peek() == deleted.Peek())
            {
                data.Pop();
                deleted.Pop();
            }
        }

        readonly Heap data;
        readonly Heap deleted;
    }

    class Program
    {
        static void Solve(StreamReader sr, StreamWriter sw)
        {
            int n = int.Parse(sr.ReadLine()); // 연산의 수
            var maxHeap = new DHeap(Comparer<int>.Create((x, y) => x.CompareTo(y)));
            var minHeap = new DHeap(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int j = 0; j < n; j++)
            {
                var input = sr.ReadLine().Split();
                char order = char.Parse(input[0]);
                int value = int.Parse(input[1]);

                if (order == 'I')
                {
                    maxHeap.Push(value);
                    minHeap.Push(value);
                }
                else
                {
                    if (maxHeap.Count == 0)
                        continue;

                    var removed = (value == -1) ? minHeap.Peek() : maxHeap.Peek();
                    maxHeap.Remove(removed);
                    minHeap.Remove(removed);
                }
            }

            // 결과 출력
            if (maxHeap.Count == 0)
            {
                sw.WriteLine("EMPTY");
                return;
            }
            sw.WriteLine($"{maxHeap.Peek()} {minHeap.Peek()}");
        }

        /*static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(sr.ReadLine()); // TC의 수
            for (int i = 0; i < t; i++)
                Solve(sr, sw);

            sr.Close();
            sw.Close();
        }*/
    }
}

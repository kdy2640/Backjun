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
using System.Xml;
using System.Text.Json.Serialization;
using System.Net.NetworkInformation;
using System.Runtime.Loader;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace BackJun2
{
    public class ToPlatinum
    {
        public static void B11403()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();
            int[,] Table = new int[Side, Side];
            for (int i = 0; i < Side; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Side; j++)
                {
                    if (Inpts[j] == "0")
                    {
                        Table[i, j] = 1001;
                    }
                    else
                    {
                        Table[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    for (int k = 0; k < Side; k++)
                    {
                        Table[j, k] = Math.Min(Table[j, k], Table[j, i] + Table[i, k]);
                    }
                }
            }
            for (int j = 0; j < Side; j++)
            {
                for (int k = 0; k < Side; k++)
                {
                    if (Table[j, k] < 1000)
                    {
                        SB.Append("1");
                    }
                    else
                    {
                        SB.Append("0");
                    }
                    if (k != Side - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());


        }
        public static void B6064()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string[] Condition = Reader.ReadLine().Split(" ");
                int DFst = int.Parse(Condition[0]); int DScd = int.Parse(Condition[1]);
                int RFst = int.Parse(Condition[2]); int RScd = int.Parse(Condition[3]);

                if (DFst == 1 || DScd == 1)
                {
                    if (DFst == 1)
                    {
                        if (DScd == 1)
                        { // 둘다 1
                            SB.AppendLine("1");
                        }
                        else
                        { // fst 만 1
                            SB.AppendLine(RScd.ToString());
                        }
                    }
                    else
                    { //scd만 1
                        SB.AppendLine(RFst.ToString());
                    }

                }
                else if (DFst == DScd)
                {
                    if (RFst == RScd)
                    {
                        SB.AppendLine(RFst.ToString());
                    }
                    else
                    {
                        SB.AppendLine("-1");
                    }
                }
                else
                {
                    if (DFst < DScd)
                    {
                        int temp = DFst; DFst = DScd; DScd = temp;
                        temp = RFst; RFst = RScd; RScd = temp;
                    }//무조건 fst 가 더 큼

                    int GCD = 1; int Fst = DFst; int Scd = DScd;
                    while (true)
                    {
                        if (Fst % Scd == 0)
                        {
                            GCD = Scd; break;
                        }
                        int Temp = Scd;
                        Scd = Fst % Scd;
                        Fst = Temp;
                    }
                    int Lcm = DFst * DScd / GCD;
                    int Count = 0;
                    while (DFst * Count < Lcm)
                    {
                        int Temp = (DFst * Count + RFst) % DScd;
                        if (Temp == 0)
                        {
                            Temp += DScd;
                        }
                        if (Temp == RScd)
                        {
                            break;
                        }
                        Count++;
                    }
                    if (DFst * Count >= Lcm)
                    {
                        SB.AppendLine("-1");
                    }
                    else
                    {
                        SB.AppendLine((DFst * Count + RFst).ToString());
                    }
                }
            }
            Console.WriteLine(SB.ToString());
        }

        public static void B13305()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int CityCount = int.Parse(Reader.ReadLine());
            string[] SMeter = Reader.ReadLine().Split(" ");
            string[] SPrice = Reader.ReadLine().Split(" ");
            long[] OverMeters = new long[CityCount];
            long[] Prices = new long[CityCount];
            for (int i = 1; i < CityCount; i++)
            {
                OverMeters[i] = long.Parse(SMeter[i - 1]) + OverMeters[i - 1];
                Prices[i] = long.Parse(SPrice[i]);
            }
            Prices[0] = long.Parse(SPrice[0]);

            long Answer = 0; int NowIndex = 0; int AfterIndex = 0;
            while (NowIndex < CityCount - 1)
            {
                long NowPrice = Prices[NowIndex];
                AfterIndex = CityCount - 1;
                for (int i = NowIndex + 1; i < CityCount; i++)
                {
                    if (NowPrice > Prices[i])
                    {
                        AfterIndex = i;
                        break;
                    }
                }
                Answer += (OverMeters[AfterIndex] - OverMeters[NowIndex]) * NowPrice;
                NowIndex = AfterIndex;
            }
            Console.WriteLine(Answer);

        }
        public static void B1238()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Citys = int.Parse(Condition[0]); int Line = int.Parse(Condition[1]); int Goal = int.Parse(Condition[2]);
            int[,] Table = new int[Citys + 1, Citys + 1];
            int[,] ReverseTable = new int[Citys + 1, Citys + 1];
            int[] AnswerTable = new int[Citys + 1];

            for (int i = 0; i <= Citys; i++)
            {
                for (int j = 0; j <= Citys; j++)
                {
                    Table[i, j] = 2000000000;
                    ReverseTable[i, j] = 2000000000;
                }
            }
            Table[Goal, Goal] = 0; ReverseTable[Goal, Goal] = 0;
            for (int i = 0; i < Line; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int a = int.Parse(Inpts[0]); int b = int.Parse(Inpts[1]); int c = int.Parse(Inpts[2]);
                Table[a, b] = Math.Min(Table[a, b], c);
                ReverseTable[b, a] = Math.Min(ReverseTable[b, a], c);
            }
            bool[] MarkTable = new bool[Citys + 1]; int Count = 1;
            MarkTable[Goal] = true; int MinIndex = Goal;


            while (Count < Citys)
            {
                int MinTime = 1000000;
                for (int i = 1; i <= Citys; i++)
                {
                    if (MarkTable[i] == false && MinTime > Table[Goal, i])
                    {
                        MinIndex = i;
                        MinTime = Table[Goal, i];
                    }
                }
                MarkTable[MinIndex] = true; Count++;
                for (int i = 1; i <= Citys; i++)
                {
                    Table[Goal, i] = Math.Min(Table[Goal, i], Table[Goal, MinIndex] + Table[MinIndex, i]);
                }
            }
            MarkTable = new bool[Citys + 1]; Count = 1;
            MarkTable[Goal] = true; MinIndex = Goal;
            while (Count < Citys)
            {
                int MinTime = 1000000;
                for (int i = 1; i <= Citys; i++)
                {
                    if (MarkTable[i] == false && MinTime > ReverseTable[Goal, i])
                    {
                        MinIndex = i;
                        MinTime = ReverseTable[Goal, i];
                    }
                }
                MarkTable[MinIndex] = true; Count++;
                for (int i = 1; i <= Citys; i++)
                {
                    ReverseTable[Goal, i] = Math.Min(ReverseTable[Goal, i], ReverseTable[Goal, MinIndex] + ReverseTable[MinIndex, i]);
                }
            }
            for (int i = 1; i <= Citys; i++)
            {
                AnswerTable[i] = Table[Goal, i] + ReverseTable[Goal, i];
            }
            AnswerTable[Goal] = 0;

            Console.WriteLine(AnswerTable.Max());
        }
        public static void B1107()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Goal = int.Parse(Reader.ReadLine());
            int Error = int.Parse(Reader.ReadLine());
            if (Goal == 101 || Goal == 99 || Goal == 102)
            {
                string[] Errors = Reader.ReadLine().Split(" ");
                if (Goal == 102)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
            else
            {
                if (Error == 0)
                {
                    int Count = 0;
                    if (Goal == 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        foreach (char a in Goal.ToString())
                        {
                            if (a == '0')
                            {
                                continue;
                            }
                            Count++;
                        }
                        Console.WriteLine(Count);
                    }

                }
                else
                {
                    string[] Errors = Reader.ReadLine().Split(" ");
                    List<int> Button = new List<int>();
                    for (int i = 0; i < 10; i++)
                    {
                        Button.Add(i);
                    }
                    for (int i = 0; i < Error; i++)
                    {
                        string Temp = Errors[i];
                        int Tamp = int.Parse(Temp);
                        Button.Remove(Tamp);
                    }
                    int[] Buttons = Button.ToArray();
                    int Len = Buttons.Length;
                    int Min = Math.Abs(Goal - 100);
                    string Teleport = "";
                    for (int a = 0; a < Len; a++)
                    {
                        int A = Buttons[a];
                        for (int b = 0; b < Len; b++)
                        {
                            int B = Buttons[b];

                            for (int c = 0; c < Len; c++)
                            {
                                int C = Buttons[c];

                                for (int d = 0; d < Len; d++)
                                {
                                    int D = Buttons[d];

                                    for (int e = 0; e < Len; e++)
                                    {
                                        int E = Buttons[e];

                                        for (int f = 0; f < Len; f++)
                                        {
                                            int F = Buttons[f];

                                            int Temp = A * 100000 + B * 10000 + C * 1000 + D * 100 + E * 10 + F;
                                            int Gap = Math.Abs(Temp - Goal);
                                            if (Gap < Min)
                                            {
                                                Teleport = A.ToString() + B.ToString() + C.ToString() + D.ToString() + E.ToString() + F.ToString();
                                                Min = Gap;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    int Count = 0;
                    if (Teleport == "")
                    {
                        Console.WriteLine(Math.Abs(Goal - 100));
                    }
                    else
                    {
                        if (int.Parse(Teleport) == 0)
                        {
                            Count++;
                        }
                        else
                        {
                            foreach (char a in Teleport)
                            {
                                if (a == '0')
                                {
                                    continue;
                                }
                                Count++;
                            }
                        }

                        Console.WriteLine(Count + Min);
                    }

                }
            }



        }
        public static void B10039()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int Temp = int.Parse(Reader.ReadLine());
                if (Temp <= 40) Temp = 40;
                Sum += Temp / 5;
            }
            Console.WriteLine(Sum);
        }
        public static void B1107_1()
        {
            B1107_C b1107_C = new B1107_C();
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            b1107_C.Goal = int.Parse(Reader.ReadLine());
            b1107_C.Error = int.Parse(Reader.ReadLine());
            int Goal = b1107_C.Goal;
            string[] Errors = new string[0]; ;
            if (b1107_C.Error != 0)
            {
                Errors = Reader.ReadLine().Split(" ");
            }
            if (Goal == 99 || Goal == 100 || Goal == 101 || Goal == 102)
            {
                if (Goal == 100)
                {
                    Console.WriteLine(0);
                }
                else if (Goal == 102)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
            else
            {
                if (b1107_C.Error == 0)
                {
                    int Answer = (int)Math.Log10(Goal);
                    Console.WriteLine(Answer + 1);
                }
                else if (b1107_C.Error == 10)
                {
                    Console.WriteLine(Math.Abs(b1107_C.Goal - 100));
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        b1107_C.Table.Add(i);
                    }
                    for (int i = 0; i < Errors.Length; i++)
                    {
                        b1107_C.Table.Remove(int.Parse(Errors[i]));
                    }
                    b1107_C.AllowButtons = b1107_C.Table.ToArray();
                    b1107_C.Len = b1107_C.AllowButtons.Length;

                    if (Goal < 500)
                    { // 0, 1, 2, 3
                        int[] AnswerTable = new int[4];
                        AnswerTable[0] = Math.Abs(Goal - 100);
                        AnswerTable[1] = b1107_C.Press1();
                        AnswerTable[2] = b1107_C.Press2();
                        AnswerTable[3] = b1107_C.Press3();
                        Console.WriteLine(AnswerTable.Min());
                    }
                    else if (Goal < 5000)
                    {// 3, 4
                        int[] AnswerTable = new int[2];
                        AnswerTable[0] = b1107_C.Press3();
                        AnswerTable[1] = b1107_C.Press4();
                        Console.WriteLine(AnswerTable.Min());
                    }
                    else if (Goal < 50000)
                    {// 4, 5
                        int[] AnswerTable = new int[2];
                        AnswerTable[0] = b1107_C.Press4();
                        AnswerTable[1] = b1107_C.Press5();
                        Console.WriteLine(AnswerTable.Min());

                    }
                    else // goal < 500000
                    {// 5, 6
                        int[] AnswerTable = new int[2];
                        AnswerTable[0] = b1107_C.Press5();
                        AnswerTable[1] = b1107_C.Press6();
                        Console.WriteLine(AnswerTable.Min());

                    }
                }
            }



        }
        public static void B5430()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string Order = Reader.ReadLine(); int Count = int.Parse(Reader.ReadLine()); string Inpts = Reader.ReadLine();
                LinkedList<int> List = new LinkedList<int>(); bool IsFlip = false;
                if (Count == 0)
                {
                    int OrderLen = Order.Length; bool Trigger = false;
                    for (int j = 0; j < OrderLen; j++)
                    {
                        if (Order[j] == 'D')
                        {
                            Trigger = true;
                            break;
                        }
                    }
                    if (Trigger)
                    {
                        SB.AppendLine("error");
                    }
                    else
                    {
                        SB.AppendLine("[]");
                    }
                }
                else
                {
                    int OrderLen = Order.Length; bool Trigger = false;
                    int Length = Count;
                    string CutInpts = Inpts.Substring(1, Inpts.Length - 2);
                    if (Length == 1)
                    {
                        List.AddLast(int.Parse(CutInpts));
                    }
                    else
                    {
                        string[] InptList = CutInpts.Split(",");
                        for (int j = 0; j < Length; j++)
                        {
                            List.AddLast(int.Parse(InptList[j]));
                        }
                    }


                    for (int j = 0; j < OrderLen; j++)
                    {
                        if (Order[j] == 'R') IsFlip = !IsFlip;
                        else
                        {
                            if (Length == 0)
                            {
                                Trigger = true;
                                break;
                            }
                            if (IsFlip)
                            {// 뒤집힘 = 뒤에꺼 뺌
                                List.RemoveLast();
                            }
                            else
                            {// 안 뒤집힘 = 앞에 꺼 뺌
                                List.RemoveFirst();
                            }
                            Length--;
                        }
                    }
                    if (Trigger)
                    {
                        SB.AppendLine("error");
                    }
                    else
                    {
                        if (Length == 0)
                        {
                            SB.AppendLine("[]");
                        }
                        else
                        {
                            int[] InptArray = List.ToArray();

                            if (IsFlip)
                            {//뒤집힘, 뒤에서부터
                                SB.Append("[");
                                for (int j = 0; j < Length; j++)
                                {
                                    SB.Append(InptArray[Length - 1 - j].ToString());
                                    if (j != Length - 1)
                                    {
                                        SB.Append(",");
                                    }
                                }
                                SB.Append("]");
                                SB.AppendLine("");
                            }
                            else
                            {//안 뒤집힘 앞에서 부터
                                SB.Append("[");
                                for (int j = 0; j < Length; j++)
                                {
                                    SB.Append(InptArray[j].ToString());
                                    if (j != Length - 1)
                                    {
                                        SB.Append(",");
                                    }
                                }
                                SB.Append("]");
                                SB.AppendLine("");
                            }
                        }
                    }
                }

            }
            Console.WriteLine(SB.ToString());
        }
        public static void B7569()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Width = int.Parse(Condition[0]); int Height = int.Parse(Condition[1]); int Depth = int.Parse(Condition[2]);
            bool[,,] Table = new bool[Depth, Height, Width];
            int ZeroCount = 0; int Sum = 0; int Phase = 0;
            Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>(); Queue<int> DQueue = new Queue<int>();
            for (int i = 0; i < Depth; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    string[] Inpts = Reader.ReadLine().Split(" ");
                    for (int k = 0; k < Width; k++)
                    {
                        int Temp = int.Parse(Inpts[k]);
                        if (Temp == 0)
                        {
                            ZeroCount++;
                        }
                        else
                        {
                            Table[i, j, k] = true;
                            if (Temp == 1)
                            {
                                BQueue.Enqueue(i * 1000000 + j * 1000 + k);
                            }
                        }
                    }
                }
            }

            while (true)
            {
                while (BQueue.Count > 0)
                {
                    int Adress = BQueue.Dequeue();
                    int TempDepth = Adress / 1000000; int TempHeigth = Adress / 1000 % 1000; int TempWidth = Adress % 1000;
                    if (TempDepth > 0 && Table[TempDepth - 1, TempHeigth, TempWidth] == false)
                    {
                        Sum++;
                        Table[TempDepth - 1, TempHeigth, TempWidth] = true;
                        DQueue.Enqueue((TempDepth - 1) * 1000000 + (TempHeigth) * 1000 + TempWidth);
                    }
                    if (TempHeigth > 0 && Table[TempDepth, TempHeigth - 1, TempWidth] == false)
                    {
                        Sum++;
                        Table[TempDepth, TempHeigth - 1, TempWidth] = true;
                        DQueue.Enqueue((TempDepth) * 1000000 + (TempHeigth - 1) * 1000 + TempWidth);
                    }
                    if (TempWidth > 0 && Table[TempDepth, TempHeigth, TempWidth - 1] == false)
                    {
                        Sum++;
                        Table[TempDepth, TempHeigth, TempWidth - 1] = true;
                        DQueue.Enqueue((TempDepth) * 1000000 + (TempHeigth) * 1000 + TempWidth - 1);
                    }
                    if (TempDepth < Depth - 1 && Table[TempDepth + 1, TempHeigth, TempWidth] == false)
                    {
                        Sum++;
                        Table[TempDepth + 1, TempHeigth, TempWidth] = true;
                        DQueue.Enqueue((TempDepth + 1) * 1000000 + (TempHeigth) * 1000 + TempWidth);
                    }
                    if (TempHeigth < Height - 1 && Table[TempDepth, TempHeigth + 1, TempWidth] == false)
                    {
                        Sum++;
                        Table[TempDepth, TempHeigth + 1, TempWidth] = true;
                        DQueue.Enqueue((TempDepth) * 1000000 + (TempHeigth + 1) * 1000 + TempWidth);
                    }
                    if (TempWidth < Width - 1 && Table[TempDepth, TempHeigth, TempWidth + 1] == false)
                    {
                        Sum++;
                        Table[TempDepth, TempHeigth, TempWidth + 1] = true;
                        DQueue.Enqueue((TempDepth) * 1000000 + (TempHeigth) * 1000 + TempWidth + 1);
                    }
                }
                int DLen = DQueue.Count;
                if (DLen == 0)
                {
                    break;
                }
                for (int i = 0; i < DLen; i++)
                {
                    BQueue.Enqueue(DQueue.Dequeue());
                }
                Phase++;
            }

            if (Sum == ZeroCount)
            {
                Console.WriteLine(Phase);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        public static void B10026_1()
        {
            int N = int.Parse(Console.ReadLine()), R = 0, S = 0, i = 0, j;
            string[] A = new string[N];
            bool[,] V = new bool[N, N];
            for (; i < N; i++) A[i] = Console.ReadLine();

            for (i = 0; i < N; i++) for (j = 0; j < N; j++) if (!V[i, j]) { E(i, j, false); R++; }
            V = new bool[N, N];
            for (i = 0; i < N; i++) for (j = 0; j < N; j++) if (!V[i, j]) { E(i, j, true); S++; }
            Console.Write($"{R} {S}");
            void E(int i, int j, bool F)
            {
                V[i, j] = true; char C = A[i][j];
                char D = F ? (A[i][j] == 'R' ? 'G' : A[i][j] == 'G' ? 'R' : C) : C;
                Queue<int> Q = new(), R = new(); Q.Enqueue(i); R.Enqueue(j);
                while (Q.Count > 0)
                {
                    int k = Q.Dequeue(), l = R.Dequeue();
                    int[] I = new int[] { k, k, Math.Max(k - 1, 0), Math.Min(k + 1, V.GetLength(0) - 1) },
                        J = new int[] { Math.Max(l - 1, 0), Math.Min(l + 1, V.GetLength(1) - 1), l, l };
                    for (int m = 0; m < 4; m++)
                        if (!V[I[m], J[m]])
                        {
                            if (A[I[m]][J[m]] != C && A[I[m]][J[m]] != D) continue;
                            V[I[m], J[m]] = true;
                            Q.Enqueue(I[m]); R.Enqueue(J[m]);
                        }
                }
            }
        }
        public static void B10026()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            int[,] Table = new int[Side, Side];
            Queue<int> BQueue = new Queue<int>(); Queue<int> RQueue = new Queue<int>(); Queue<int> GQueue = new Queue<int>(); Queue<int> YQueue = new Queue<int>();
            Queue<int> TQueue = new Queue<int>();
            int BCount = 0, RCount = 0, GCount = 0, YCount = 0;
            for (int i = 0; i < Side; i++)
            {
                string Inpts = Reader.ReadLine();
                for (int j = 0; j < Side; j++)
                {
                    char Temp = Inpts[j];
                    if (Temp == 'B')
                    {
                        Table[i, j] = 0;
                        BQueue.Enqueue(1000 * i + j);
                    }
                    else
                    {
                        if (Temp == 'R')
                        {
                            Table[i, j] = 1;
                            RQueue.Enqueue(i * 1000 + j);
                        }
                        else
                        {
                            Table[i, j] = 2;
                            GQueue.Enqueue(i * 1000 + j);
                        }
                        YQueue.Enqueue(i * 1000 + j);
                    }
                }
            }

            while (BQueue.Count > 0)
            {
                int Address = BQueue.Dequeue();
                int Fst = Address / 1000; int Scd = Address % 1000;
                if (Table[Fst, Scd] >= 10) continue;
                BCount++; Table[Fst, Scd] += 10;
                TQueue.Enqueue(Address);
                while (TQueue.Count > 0)
                {
                    int TAddress = TQueue.Dequeue();
                    int TFst = TAddress / 1000; int TScd = TAddress % 1000;
                    if (TFst > 0 && Table[TFst - 1, TScd] == 0)
                    {
                        Table[TFst - 1, TScd] += 10;
                        TQueue.Enqueue((TFst - 1) * 1000 + TScd);
                    }
                    if (TScd > 0 && Table[TFst, TScd - 1] == 0)
                    {
                        Table[TFst, TScd - 1] += 10;
                        TQueue.Enqueue((TFst) * 1000 + TScd - 1);
                    }
                    if (TFst < Side - 1 && Table[TFst + 1, TScd] == 0)
                    {
                        Table[TFst + 1, TScd] += 10;
                        TQueue.Enqueue((TFst + 1) * 1000 + TScd);
                    }
                    if (TScd < Side - 1 && Table[TFst, TScd + 1] == 0)
                    {
                        Table[TFst, TScd + 1] += 10;
                        TQueue.Enqueue((TFst) * 1000 + TScd + 1);
                    }
                }
            }
            while (YQueue.Count > 0)
            {
                int Address = YQueue.Dequeue();
                int Fst = Address / 1000; int Scd = Address % 1000;
                if (Table[Fst, Scd] > 5) continue;
                YCount++; Table[Fst, Scd] += 5;
                TQueue.Enqueue(Address);
                while (TQueue.Count > 0)
                {
                    int TAddress = TQueue.Dequeue();
                    int TFst = TAddress / 1000; int TScd = TAddress % 1000;
                    if (TFst > 0 && Table[TFst - 1, TScd] < 5)
                    {
                        Table[TFst - 1, TScd] += 5;
                        TQueue.Enqueue((TFst - 1) * 1000 + TScd);
                    }
                    if (TScd > 0 && Table[TFst, TScd - 1] < 5)
                    {
                        Table[TFst, TScd - 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd - 1);
                    }
                    if (TFst < Side - 1 && Table[TFst + 1, TScd] < 5)
                    {
                        Table[TFst + 1, TScd] += 5;
                        TQueue.Enqueue((TFst + 1) * 1000 + TScd);
                    }
                    if (TScd < Side - 1 && Table[TFst, TScd + 1] < 5)
                    {
                        Table[TFst, TScd + 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd + 1);
                    }
                }
            }
            while (RQueue.Count > 0)
            {
                int Address = RQueue.Dequeue();
                int Fst = Address / 1000; int Scd = Address % 1000;
                if (Table[Fst, Scd] > 10) continue;
                RCount++; Table[Fst, Scd] += 5;
                TQueue.Enqueue(Address);
                while (TQueue.Count > 0)
                {
                    int TAddress = TQueue.Dequeue();
                    int TFst = TAddress / 1000; int TScd = TAddress % 1000;
                    if (TFst > 0 && Table[TFst - 1, TScd] == 6)
                    {
                        Table[TFst - 1, TScd] += 5;
                        TQueue.Enqueue((TFst - 1) * 1000 + TScd);
                    }
                    if (TScd > 0 && Table[TFst, TScd - 1] == 6)
                    {
                        Table[TFst, TScd - 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd - 1);
                    }
                    if (TFst < Side - 1 && Table[TFst + 1, TScd] == 6)
                    {
                        Table[TFst + 1, TScd] += 5;
                        TQueue.Enqueue((TFst + 1) * 1000 + TScd);
                    }
                    if (TScd < Side - 1 && Table[TFst, TScd + 1] == 6)
                    {
                        Table[TFst, TScd + 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd + 1);
                    }
                }
            }
            while (GQueue.Count > 0)
            {
                int Address = GQueue.Dequeue();
                int Fst = Address / 1000; int Scd = Address % 1000;
                if (Table[Fst, Scd] > 10) continue;
                GCount++; Table[Fst, Scd] += 5;
                TQueue.Enqueue(Address);
                while (TQueue.Count > 0)
                {
                    int TAddress = TQueue.Dequeue();
                    int TFst = TAddress / 1000; int TScd = TAddress % 1000;
                    if (TFst > 0 && Table[TFst - 1, TScd] == 7)
                    {
                        Table[TFst - 1, TScd] += 5;
                        TQueue.Enqueue((TFst - 1) * 1000 + TScd);
                    }
                    if (TScd > 0 && Table[TFst, TScd - 1] == 7)
                    {
                        Table[TFst, TScd - 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd - 1);
                    }
                    if (TFst < Side - 1 && Table[TFst + 1, TScd] == 7)
                    {
                        Table[TFst + 1, TScd] += 5;
                        TQueue.Enqueue((TFst + 1) * 1000 + TScd);
                    }
                    if (TScd < Side - 1 && Table[TFst, TScd + 1] == 7)
                    {
                        Table[TFst, TScd + 1] += 5;
                        TQueue.Enqueue((TFst) * 1000 + TScd + 1);
                    }
                }
            }
            Console.Write(BCount + RCount + GCount);
            Console.Write(" ");
            Console.Write(BCount + YCount);
            Console.WriteLine("");

        }

        public static void B16928()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Laddle_Count = int.Parse(Condition[0]); int Snake_Count = int.Parse(Condition[1]);
            int[] TeleportTable = new int[101]; int[] Table = new int[101];
            Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>();
            for (int i = 0; i < 101; i++)
            {
                TeleportTable[i] = i;
            }
            for (int i = 0; i < Laddle_Count + Snake_Count; i++)
            {
                string[] Inpt = Reader.ReadLine().Split(" ");
                TeleportTable[int.Parse(Inpt[0])] = int.Parse(Inpt[1]);
            }
            BQueue.Enqueue(1); int Phase = 0;
            while (true)
            {
                while (BQueue.Count > 0)
                {
                    int Index = BQueue.Dequeue();
                    for (int i = 1; i <= 6; i++)
                    {
                        int TIndex = Math.Min(100, Index + i);
                        if (Table[TIndex] == 0)
                        {
                            Table[TIndex] = 1;
                            int TeleIndex = TeleportTable[TIndex];
                            Table[TeleIndex] = 1;
                            CQueue.Enqueue(TeleIndex);
                        }
                    }
                }
                int CCount = CQueue.Count();
                for (int i = 0; i < CCount; i++)
                {
                    BQueue.Enqueue(CQueue.Dequeue());
                }
                Phase++;
                if (Table[100] != 0)
                {
                    break;
                }
            }
            Console.WriteLine(Phase);
        }
        public static void B5337()
        {
            Console.WriteLine(".  .   .");
            Console.WriteLine("|  | _ | _. _ ._ _  _");
            Console.WriteLine("|/\\|(/.|(_.(_)[ | )(/.");
        }
        public static void B9019()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                string[] Condition = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Condition[0]); int Goal = int.Parse(Condition[1]);
                string[] Table = new string[10001];
                Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>();
                int Phase = 0; BQueue.Enqueue(Fst); Table[Fst] = "";
                while (true)
                {
                    while (BQueue.Count > 0)
                    {
                        int Temp = BQueue.Dequeue();
                        int[] TempTable = new int[4];
                        TempTable[0] = B9019_C.B9019_D(Temp); TempTable[1] = B9019_C.B9019_S(Temp); TempTable[2] = B9019_C.B9019_L(Temp); TempTable[3] = B9019_C.B9019_R(Temp);
                        for (int j = 0; j < 4; j++)
                        {
                            if (Table[TempTable[j]] == null)
                            {
                                Table[TempTable[j]] = Table[Temp] + j.ToString();
                                CQueue.Enqueue(TempTable[j]);
                            }
                        }
                    }
                    Phase++;
                    if (Table[Goal] != null)
                    {
                        break;
                    }
                    int CCount = CQueue.Count();
                    for (int j = 0; j < CCount; j++)
                    {
                        BQueue.Enqueue(CQueue.Dequeue());
                    }
                }
                int Len = Table[Goal].Length;
                string TempA = Table[Goal];
                string Answer = "";
                for (int j = 0; j < Len; j++)
                {
                    if (TempA[j] == '0') Answer += "D";
                    else if (TempA[j] == '1') Answer += "S";
                    else if (TempA[j] == '2') Answer += "L";
                    else Answer += "R";
                }
                SB.AppendLine(Answer);
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B14500()
        {
            int[,] MaxTable = new int[19, 2]; int[,,] FourTable = new int[19, 4, 2];
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Width = int.Parse(Condition[1]); int Height = int.Parse(Condition[0]);
            int[,] Table = new int[Height, Width];
            if (true)
            {
                MaxTable[0, 0] = 0; MaxTable[0, 1] = 3; MaxTable[1, 0] = 3; MaxTable[1, 1] = 0;
                MaxTable[2, 0] = 1; MaxTable[2, 1] = 1; MaxTable[3, 0] = 1; MaxTable[3, 1] = 2;
                MaxTable[4, 0] = 2; MaxTable[4, 1] = 1; MaxTable[5, 0] = 1; MaxTable[5, 1] = 2;
                MaxTable[6, 0] = 2; MaxTable[6, 1] = 1; MaxTable[7, 0] = 1; MaxTable[7, 1] = 2;
                MaxTable[8, 0] = 1; MaxTable[8, 1] = 2; MaxTable[9, 0] = 2; MaxTable[9, 1] = 1;
                MaxTable[10, 0] = 2; MaxTable[10, 1] = 1; MaxTable[11, 0] = 1; MaxTable[11, 1] = 2;
                MaxTable[12, 0] = 2; MaxTable[12, 1] = 1; MaxTable[13, 0] = 1; MaxTable[13, 1] = 2;
                MaxTable[14, 0] = 2; MaxTable[14, 1] = 1; MaxTable[15, 0] = 1; MaxTable[15, 1] = 2;
                MaxTable[16, 0] = 2; MaxTable[16, 1] = 1; MaxTable[17, 0] = 1; MaxTable[17, 1] = 2;
                MaxTable[18, 0] = 2; MaxTable[18, 1] = 1;

                FourTable[0, 0, 0] = 0; FourTable[0, 0, 1] = 0; FourTable[0, 1, 0] = 0; FourTable[0, 1, 1] = 1;
                FourTable[0, 2, 0] = 0; FourTable[0, 2, 1] = 2; FourTable[0, 3, 0] = 0; FourTable[0, 3, 1] = 3;
                FourTable[1, 0, 0] = 0; FourTable[1, 0, 1] = 0; FourTable[1, 1, 0] = 1; FourTable[1, 1, 1] = 0;
                FourTable[1, 2, 0] = 2; FourTable[1, 2, 1] = 0; FourTable[1, 3, 0] = 3; FourTable[1, 3, 1] = 0;
                FourTable[2, 0, 0] = 0; FourTable[2, 0, 1] = 0; FourTable[2, 1, 0] = 1; FourTable[2, 1, 1] = 0;
                FourTable[2, 2, 0] = 0; FourTable[2, 2, 1] = 1; FourTable[2, 3, 0] = 1; FourTable[2, 3, 1] = 1;
                FourTable[3, 0, 0] = 0; FourTable[3, 0, 1] = 0; FourTable[3, 1, 0] = 0; FourTable[3, 1, 1] = 1;
                FourTable[3, 2, 0] = 1; FourTable[3, 2, 1] = 0; FourTable[3, 3, 0] = 0; FourTable[3, 3, 1] = 2;
                FourTable[4, 0, 0] = 0; FourTable[4, 0, 1] = 0; FourTable[4, 1, 0] = 0; FourTable[4, 1, 1] = 1;
                FourTable[4, 2, 0] = 1; FourTable[4, 2, 1] = 1; FourTable[4, 3, 0] = 2; FourTable[4, 3, 1] = 1;
                FourTable[5, 0, 0] = 0; FourTable[5, 0, 1] = 2; FourTable[5, 1, 0] = 1; FourTable[5, 1, 1] = 2;
                FourTable[5, 2, 0] = 1; FourTable[5, 2, 1] = 1; FourTable[5, 3, 0] = 1; FourTable[5, 3, 1] = 0;
                FourTable[6, 0, 0] = 0; FourTable[6, 0, 1] = 0; FourTable[6, 1, 0] = 1; FourTable[6, 1, 1] = 0;
                FourTable[6, 2, 0] = 2; FourTable[6, 2, 1] = 0; FourTable[6, 3, 0] = 2; FourTable[6, 3, 1] = 1;
                FourTable[7, 0, 0] = 0; FourTable[7, 0, 1] = 2; FourTable[7, 1, 0] = 0; FourTable[7, 1, 1] = 1;
                FourTable[7, 2, 0] = 1; FourTable[7, 2, 1] = 1; FourTable[7, 3, 0] = 1; FourTable[7, 3, 1] = 0;
                FourTable[8, 0, 0] = 0; FourTable[8, 0, 1] = 0; FourTable[8, 1, 0] = 0; FourTable[8, 1, 1] = 1;
                FourTable[8, 2, 0] = 1; FourTable[8, 2, 1] = 1; FourTable[8, 3, 0] = 1; FourTable[8, 3, 1] = 2;
                FourTable[9, 0, 0] = 0; FourTable[9, 0, 1] = 1; FourTable[9, 1, 0] = 1; FourTable[9, 1, 1] = 1;
                FourTable[9, 2, 0] = 1; FourTable[9, 2, 1] = 0; FourTable[9, 3, 0] = 2; FourTable[9, 3, 1] = 0;
                FourTable[10, 0, 0] = 0; FourTable[10, 0, 1] = 0; FourTable[10, 1, 0] = 1; FourTable[10, 1, 1] = 0;
                FourTable[10, 2, 0] = 1; FourTable[10, 2, 1] = 1; FourTable[10, 3, 0] = 2; FourTable[10, 3, 1] = 1;
                FourTable[11, 0, 0] = 0; FourTable[11, 0, 1] = 1; FourTable[11, 1, 0] = 1; FourTable[11, 1, 1] = 0;
                FourTable[11, 2, 0] = 1; FourTable[11, 2, 1] = 1; FourTable[11, 3, 0] = 1; FourTable[11, 3, 1] = 2;
                FourTable[12, 0, 0] = 0; FourTable[12, 0, 1] = 0; FourTable[12, 1, 0] = 1; FourTable[12, 1, 1] = 0;
                FourTable[12, 2, 0] = 1; FourTable[12, 2, 1] = 1; FourTable[12, 3, 0] = 2; FourTable[12, 3, 1] = 0;
                FourTable[13, 0, 0] = 0; FourTable[13, 0, 1] = 0; FourTable[13, 1, 0] = 0; FourTable[13, 1, 1] = 1;
                FourTable[13, 2, 0] = 1; FourTable[13, 2, 1] = 1; FourTable[13, 3, 0] = 0; FourTable[13, 3, 1] = 2;
                FourTable[14, 0, 0] = 0; FourTable[14, 0, 1] = 1; FourTable[14, 1, 0] = 1; FourTable[14, 1, 1] = 0;
                FourTable[14, 2, 0] = 1; FourTable[14, 2, 1] = 1; FourTable[14, 3, 0] = 2; FourTable[14, 3, 1] = 1;
                FourTable[15, 0, 0] = 0; FourTable[15, 0, 1] = 0; FourTable[15, 1, 0] = 0; FourTable[15, 1, 1] = 1;
                FourTable[15, 2, 0] = 0; FourTable[15, 2, 1] = 2; FourTable[15, 3, 0] = 1; FourTable[15, 3, 1] = 2;
                FourTable[16, 0, 0] = 0; FourTable[16, 0, 1] = 1; FourTable[16, 1, 0] = 1; FourTable[16, 1, 1] = 1;
                FourTable[16, 2, 0] = 2; FourTable[16, 2, 1] = 1; FourTable[16, 3, 0] = 2; FourTable[16, 3, 1] = 0;
                FourTable[17, 0, 0] = 0; FourTable[17, 0, 1] = 0; FourTable[17, 1, 0] = 1; FourTable[17, 1, 1] = 0;
                FourTable[17, 2, 0] = 1; FourTable[17, 2, 1] = 1; FourTable[17, 3, 0] = 1; FourTable[17, 3, 1] = 2;
                FourTable[18, 0, 0] = 0; FourTable[18, 0, 1] = 0; FourTable[18, 1, 0] = 0; FourTable[18, 1, 1] = 1;
                FourTable[18, 2, 0] = 1; FourTable[18, 2, 1] = 0; FourTable[18, 3, 0] = 2; FourTable[18, 3, 1] = 0;

            }
            for (int i = 0; i < Height; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Width; j++)
                {
                    Table[i, j] = int.Parse(Inpts[j]);
                }
            }
            int Max = 0;
            for (int i = 0; i < 19; i++)
            {
                int PaddingY = MaxTable[i, 1]; int PaddingX = MaxTable[i, 0];
                for (int j = 0; j < Height - PaddingY; j++)
                {
                    for (int k = 0; k < Width - PaddingX; k++)
                    {
                        int Sum = 0;
                        for (int m = 0; m < 4; m++)
                        {
                            int TempX = FourTable[i, m, 0]; int TempY = FourTable[i, m, 1];
                            Sum += Table[j + TempY, k + TempX];
                        }
                        if (Sum > Max) Max = Sum;
                    }
                }
            }
            Console.WriteLine(Max);
        }
        public static void B16236()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Side = int.Parse(Reader.ReadLine());
            int[,] Table = new int[Side, Side];
            int Index = 0; Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>();
            for (int i = 0; i < Side; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < Side; j++)
                {
                    Table[i, j] = int.Parse(Inpts[j]);
                    if (Table[i, j] == 9)
                    {
                        Index += i * 100 + j;
                        Table[i, j] = 10000;
                    }
                }
            }
            BQueue.Enqueue(Index); int Phase = 0; int Size = 2; bool Trigger = true; int Count = 0;
            int Sum = 0;
            List<int> PhaseMin = new List<int>();
            while (true)
            {

                while (BQueue.Count > 0)
                {
                    int TIndex = BQueue.Dequeue();
                    int TempX = TIndex % 100; int TempY = TIndex / 100;
                    int[] FourVecY = new int[4] { Math.Max(0, TempY - 1), TempY, TempY, Math.Min(TempY + 1, Side - 1) };
                    int[] FourVecX = new int[4] { TempX, Math.Max(0, TempX - 1), Math.Min(Side - 1, TempX + 1), TempX };
                    for (int i = 0; i < 4; i++)
                    {
                        if (Table[FourVecY[i], FourVecX[i]] == 0)
                        {
                            CQueue.Enqueue(FourVecY[i] * 100 + FourVecX[i]);
                            Table[FourVecY[i], FourVecX[i]] += 10000;
                        }
                        else if (Table[FourVecY[i], FourVecX[i]] <= Size)
                        {
                            if (Table[FourVecY[i], FourVecX[i]] == Size)
                            {
                                CQueue.Enqueue(FourVecY[i] * 100 + FourVecX[i]);
                                Table[FourVecY[i], FourVecX[i]] += 10000;
                            }
                            else
                            {
                                Trigger = false;
                                PhaseMin.Add((50 - FourVecY[i]) * 100 + 50 - FourVecX[i]);
                                Table[FourVecY[i], FourVecX[i]] += 10000;
                            }
                        }
                    }
                }
                Phase++;
                if (Trigger)
                {
                    int CCount = CQueue.Count();
                    if (CCount == 0) break;
                    for (int c = 0; c < CCount; c++)
                    {
                        BQueue.Enqueue(CQueue.Dequeue());
                    }
                }
                else
                {
                    int Temp = PhaseMin.Max();
                    PhaseMin.Clear();
                    int Y = 50 - Temp / 100;
                    int X = 50 - Temp % 100;
                    Index = Y * 100 + X;
                    Count++;
                    Table[Y, X] = 10000;
                    for (int i = 0; i < Side; i++)
                    {
                        for (int j = 0; j < Side; j++)
                        {
                            if (Table[i, j] >= 10000)
                            {
                                Table[i, j] -= 10000;
                            }
                        }
                    }
                    if (Size < 7)
                    {
                        if (Count >= 2) // 3
                        {
                            Size = 3;
                            if (Count >= 5) // 4
                            {
                                Size = 4;
                                if (Count >= 9) // 5
                                {
                                    Size = 5;
                                    if (Count >= 14) // 6
                                    {
                                        Size = 6;
                                        if (Count >= 20)
                                        {
                                            Size = 7;
                                        }
                                    }
                                }

                            }
                        }
                    }

                    int CCount = CQueue.Count;
                    for (int i = 0; i < CCount; i++)
                    {
                        CQueue.Dequeue();
                    }
                    Trigger = true;
                    BQueue.Enqueue(Index);
                    Sum += Phase;
                    Phase = 0;
                    Table[Y, X] = 10000;
                }


            }
            Console.WriteLine(Sum);
        }
        public static void B1211A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int HCount = int.Parse(Reader.ReadLine());
            if (HCount == 1)
            {
                int Inpt = int.Parse(Reader.ReadLine());
                if (Inpt > 1440)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(Inpt);
                }
            }
            else
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int[] Table = new int[HCount];
                int Sum = 0;
                for (int i = 0; i < HCount; i++)
                {
                    Table[i] = int.Parse(Inpts[i]);
                    Sum += Table[i];
                }
                if (Sum > 2800)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Array.Sort(Table); Array.Reverse(Table); int Index = 0; int Answer = 0;
                    while (Index < HCount - 1)
                    {
                        if (Table[Index] == 0)
                        {
                            Index++;
                        }
                        else
                        {
                            int NIndex = Index + 1;
                            while (NIndex < HCount && Table[Index] != 0)
                            {
                                if (Table[NIndex] == 0)
                                {
                                    NIndex++;
                                }
                                else
                                {
                                    if (Table[NIndex] < Table[Index])
                                    {
                                        Answer += Table[NIndex];
                                        Table[Index] -= Table[NIndex];
                                        Table[NIndex] = 0;
                                        NIndex++;
                                    }
                                    else
                                    {
                                        Answer += Table[Index];
                                        Table[NIndex] -= Table[Index];
                                        Table[Index] = 0;
                                    }
                                }
                            }
                            if (Table[Index] == 0)
                            {
                                Index++;
                            }
                            else
                            {
                                Answer += Table[Index];
                                break;
                            }
                        }
                    }
                    if (Table[HCount - 1] != 0)
                    {
                        Answer += Table[HCount - 1];
                    }
                    if (Answer > 1440)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(Answer);
                    }
                }
            }
        }
        public static void B1211C()
        {
            int Inpt = int.Parse(Console.ReadLine());
            double Sum = 0;
            for (int i = 0; i < Inpt; i++)
            {
                Sum += (double)Inpt / (double)(Inpt - i);
            }
            Console.WriteLine(Sum);
        }
        public static void B1211D()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Case = int.Parse(Condition[0]); int Money = int.Parse(Condition[1]);
            int[,] Table = new int[Case, 3];
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                for (int j = 0; j < 3; j++)
                {
                    Table[i, j] = int.Parse(Inpts[j]);
                }
            }

        }
        public static void B7662()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());

            for (int CaseCount = 0; CaseCount < Case; CaseCount++)
            {
                PriorityQueue<long, long> MaxHeap = new PriorityQueue<long, long>();
                PriorityQueue<long, long> MinHeap = new PriorityQueue<long, long>();
                Dictionary<long, long> CountTable = new Dictionary<long, long>();
                int Orders = int.Parse(Reader.ReadLine());
                for (int OrderIndex = 0; OrderIndex < Orders; OrderIndex++)
                {
                    string Inpt = Reader.ReadLine();
                    string[] Inpts = Inpt.Split(" ");
                    long Value = int.Parse(Inpts[1]);

                    if (Inpts[0] == "I")
                    {
                        MaxHeap.Enqueue(Value, -Value); MinHeap.Enqueue(Value, Value);
                        long Temp = 0;
                        if (CountTable.TryGetValue(Value, out Temp))
                        {
                            CountTable[Value] += 1;
                        }
                        else
                        {
                            CountTable.Add(Value, 1);
                        }

                    }
                    else
                    {
                        if (CountTable.Count > 0)
                        {
                            if (Value == 1)
                            { // 최대 빼기
                                bool Trigger = true;

                                while (Trigger)
                                {
                                    long Temp = MaxHeap.Peek();
                                    long Temp2 = 0;
                                    if (CountTable.TryGetValue(Temp, out Temp2))
                                    {
                                        Trigger = false;
                                        if (Temp2 == 1)
                                        {
                                            CountTable.Remove(Temp);
                                        }
                                        else
                                        {
                                            CountTable[Temp]--;
                                        }
                                    }
                                    else
                                    {
                                        MaxHeap.Dequeue();
                                    }
                                }

                            }
                            else
                            { // 최소 빼기
                                bool Trigger = true;

                                while (Trigger)
                                {
                                    long Temp = MinHeap.Peek();
                                    long Temp2 = 0;
                                    if (CountTable.TryGetValue(Temp, out Temp2))
                                    {
                                        Trigger = false;
                                        if (Temp2 == 1)
                                        {
                                            CountTable.Remove(Temp);
                                        }
                                        else
                                        {
                                            CountTable[Temp]--;
                                        }
                                    }
                                    MinHeap.Dequeue();
                                }
                            }
                        }

                    }

                }
                if (CountTable.Count > 0)
                {
                    if (true)
                    {

                        while (true)
                        {
                            long Temp = MinHeap.Peek();
                            long Temp2 = 0;
                            if (CountTable.TryGetValue(Temp, out Temp2))
                            {
                                break;
                            }
                            MinHeap.Dequeue();
                        }

                        while (true)
                        {
                            long Temp = MaxHeap.Peek();
                            long Temp2 = 0;
                            if (CountTable.TryGetValue(Temp, out Temp2))
                            {
                                break;
                            }
                            else
                            {
                                MaxHeap.Dequeue();
                            }
                        }

                    }
                }
                if (CountTable.Count == 0)
                {
                    SB.AppendLine("EMPTY");
                }
                else
                {
                    SB.AppendLine(MaxHeap.Peek().ToString() + " " + MinHeap.Peek().ToString());
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B2407()
        {
            string[] Inpts = Console.ReadLine().Split(" ");
            int[] SosuTable = new int[25] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int[] CountTable = new int[25];
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
            BigInteger Answer2 = new BigInteger();
            Answer2 = 1;
            nuint Answer = 1;
            if (Fst / 2 < Scd)
            {
                Scd = Fst - Scd;
            }
            for (int i = 0; i < Scd; i++)
            {
                int Temp = Fst - i;
                SoinsuBunkaiAdd(Temp);

            }
            for (int i = 1; i < Scd; i++)
            {
                int Temp = (i + 1);
                SoinsuBunkaiMinus(Temp);
            }
            for (int i = 0; i < 25; i++)
            {
                Answer2 = Answer2 * (BigInteger)Math.Pow(SosuTable[i], CountTable[i]);
            }

            Console.WriteLine(Answer2);
            void SoinsuBunkaiAdd(int Inpt)
            {
                int Temp = Inpt;
                while (Temp != 1)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        if (Temp % SosuTable[i] == 0)
                        {
                            CountTable[i]++;
                            Temp /= SosuTable[i];
                            break;
                        }
                    }
                }
            }
            void SoinsuBunkaiMinus(int Inpt)
            {
                int Temp = Inpt;
                while (Temp != 1)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        if (Temp % SosuTable[i] == 0)
                        {
                            CountTable[i]--;
                            Temp /= SosuTable[i];
                            break;
                        }
                    }
                }
            }
        }
        public static void B15650()
        {
            string[] Inpts = Console.ReadLine().Split(" "); StringBuilder SB = new StringBuilder();
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
            if (Fst == Scd)
            {
                for (int i = 0; i < Scd; i++)
                {
                    SB.Append((i + 1).ToString());
                    if (i != Scd - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }
            else
            {
                int Limit = 1; int Count = 0;
                int[] CountTable = new int[Scd];
                for (int i = 0; i < Scd; i++)
                {
                    Limit = Limit * (Fst - i) / (i + 1);
                    CountTable[i] = i + 1;
                }
                Answering();
                Count++;

                while (Count < Limit)
                {
                    bool Trigger = true;
                    for (int i = 0; i < Scd; i++)
                    {
                        if (Trigger)
                        {
                            if (CountTable[Scd - 1 - i] != Fst)
                            {
                                Count++;
                                CountTable[Scd - 1 - i]++;
                                Answering();
                                break;
                            }
                            else
                            {
                                Trigger = false;
                            }
                        }
                        else
                        {
                            if (CountTable[Scd - 1 - i] != Fst)
                            {
                                if (CountTable[Scd - 1 - i] + i + 1 > Fst) continue;
                                Count++;
                                CountTable[Scd - 1 - i]++;
                                for (int j = Scd - i; j < Scd; j++)
                                {
                                    CountTable[j] = CountTable[j - 1] + 1;
                                }
                                Answering();
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                }

                void Answering()
                {
                    for (int i = 0; i < Scd; i++)
                    {
                        SB.Append(CountTable[i].ToString());
                        if (i != Scd - 1)
                        {
                            SB.Append(" ");
                        }
                    }
                    SB.AppendLine("");
                }
            }

            Console.WriteLine(SB.ToString());
        }
        public static void B15652()
        {
            string[] Inpts = Console.ReadLine().Split(" "); StringBuilder SB = new StringBuilder();
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);


            int Limit = 1; int Count = 0;
            int[] CountTable = new int[Scd];
            for (int i = 0; i < Scd; i++)
            {
                Limit = Limit * (Fst + Scd - 1 - i) / (i + 1);
                CountTable[i] = 1;
            }
            Answering();
            Count++;

            while (Count < Limit)
            {
                bool Trigger = true;
                for (int i = 0; i < Scd; i++)
                {
                    if (Trigger)
                    {
                        if (CountTable[Scd - 1 - i] != Fst)
                        {
                            Count++;
                            CountTable[Scd - 1 - i]++;
                            Answering();
                            break;
                        }
                        else
                        {
                            Trigger = false;
                        }
                    }
                    else
                    {
                        if (CountTable[Scd - 1 - i] != Fst)
                        {
                            Count++;
                            CountTable[Scd - 1 - i]++;
                            for (int j = Scd - i; j < Scd; j++)
                            {
                                CountTable[j] = CountTable[j - 1];
                            }
                            Answering();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }

            void Answering()
            {
                for (int i = 0; i < Scd; i++)
                {
                    SB.Append(CountTable[i].ToString());
                    if (i != Scd - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B15654()
        {
            string[] Inpts = Console.ReadLine().Split(" "); StringBuilder SB = new StringBuilder();
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
            string[] Inpts2 = Console.ReadLine().Split(" ");
            int[] Table = new int[Fst];
            for (int i = 0; i < Fst; i++)
            {
                Table[i] = int.Parse(Inpts2[i]);
            }
            Array.Sort(Table);
            if (Fst == Scd)
            {
                for (int i = 0; i < Scd; i++)
                {
                    SB.Append((Table[i]).ToString());
                    if (i != Scd - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }
            else
            {
                int Limit = 1; int Count = 0;
                int[] CountTable = new int[Scd];
                for (int i = 0; i < Scd; i++)
                {
                    Limit = Limit * (Fst - i) / (i + 1);
                    CountTable[i] = i + 1;
                }
                Answering();
                Count++;

                while (Count < Limit)
                {
                    bool Trigger = true;
                    for (int i = 0; i < Scd; i++)
                    {
                        if (Trigger)
                        {
                            if (CountTable[Scd - 1 - i] != Fst)
                            {
                                Count++;
                                CountTable[Scd - 1 - i]++;
                                Answering();
                                break;
                            }
                            else
                            {
                                Trigger = false;
                            }
                        }
                        else
                        {
                            if (CountTable[Scd - 1 - i] != Fst)
                            {
                                if (CountTable[Scd - 1 - i] + i + 1 > Fst) continue;
                                Count++;
                                CountTable[Scd - 1 - i]++;
                                for (int j = Scd - i; j < Scd; j++)
                                {
                                    CountTable[j] = CountTable[j - 1] + 1;
                                }
                                Answering();
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                }

                void Answering()
                {
                    for (int i = 0; i < Scd; i++)
                    {
                        SB.Append(Table[CountTable[i] - 1].ToString());
                        if (i != Scd - 1)
                        {
                            SB.Append(" ");
                        }
                    }
                    SB.AppendLine("");
                }
            }

            Console.WriteLine(SB.ToString());
        }
        public static void B15654_1()
        {
            string[] Inpts = Console.ReadLine().Split(" "); StringBuilder SB = new StringBuilder();
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
            string[] Inpts2 = Console.ReadLine().Split(" ");
            int[] Table = new int[Fst];
            int[] IndexTable = new int[Fst];
            for (int i = 0; i < Fst; i++)
            {
                Table[i] = int.Parse(Inpts2[i]);
                IndexTable[i] = i;
            }
            Array.Sort(Table);

            PriorityQueue<int, int> PQ = new PriorityQueue<int, int>();
            Sunyeol(IndexTable, 0, Fst, Scd);
            int PQCount = PQ.Count;
            for (int i = 0; i < PQCount; i++)
            {
                int Answer = PQ.Dequeue();
                string TAnswer = Answer.ToString();
                for (int j = 0; j < TAnswer.Length; j++)
                {
                    SB.Append(Table[(TAnswer[j] - '0') - 1].ToString());
                    if (j != TAnswer.Length - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }

            Console.WriteLine(SB.ToString());
            void Sunyeol(int[] IndTable, int Depth, int AllCount, int SelectCount)
            {
                if (Depth == SelectCount)
                {
                    int Sum = 0;
                    for (int i = 0; i < SelectCount; i++)
                    {
                        Sum += (int)Math.Pow(10, i) * (IndTable[SelectCount - 1 - i] + 1);
                    }
                    PQ.Enqueue(Sum, Sum);
                }
                for (int i = Depth; i < AllCount; i++)
                {
                    Swap(IndTable, i, Depth);
                    Sunyeol(IndTable, Depth + 1, AllCount, SelectCount);
                    Swap(IndTable, i, Depth);

                }
            }
            void Swap(int[] IndTable, int i, int j)
            {
                int Temp = IndTable[i];
                IndTable[i] = IndTable[j];
                IndTable[j] = Temp;
            }


        }
        public static void B15657()
        {
            string[] Inpts = Console.ReadLine().Split(" "); StringBuilder SB = new StringBuilder();
            int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
            string[] Inpts2 = Console.ReadLine().Split(" ");
            int[] Table = new int[Fst];
            for (int i = 0; i < Fst; i++)
            {
                Table[i] = int.Parse(Inpts2[i]);
            }
            Array.Sort(Table);
            int Limit = 1; int Count = 0;
            int[] CountTable = new int[Scd];
            for (int i = 0; i < Scd; i++)
            {
                Limit = Limit * (Fst + Scd - 1 - i) / (i + 1);
                CountTable[i] = 1;
            }
            Answering();
            Count++;

            while (Count < Limit)
            {
                bool Trigger = true;
                for (int i = 0; i < Scd; i++)
                {
                    if (Trigger)
                    {
                        if (CountTable[Scd - 1 - i] != Fst)
                        {
                            Count++;
                            CountTable[Scd - 1 - i]++;
                            Answering();
                            break;
                        }
                        else
                        {
                            Trigger = false;
                        }
                    }
                    else
                    {
                        if (CountTable[Scd - 1 - i] != Fst)
                        {
                            Count++;
                            CountTable[Scd - 1 - i]++;
                            for (int j = Scd - i; j < Scd; j++)
                            {
                                CountTable[j] = CountTable[j - 1];
                            }
                            Answering();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }

            void Answering()
            {
                for (int i = 0; i < Scd; i++)
                {
                    SB.Append(Table[CountTable[i] - 1].ToString());
                    if (i != Scd - 1)
                    {
                        SB.Append(" ");
                    }
                }
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11053()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Counts = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Counts + 1];
            for (int i = 0; i < Counts; i++)
            {
                Table[i + 1] = int.Parse(Inpts[i]);
            }
            int[] AnswerTable = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table[j] < Table[i])
                    {
                        if (Max <= AnswerTable[j])
                        {
                            Max = AnswerTable[j];
                        }
                    }
                }
                AnswerTable[i] = Max + 1;
            }
            Console.WriteLine(AnswerTable.Max());
        }
        public static void B11055()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Counts = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Counts + 1];
            for (int i = 0; i < Counts; i++)
            {
                Table[i + 1] = int.Parse(Inpts[i]);
            }
            int[] AnswerTable = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                int MaxTemp = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table[j] < Table[i])
                    {
                        if (Max <= AnswerTable[j])
                        {
                            Max = AnswerTable[j];
                            MaxTemp = AnswerTable[j] + Table[i];
                        }
                    }
                }
                AnswerTable[i] = MaxTemp;
            }
            Console.WriteLine(AnswerTable.Max());
        }
        public static void B11722()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Counts = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Counts + 1];
            for (int i = 0; i < Counts; i++)
            {
                Table[i + 1] = int.Parse(Inpts[i]);
            }
            Table[0] = 1001;
            int[] AnswerTable = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table[j] > Table[i])
                    {
                        if (Max <= AnswerTable[j])
                        {
                            Max = AnswerTable[j];
                        }
                    }
                }
                AnswerTable[i] = Max + 1;
            }
            Console.WriteLine(AnswerTable.Max());
        }
        public static void B12015()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Counts = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Counts + 1];
            for (int i = 0; i < Counts; i++)
            {
                Table[i + 1] = int.Parse(Inpts[i]);
            }
            int[] AnswerTable = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table[j] < Table[i])
                    {
                        if (Max <= AnswerTable[j])
                        {
                            Max = AnswerTable[j];
                        }
                    }
                }
                AnswerTable[i] = Max + 1;
            }
            Console.WriteLine(AnswerTable.Max());
        }
        public static void B11054()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Counts = int.Parse(Reader.ReadLine());
            string[] Inpts = Reader.ReadLine().Split(" ");
            int[] Table = new int[Counts + 1];
            for (int i = 0; i < Counts; i++)
            {
                Table[i + 1] = int.Parse(Inpts[i]);
            }
            int[] AnswerTable = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table[j] < Table[i])
                    {
                        if (Max <= AnswerTable[j])
                        {
                            Max = AnswerTable[j];
                        }
                    }
                }
                AnswerTable[i] = Max + 1;
            }

            int[] Table2 = new int[Counts + 1];
            int[] AnswerTable2 = new int[Counts + 1];
            for (int i = 1; i <= Counts; i++)
            {
                Table2[i] = Table[Counts + 1 - i]; ;
            }
            Table2[0] = 0;
            for (int i = 1; i <= Counts; i++)
            {
                int Max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (Table2[j] < Table2[i])
                    {
                        if (Max <= AnswerTable2[j])
                        {
                            Max = AnswerTable2[j];
                        }
                    }
                }
                AnswerTable2[i] = Max + 1;
            }
            int MaxSum = 0;
            for (int i = 1; i <= Counts; i++)
            {
                if (MaxSum < AnswerTable[i] + AnswerTable2[Counts + 1 - i])
                {
                    MaxSum = AnswerTable[i] + AnswerTable2[Counts + 1 - i];
                }
            }
            Console.WriteLine(MaxSum - 1);
        }
        public static void B1005()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            StringBuilder SB = new StringBuilder();
            for (int c = 0; c < Case; c++)
            {
                string[] Condition = Reader.ReadLine().Split(" ");
                int NodeCount = int.Parse(Condition[0]); int LineCount = int.Parse(Condition[1]);
                string[] NodeInput = Reader.ReadLine().Split(" "); int[] NodeTime = new int[NodeCount + 1];
                bool[,] LineTable = new bool[NodeCount + 1, NodeCount + 1];
                int[] StartTable = new int[NodeCount + 1];
                Array.Fill(StartTable, 1); Queue<int> BQueue = new Queue<int>(); Queue<int> CQueue = new Queue<int>();

                for (int i = 0; i < LineCount; i++)
                {
                    string[] LineInpt = Reader.ReadLine().Split(" ");
                    int Fst = int.Parse(LineInpt[0]); int Scd = int.Parse(LineInpt[1]);
                    LineTable[Fst, Scd] = true; StartTable[Scd] = -1;
                }
                for (int i = 1; i <= NodeCount; i++)
                {
                    NodeTime[i] = int.Parse(NodeInput[i - 1]);
                    if (StartTable[i] == 1)
                    {
                        BQueue.Enqueue(i);
                        StartTable[i] = NodeTime[i];
                    }
                }

                int Goal = int.Parse(Reader.ReadLine());

                //BQUEUE = 현재 지어져 있는 건물
                while (StartTable[Goal] == -1)
                {
                    //1. 무엇을 만들 수 있는지
                    //2. 만드는데 충분한 건물이 지어져 잇는지
                    CQueue.Clear();
                    int TempNode = BQueue.Dequeue();
                    for (int i = 1; i <= NodeCount; i++)
                    {
                        if (LineTable[TempNode, i])
                        {
                            if (StartTable[i] == -1)
                            {
                                CQueue.Enqueue(i);
                            }
                        }
                    }
                    int CCount = CQueue.Count();
                    bool WholeTrigger = true;
                    for (int i = 0; i < CCount; i++)
                    {
                        int TempNextNode = CQueue.Dequeue();
                        bool Trigger = true; int Max = 0;
                        for (int j = 1; j <= NodeCount; j++)
                        {
                            if (LineTable[j, TempNextNode])
                            {
                                if (StartTable[j] == -1)
                                {//이거 못 만듬
                                    Trigger = false;
                                    break;
                                }
                                else
                                {
                                    Max = Math.Max(StartTable[j], Max);
                                }
                            }
                        }
                        if (!Trigger)
                        { // 못 만듬
                            if (WholeTrigger)
                            {
                                BQueue.Enqueue(TempNode);
                                WholeTrigger = false;
                            }
                        }
                        else
                        {// 만듬
                            StartTable[TempNextNode] = Max + NodeTime[TempNextNode];
                            BQueue.Enqueue(TempNextNode);
                        }
                    }
                }
                SB.AppendLine(StartTable[Goal].ToString());

            }
            Console.WriteLine(SB.ToString());
        }
        public static void B20221217_A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int BigData = 0; int Security = 0;
            string Inpt = Reader.ReadLine();
            int Index = 0; int Len = Inpt.Length;
            while (Index < Len)
            {
                if (Inpt[Index] == 'b')
                {
                    BigData++;
                    Index += 7;
                }
                else
                {
                    Security++;
                    Index += 8;
                }
            }
            if (BigData == Security)
            {
                Console.WriteLine("bigdata? security!");
            }
            else if (BigData > Security)
            {
                Console.WriteLine("bigdata?");
            }
            else
            {
                Console.WriteLine("security!");
            }

        }
        public static void B20221217_B()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            List<KeyValuePair<string, string>> PairList = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < Case; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                KeyValuePair<string, string> Temp = new KeyValuePair<string, string>(Inpts[0], Inpts[1]);
                PairList.Add(Temp);

            }
            PairList = PairList.OrderByDescending(x => x.Value).ToList();
            PairList = PairList.OrderBy(x => x.Key).ToList();
            int DCount = PairList.Count();
            for (int i = 0; i < DCount; i++)
            {
                SB.Append(PairList[i].Key);
                SB.Append(" ");
                SB.Append(PairList[i].Value);
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());

        }
        public static void B20221217_C()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            string Original = Reader.ReadLine();
            string Encording = Reader.ReadLine();
            int Len = Original.Length;
            string Key = "";
            for (int i = 0; i < Len; i++)
            {
                if (Encording[i] - Original[i] <= 0)
                {
                    int Temp = Encording[i] - Original[i] + 26 + 'A' - 1;
                    char Temp2 = (char)Temp;
                    SB.Append(Temp2);
                }
                else
                {
                    char Temp = (char)(Encording[i] - Original[i] + 'A' - 1);
                    SB.Append(Temp);
                }
            }
            Key = SB.ToString();
            SB.Clear();
            int Index = 2;
            bool Trigger = true; char Fst = Key[0];
            for (int i = 0; i < Len; i++)
            {
                if (Key[i] != Fst)
                {
                    Trigger = false;
                    break;
                }
            }
            if (Trigger)
            {  //얘 1임
                Console.WriteLine(Key[0]);
            }
            else
            {
                string TempKey = "";
                bool MaxTrigger = false;
                while (true)
                {
                    if (Index > Len / 2)
                    {
                        MaxTrigger = true;
                        break;
                    }
                    if (Len % Index != 0)
                    {
                        Index++;
                        continue;
                    }
                    TempKey = "";
                    SB.Clear();
                    for (int i = 0; i < Index; i++)
                    {
                        SB.Append(Key[i]);
                    }
                    TempKey = SB.ToString();
                    bool TempTrigger = false;
                    for (int i = 0; i < Len; i++)
                    {
                        if (Key[i] != TempKey[i % Index])
                        {
                            TempTrigger = true;
                            break;
                        }
                    }
                    if (TempTrigger)
                    { //얘 아님
                        Index++;
                    }
                    else
                    { // 얘 맞음
                        break;
                    }
                }
                if (MaxTrigger)
                {
                    Console.WriteLine(Key);
                }
                else
                {

                    Console.WriteLine(TempKey);
                }
            }


        }
        public static void B20221217_D()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            Dictionary<int, BigInteger> Dict = new Dictionary<int, BigInteger>();
            BigInteger Max = 0;
            for (int c = 0; c < Case; c++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpts[0]);
                int Scd = int.Parse(Inpts[1]);
                int Thd = int.Parse(Inpts[2]);
                int Minus = Scd - Fst;
                if (Dict.TryGetValue(Minus, out BigInteger Value))
                {
                    Dict[Minus] += Thd;
                    if (Max < Dict[Minus])
                    {
                        Max = Dict[Minus];
                    }
                }
                else
                {
                    Dict.Add(Minus, Thd);
                    if (Max < Dict[Minus])
                    {
                        Max = Dict[Minus];
                    }
                }
            }
            Console.WriteLine(Max);


        }
        public static void B20221217_F()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Condition = Reader.ReadLine().Split(" ");
            int Fst = int.Parse(Condition[0]); int Scd = int.Parse(Condition[1]); BigInteger Thd = int.Parse(Condition[2]);
            int[] CountTable = new int[Fst + 1];
            Array.Fill(CountTable, 1);
            if (Fst * 2 - 1 > Scd)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int Phase = (Fst * 2 - 1 - Scd) / 2;
                if (Phase == 0)
                {
                    if (Scd % 2 == 1)
                    {
                    }
                    else
                    {
                        CountTable[Fst] = 2;
                    }
                    for (int i = 1; i <= Fst; i++)
                    {
                        for (int j = 1; j <= CountTable[i]; j++)
                        {
                            SB.Append(i.ToString());
                            SB.Append(" ");
                        }
                    }
                    for (int i = Fst - 1; i >= 1; i--)
                    {
                        for (int j = 1; j <= CountTable[i]; j++)
                        {
                            SB.Append(i.ToString());
                            SB.Append(" ");
                        }
                    }
                    SB.AppendLine("");
                    Console.WriteLine(SB.ToString());
                }
                else
                {
                    BigInteger MaxCount = 1;
                    for (int i = 0; i < Phase; i++)
                    {
                        MaxCount = MaxCount * (Fst + Phase - 1 - i) / (i + 1);
                    }
                    if (MaxCount < Thd)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        if (Phase == 1)
                        {
                            BigInteger Temp = Thd % (BigInteger)Fst;
                            if (Temp == 0) Temp = Fst;
                            CountTable[(int)Temp]++;
                        }
                        else
                        {
                            BigInteger Temp = Thd % (BigInteger)Fst;
                            if (Temp == 0) Temp = Fst;
                            CountTable[(int)Temp]++;
                            int TempIndex = 1;
                            while (true)
                            {
                                if (Thd < (BigInteger)Math.Pow(Fst, TempIndex)) break;
                                Temp = Thd / (BigInteger)Math.Pow(Fst, TempIndex) % (BigInteger)Fst;
                                if (Temp == 0) Temp = Fst;
                                CountTable[(int)Temp]++;
                                TempIndex++;
                            }
                        }
                        for (int i = 1; i <= Fst; i++)
                        {
                            for (int j = 1; j <= CountTable[i]; j++)
                            {
                                SB.Append(i.ToString());
                                SB.Append(" ");
                            }
                        }
                        for (int i = Fst - 1; i >= 1; i--)
                        {
                            for (int j = 1; j <= CountTable[i]; j++)
                            {
                                SB.Append(i.ToString());
                                SB.Append(" ");
                            }
                        }
                        SB.AppendLine("");
                        Console.WriteLine(SB.ToString());

                    }
                }
            }
        }
        public static void B5338()
        {
            Console.WriteLine("       _.-;;-._");
            Console.WriteLine("'-..-'|   ||   |");
            Console.WriteLine("'-..-'|_.-;;-._|");
            Console.WriteLine("'-..-'|   ||   |");
            Console.WriteLine("'-..-'|_.-''-._|");
        }
        public static void B11725()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Nodes = int.Parse(Reader.ReadLine());
            int[] MarkTable = new int[Nodes + 1];
            MarkTable[0] = 1;
            MarkTable[1] = 1;
            for (int i = 1; i < Nodes; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
                if (MarkTable[Fst] == 0)
                { // fst 새거  = scd가 있음
                    int temp = Fst;
                    Fst = Scd;
                    Scd = temp;
                }
                //fst 있음 scd 새거
                MarkTable[Scd] = Fst;
            }
            for (int i = 2; i <= Nodes; i++)
            {
                SB.AppendLine(MarkTable[i].ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11725_1()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Nodes = int.Parse(Reader.ReadLine());
            Queue<int> BQueue = new Queue<int>();
            List<int>[] LineList = new List<int>[Nodes + 1];
            int[] MarkedTable = new int[Nodes + 1];
            for (int i = 0; i < Nodes + 1; i++)
            {
                LineList[i] = new List<int>();
            }
            for (int i = 1; i < Nodes; i++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                int Fst = int.Parse(Inpts[0]); int Scd = int.Parse(Inpts[1]);
                LineList[Fst].Add(Scd); LineList[Scd].Add(Fst);

            }
            BQueue.Enqueue(1);
            MarkedTable[0] = 1; MarkedTable[1] = 1;
            while (BQueue.Count > 0)
            {
                int BQueueInput = BQueue.Dequeue();
                foreach (int B in LineList[BQueueInput])
                {
                    if (MarkedTable[B] != 0)
                    {
                        continue;
                    }
                    else
                    {
                        BQueue.Enqueue(B);
                        MarkedTable[B] = BQueueInput;
                    }
                }
            }

            for (int i = 2; i <= Nodes; i++)
            {
                SB.AppendLine(MarkedTable[i].ToString());
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B24900()
        {
            Console.WriteLine("                                                           :8DDDDDDDDDDDDDD$.");
            Console.WriteLine("                                                      DDDNNN8~~~~~~~~~~=~7DNNDNDDDNNI");
            Console.WriteLine("                                                  ?NNDD=~=~~~~~~~~~~~~~~~~~=~~==~=INNDNN7");
            Console.WriteLine("                                               +NDDI~~~~~~~~~~~~~~~~~~~~~~~=~~========~ODND+");
            Console.WriteLine("                                            :NND~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~============7NDN");
            Console.WriteLine("                                          $DD$~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~==============~DNN");
            Console.WriteLine("                                        $DD=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~=================NND");
            Console.WriteLine("                                       ND7~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~===================DD7");
            Console.WriteLine("                                     ~DD=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=======================8DN.");
            Console.WriteLine("                                    8DO~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=========================DD");
            Console.WriteLine("                                   8N~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~=======================DN");
            Console.WriteLine("                                  NN::::::::~~~~~~~~~~~=~~~~~~~~~~~~~~~~~~~=~~========================DDO");
            Console.WriteLine("                                 $D$:::::::::::::::~~~~DD~~~~~~~~~~~~~~~~~~=~~=========================DN.");
            Console.WriteLine("                                 D8:::::::::::::::::::DN=::~~~~~~~~~~~~~~~~=~~======================~~:~DN");
            Console.WriteLine("                                DN:::::::::::::::::::ONO::::::::::::::::::::~~~~~~~~~~~~:::::::::::::::::DN");
            Console.WriteLine("                               DN::::::::::::::::::::NN.:::::::::::::::::::::::::::DN::::::::::::::::::::$DO");
            Console.WriteLine("                               DD:::::::::::::::::::DNI:::::::::::::::::::::::::::::D=::::::::::::::::::::NN");
            Console.WriteLine("                              NN~~~~:::::$N?:::::::.NN::::::::::::::::::::::::::::::ND.:::::::::::::::::::+N8");
            Console.WriteLine("                              N7~~~~~~~~OD7::::::::~DD::::::::::::::::::::::::::::::~D$::::::::::::::::::::DN");
            Console.WriteLine("                             NN~~~~~~~~IDZ~~~~~::::DN~:::::::::::::::::::::::::::::::DN::::::::::::::::::::=N~");
            Console.WriteLine("                             DD~~~~~~~~NN~~~~~~~~~=NN::::::::::::::::::::::::::::::::DN:::::::::::::::~~====NN");
            Console.WriteLine("                            8D~~~~~~~~ND~~~~~~~~~~~ND~~~~~~~~:::::::::::::::::::::::::N7:::~~===============NN");
            Console.WriteLine("                            DD~~~~~~~ON+~~~~~~~~~~~ND~~~~~~~~~~~~~~~~~~~=+NZ==========NN====================~ND");
            Console.WriteLine("               :DD7   DNDD. N8~~~~~~~NN~~~~~~~~~~DDND~~~~~~~~~~~~~~~~~~~~ND~~=========DD=====================ND");
            Console.WriteLine("               N~:DDNNN .8NDN~~~~~~~$D=~~~~~~~~+ND.DD~~~~~~~~~~~~~~~~~~~=DD~~=========~D+====================DN");
            Console.WriteLine("              :D     .  ..~ND~~~~~~~NN~~~~~~~+NN$..ND~~~~~~~~~~~~~~~~~~~7N=~~=========~ND=======~============ON");
            Console.WriteLine("              NN       ...:N?~~~~~~~N=~~~~~NNNI.. .7D+~~~~~~~~~~~~~~~~~=8NN~~==========NN=======N============$N");
            Console.WriteLine("         N  ODN       ....DN~~~~~~~DD=8NNND$..     .DD~~~=~~~~~~~~~~~~~=NNDD=~=========8D~======NN===========~N$");
            Console.WriteLine("    N? =NN  ND      .....NND~~~~~~~DDNN:...        .ND=~DNN~~~~~~~~~~~~=DN.DN~=========?N+======NN============ND");
            Console.WriteLine("   $D? DN    DZ    ....ND8NN~~~~~~$D                .DD~NNDD~~~~~~~~~~~~D8..DN=========~DN======NN============DN");
            Console.WriteLine("   DN ~N~   NN    ..:~NN..NZ~~~~~~DN                  NNN8.ND~~~~NDN?~~~DZ...7DD=======~NN======NN============DN");
            Console.WriteLine("   ND DD    :DN.  ..ND$  .N?~~~~~=NNN                   . ..DDD$~N8OND8=N+   ..DDDZ~====NN======+D+===========ND");
            Console.WriteLine("   NO         DD  ZDN    8NO~~~~~~NNN..DDDNN7               ...NND...:DDD:     .:.NDND=~DD======~DO===========DN");
            Console.WriteLine("              DNDDN:.    DN~~~~~~=NNNN.ODNNNNDDNNO              ...     .         ...DNNNN=======ND===========DD");
            Console.WriteLine("       INDN7    DD.     .DD~~~~~=IDND:.:~.....?DNDNN.                        ...... ....$D=======ND===========ND");
            Console.WriteLine("       NN        ND.    8N=~~~~$ND::.:=~:.~=......=ND~                 .NNNNNNNNNNNNNNN.~N+======NN===========DN");
            Console.WriteLine("       $DD        DN:   DD~~~~7NO...~==.:~~:.....                      NNNND? ..::..7NZ.:N?======8D~==========ZN");
            Console.WriteLine("       DN?     ~D: DND.?D~~~~~DD....~:.~=~.......                            ....~=:.:~..ND======~N$==========~DO");
            Console.WriteLine("       ND    ..DD.  .DNDN=~~~~DI.......:.........                           ....=~..~~~..DN======~DD===========NN");
            Console.WriteLine("       DDD  :.:DD.  . DDI~~~~~ND................        .DNNNNNNNNNN7      ....=~:.:~~...NN=======ND===========?D~");
            Console.WriteLine("       8D. ...OD..    DD~~~~~~+ND ............          NN:~::::~~~8N      ........~~...:ND=======DN============NN");
            Console.WriteLine("       DDI:...ND     .D7~~~~~~~7NN ..........           ID8::::::::8D      .............:DN=======ON============NN");
            Console.WriteLine("        ~NNND.N=.   .NN~~~~~~~~~NDN8                       ~::::::~N8       .............DN========D=============NI");
            Console.WriteLine("               DDNNN.ND~~~~~~~~DD =DND                                       ............DN========N+~===========NN");
            Console.WriteLine("                   ~:N=~~~~~~~~DD   .DDDD                                       ........ NN========DD============8D");
            Console.WriteLine("                    8N~~~~~~~~~ND    . .7NDDD? .                                      .8DDN========NN=============D:");
            Console.WriteLine("                    DD~~~~~~~~~DND:         IDNNND$.                           .+DNNNNDNIDN========DD=============DD");
            Console.WriteLine("                    ND~~~~~~~~ZN 7DD .. .:DDNDDNNDNNNNDDNDND8$?===+$8DDNNNDDDDDN8I~DN====8N========NN=============NN");
            Console.WriteLine("                    DD~~~~~~~~8N   DD.  .NN~~~~.~~=DNDNO.:7ODDDDNNDD8DDDND=~~~ =~~~ON====8N========DN=============DN");
            Console.WriteLine("                    ND~~~~~~~~DN    ZDD  DN~~~ ~~~~~=.7DDD+.......8NNN==~~~~~ ~~~~~ONN$==DN========8N=============ON");
            Console.WriteLine("                    ND~8N~=~~~ZN      DDODN=~.~~~~~=.~~~~INDNNNNDNN~~~~~~~~:~~~~~~~DN~ND=DN========DD=========~ND=8N");
            Console.WriteLine("                    IN=NDDI~~~~D8       DNN::~~~~~.~~~~~=.~~ND~~ND~~~~~~~~.~~~~~~~~NN  NDNN====ND==ND~D?======DNN=ND");
            Console.WriteLine("                     DNNI8ND=~~DN:       ZN=~~~~~ ~~~~~.~~~~DD~=DD~~~~~~~ ~~~~~~~=.ND. . ND===DNDD=NDDNN=====8NZDDDN");
            Console.WriteLine("                      NND  IDNDNNN+       D+~~~:~~~~~~ ~~~~~DDNNN+~~~~~~~~~~~~~~:=?N7   .ND=~ND  DNNN~ID====ND7 NNN");
            Console.WriteLine("                       ID                 ND~~ ~~~~~:.~~~7DDN7IDNN==~~ ~~~~~~~~ ~~DN   .:N?DDDDD NND  8N~=DDD  ZNN");
            Console.WriteLine("                                          NN~:~~~~~ =7DDDD+8N  :N8DDZ.~~~~~~~~.~~~DD.   NDD+ . DN=     OND+");
            Console.WriteLine("                                          DND~~~=8DNDDZ=~~ ND   NN~INND~~~~~.~~~~ND .    .    ..IDD");
            Console.WriteLine("                                         DDNNNDNNN+~~~~~~.7N.    ND~~~NDDI~ ~~~~=NNN             .DDI");
            Console.WriteLine("                                        DN=~~~~.=~~~~~~ ~~DN     +N+~~~~+DNDD~~~NNNND.            ..ND");
            Console.WriteLine("                                         DDI~~ ~~~~~~~ ~~~ND..  ..ND~~~~:~~~DNDNNNN+            ..7O8ND+");
            Console.WriteLine("                                          .DND=~~~~=::~~=NN.   . . 8D~~.~~~~~~=DN$ODNDNDNNNDNNNNND8+~..");
            Console.WriteLine("                                             8DNNI=.~~~~=NDDNNNNDDNDNN.~~~~~IDDNDND7:.");
            Console.WriteLine("                                                ?DNNDD?~DD          ~NN~~=NDD$");
            Console.WriteLine("                                                     :DDD.            NNNN=");
        }
        public static void B16953()
        {
            string[] Condition = Console.ReadLine().Split(" ");
            int Start = int.Parse(Condition[0]); int Goal = int.Parse(Condition[1]);
            Queue<long> BQueue = new Queue<long>(); Queue<long> CQueue = new Queue<long>();
            bool Trigger = true; int Phase = 0;
            BQueue.Enqueue(Start);
            while (BQueue.Count > 0)
            {
                Trigger = true;
                while (BQueue.Count > 0)
                {
                    long Temp = BQueue.Dequeue();
                    if (Goal < 2 * Temp)
                    {
                        continue;
                    }
                    if (Temp * 2 == Goal)
                    {
                        Trigger = false;
                        break;
                    }
                    if (Temp * 10 + 1 == Goal)
                    {
                        Trigger = false;
                        break;
                    }
                    CQueue.Enqueue(Temp * 2); CQueue.Enqueue(Temp * 10 + 1);

                }
                if (!Trigger)
                {
                    Phase++;
                    break;
                }
                else
                {
                    int CCount = CQueue.Count;
                    for (int i = 0; i < CCount; i++)
                    {
                        BQueue.Enqueue(CQueue.Dequeue());
                    }
                    Phase++;
                }

            }
            if (Trigger)
            {
                Console.WriteLine(-1);
            }
            else
            {

                Console.WriteLine(Phase + 1);
            }

        }
        public static void B15693()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Condition = Reader.ReadLine().Split(" ");
            int All = int.Parse(Condition[0]); int Peak = int.Parse(Condition[1]);
            string[] Inputs = Reader.ReadLine().Split(" ");
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            List<int> List = new List<int>();
            for (int i = 0; i < All; i++)
            {
                int Temp = int.Parse(Inputs[i]);
                if (Dict.TryGetValue(Temp, out int asd))
                {
                    Dict[Temp]++;
                }
                else
                {
                    Dict.Add(Temp, 1);
                    List.Add(Temp);
                }
            }
            List.Sort();
            int Len = List.Count;
            int Index = 0;
            List<int> AnswerList = new List<int>();
            int[] IndexTable = new int[All];
            for (int i = 0; i < Len; i++)
            {
                for (int j = 0; j < Dict[List[i]]; j++)
                {
                    IndexTable[Index] = i + 1;
                    Index++;
                }
            }
            Dict.Clear();
            Permutation(IndexTable, 0);
            AnswerList.Sort();
            int AnswerLen = AnswerList.Count;
            for (int a = 0; a < AnswerLen; a++)
            {
                string strAnswer = AnswerList[a].ToString();
                for (int i = 0; i < Peak; i++)
                {
                    SB.Append(List[(strAnswer[i] - '1')].ToString());
                    if (i != Peak - 1) SB.Append(" ");
                }
                SB.AppendLine("");
            }
            Console.WriteLine(SB.ToString());
            void Permutation(int[] IndTable, int Depth)
            {
                if (Depth == Peak)
                {
                    int Answer = 0;
                    for (int i = 0; i < Peak; i++)
                    {
                        Answer += IndTable[i] * (int)Math.Pow(10, Peak - 1 - i);
                    }
                    if (Dict.TryGetValue(Answer, out int temp))
                    {

                    }
                    else
                    {
                        Dict.Add(Answer, 1);
                        AnswerList.Add(Answer);
                    }
                    return;
                }
                for (int i = Depth; i < All; i++)
                {
                    Swap(IndTable, i, Depth);
                    Permutation(IndTable, Depth + 1);
                    Swap(IndTable, i, Depth);
                }


            }
            void Swap(int[] Table, int Fst, int Scd)
            {
                int Temp = Table[Fst];
                Table[Fst] = Table[Scd];
                Table[Scd] = Temp;
            }

        }
        public static void B15666()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Condition = Reader.ReadLine().Split(" ");
            int All = int.Parse(Condition[0]); int Peak = int.Parse(Condition[1]);
            string[] Inputs = Reader.ReadLine().Split(" ");
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            List<int> List = new List<int>();
            for (int i = 0; i < All; i++)
            {
                int Temp = int.Parse(Inputs[i]);
                if (List.Find(x=>x==Temp) == 0)
                {
                    List.Add(Temp);
                }
            }
            List.Sort();
            int Len = List.Count;
            int[] AnswerTable = new int[Peak];
            Array.Fill(AnswerTable, 1);
            Answering();
            int Index = 0;

            while (true)
            {
                bool Trigger = false; // 되돌아감?
                for (int i = 0; i < Peak; i++)
                {
                    if (AnswerTable[Peak-1-i] == Len)
                    {
                        if (Trigger)
                        { // 돌아가는 도중 또 맥스 만남  한 번 더 
                            continue;
                        }
                        else
                        { // 처음 봤는데 맥스임 = 앞 에 꺼 확인해
                            Trigger = true;
                        }
                    }
                    else
                    {
                        if (Trigger)
                        { // 돌아가는 도중 맥스 아닌 거 만남
                            AnswerTable[Peak - 1 - i]++;
                            for (int j = Peak - i; j < Peak; j++)
                            {
                                AnswerTable[j] = AnswerTable[Peak - 1 - i];
                            }
                            Answering();
                        }
                        else
                        { // 평범한 맨 끝 + 1;
                            AnswerTable[Peak-1-i]++;
                            Answering();
                        }
                        break;
                    }

                }
                if (AnswerTable[0] == Len)
                {
                    break;
                }
            }
            Console.WriteLine(SB.ToString());
            void Answering()
            {
                for (int i = 0; i < Peak; i++)
                {
                    SB.Append(List[AnswerTable[i] - 1].ToString());
                    if (i != Peak - 1) SB.Append(" ");
                }
                SB.AppendLine("");
            }
    
        }
        public static void B20221222_A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string Inpt = Reader.ReadLine();
            char Fst = Inpt[0];
            int Len = Inpt.Length; int Count = 0;
            for (int i = 0; i < Len; i++)
            {
                if (Inpt[i] == Fst)
                {
                    Count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Count);
        }
        public static void B20221222_B()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            long Money = long.Parse(Reader.ReadLine());
            string[] Condition = Reader.ReadLine().Split(" ");
            long AValue = long.Parse(Condition[0]); long APrice = long.Parse(Condition[1]);
            long BValue = long.Parse(Condition[2]); long BPrice = long.Parse(Condition[3]);
            long Max = 0; bool SwapTrigger = false;
            long ACount = 0; long BCount = 0;
            if(APrice > BPrice)
            {
                SwapTrigger = true; //얘네 바꿈 
                long PriceTemp = APrice;
                APrice = BPrice;
                BPrice = PriceTemp;
                long ValueTemp = AValue;
                AValue = BValue;
                BValue = ValueTemp;
            }//무조건 B가 더 큼
            long BigIndex = Money / BPrice;
            for (int i = 0; i <= BigIndex; i++)
            {
                long Gap = Money - BPrice * i;
                long SmallCount = Gap / APrice;
                long TempValue = i * BValue + SmallCount * AValue;
                if(TempValue > Max)
                {
                    Max = TempValue;
                    ACount = SmallCount; BCount = i;
                }
            }
            if (SwapTrigger)
            {
                Console.Write(BCount);
                Console.Write(" ");
                Console.Write(ACount);
                Console.WriteLine("");
            }
            else
            {
                Console.Write(ACount);
                Console.Write(" ");
                Console.Write(BCount);
                Console.WriteLine("");
            }
            


        }
        public static void B20221222_C()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine()); Dictionary<string, int> Dict = new Dictionary<string, int>(); 
            
            for (int i = 0; i < Case; i++)
            {
                string[] Inpt = Reader.ReadLine().Split(" ");
                if (Dict.TryGetValue(Inpt[0],out int value))
                {
                    Dict[Inpt[0]] += int.Parse(Inpt[1]);
                }
                else
                {
                    Dict.Add(Inpt[0], int.Parse(Inpt[1]));
                }
            }
            List<int> List = Dict.Values.ToList();
            int Len = List.Count; List.Sort();
            int[] Table = List.ToArray();
            bool Trigger = false;
            for (int i = 0; i < Len - 1; i++)
            {
                int Temp = Table[i];
                int FindTemp = (int)((double)Temp * 1.618);
                for (int j = i+1; j < Len; j++)
                {
                    if (Table[j] == FindTemp)
                    {
                        Trigger = true;
                        break;
                    }
                }
                if (Trigger)
                {
                    break;
                }
            }
            if (Trigger)
            {
                Console.WriteLine("Delicious!");
            }
            else
            {
                Console.WriteLine("Not Delicious...");
            }

        }
        public static void B20221222_D()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int AnswerTrigger = 0; // 0 hmm 1 i got it 2 paradox
            long Max = 1000000000000000000; long Min = -1000000000000000000;
            int Phase = 0;
            for (int i = 0; i < Case; i++)
            {
                string[] Inpt = Reader.ReadLine().Split();
                long Value = long.Parse(Inpt[0]);
                if(AnswerTrigger == 0)
                {
                    if (Inpt[1] == "^")
                    {
                        Min = Math.Max(Value + 1, Min);
                    }
                    else
                    {
                        Max = Math.Min(Value - 1,Max);
                    }
                    if (Max == Min)
                    {
                        AnswerTrigger = 1;
                        Phase = i + 1;
                    }
                    else if (Max < Min)
                    {
                        AnswerTrigger = 2;
                        Phase = i + 1;
                    }
                }

            }
            if(AnswerTrigger == 0)
            {
                Console.WriteLine("Hmm...");
            }
            else if (AnswerTrigger == 1)
            {
                Console.WriteLine("I got it!");
                Console.WriteLine(Phase);
            }
            else
            {
                Console.WriteLine("Paradox!");
                Console.WriteLine(Phase);

            }
        }
        public static void B20221222_E()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            int Case = int.Parse(Condition[0]); int Len = int.Parse(Condition[1]);
            string[] Table = new string[Case];
            bool[,] MarkTable = new bool[Case, Len]; bool BaboTrigger = false;
            for (int i = 0; i < Case; i++)
            {
                Table[i] = Reader.ReadLine();
            }
            int Index = 0; int WidthIndex = 0; int HeightIndex = 0;
            for (int i = 0; i < Case; i++)
            {
                for (int j = 0; j < Len; j++)
                {
                    if (MarkTable[i,j] == true)
                    {
                        continue;
                    }
                    WidthIndex = 0; HeightIndex = 0;
                    char Original = Table[i][j];
                    for (int k = j+1; k < Len; k++)
                    {
                        if (Table[i][k] == Original)
                        {
                            if (MarkTable[i,k] == true)
                            {
                                BaboTrigger = true;
                                break;
                            }
                            else
                            {
                                WidthIndex += 1;
                                MarkTable[i, k] = true;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    bool SameTrigger = true;
                    if (!BaboTrigger)
                    {

                        for (int k = i + 1; k < Case; k++)
                        {
                            for (int l = j; l <= j + WidthIndex; l++)
                            {
                                if (Table[k][l] == Original)
                                {
                                    if (SameTrigger)
                                    {
                                        MarkTable[k, l] = true;
                                    }
                                    else
                                    {
                                        BaboTrigger = true;
                                    }
                                }
                                else
                                {
                                    if (WidthIndex == 0)
                                    {
                                        SameTrigger = false;
                                    }
                                    else
                                    {
                                        if (SameTrigger)
                                        {
                                            if (l == j + WidthIndex)
                                            {
                                                BaboTrigger = true;
                                            }
                                        }
                                        SameTrigger = false;
                                    }

                                }
                            }
                            if (BaboTrigger)
                            {
                                break;
                            }
                            else
                            {
                                if (SameTrigger)
                                {
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (BaboTrigger) break;
                }
                if (BaboTrigger) break;
            }
            if (BaboTrigger)
            {
                Console.WriteLine("BaboBabo");
            }
            else
            {
                Console.WriteLine("dd");
            }
        }
        public  static void B1149()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int[,] Table = new int[Case, 3];
            for (int c = 0; c < Case; c++)
            {
                string[] Inpts = Reader.ReadLine().Split(" ");
                Table[c,0] = int.Parse(Inpts[0]); Table[c,1] = int.Parse(Inpts[1]); Table[c,2] = int.Parse(Inpts[2]);
            }
            for (int i = 1; i < Case; i++)
            {
                Table[i, 0] += Math.Min(Table[i - 1, 1], Table[i - 1, 2]);
                Table[i, 1] += Math.Min(Table[i - 1, 0], Table[i - 1, 2]);
                Table[i, 2] += Math.Min(Table[i - 1, 0], Table[i - 1, 1]);
            }
            int[] TempTable = new int[3] { Table[Case - 1, 0], Table[Case - 1, 1], Table[Case - 1, 2] };
            Console.WriteLine(TempTable.Min());

        }
        public static void B1629()
        {
            string[] Condition = Console.ReadLine().Split(" ");
            BigInteger Divid = int.Parse(Condition[2]);
            BigInteger Fst = int.Parse(Condition[0]) % Divid;
            BigInteger Scd = int.Parse(Condition[1]);
            BigInteger Answer = Bunhal(Scd);
            Console.WriteLine(Answer);
            BigInteger Bunhal(BigInteger Input)
            {
                if (Input == 1)
                {
                    return Fst;
                }
                BigInteger HalfInpt = Bunhal(Input / 2) % Divid;
                if (Input % 2 == 0)
                {
                    return (HalfInpt * HalfInpt) % Divid;
                }
                else
                {
                    return (Fst * HalfInpt * HalfInpt) % Divid;
                }
            }
        }
        public static void B1932()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Size = int.Parse(Reader.ReadLine());
            int[] IndexTable = new int[Size];
            int[] Table = new int[Size * (Size + 1) / 2];
            for (int i = 0; i < Size - 1; i++)
            {
                IndexTable[i+1] = (i + 1) * (i + 2) / 2;
            }
            Table[0] = int.Parse(Reader.ReadLine());
            int Max = Table[0]; int PreviousIndex = 0;
            for (int i = 1; i < Size; i++)
            {
                int FirstIndex = IndexTable[i];
                string[] Inputs = Reader.ReadLine().Split(" ");
                for (int j = 0; j < 1+i; j++)
                {
                    int Fst = Math.Max(0, j - 1);
                    int Scd = Math.Min(j,i-1);
                    Table[FirstIndex + j] = Math.Max(Table[PreviousIndex + Fst],Table[PreviousIndex+Scd])+int.Parse(Inputs[j]);
                    Max = Math.Max(Max, Table[FirstIndex+j]);
                }
                PreviousIndex = FirstIndex;
            }
            Console.WriteLine(Max);
        }
        public static void B1991()
        {

        }
        public static void B20221223_A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Start = int.Parse(Reader.ReadLine());
            if (Start < 206) Console.WriteLine(1);
            else if (Start < 218) Console.WriteLine(2);
            else if (Start < 229) Console.WriteLine(3);
            else Console.WriteLine(4);
        }
        public static void B20221223_B()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Mounts = int.Parse(Reader.ReadLine());
            string[] StrSides = Reader.ReadLine().Split(" ");
            int[] Sides = new int[Mounts];
            BigInteger[] OverSide = new BigInteger[Mounts];
            BigInteger[] MinTable = new BigInteger[Mounts];
            int Sum = 0;
            OverSide[0] = 0;
            for (int i = 0; i < Mounts; i++)
            {
                Sides[i] = int.Parse(StrSides[i]);

                Sum += Sides[i];
                if (i != 0)
                {
                    OverSide[i] = Sum;
                    Sum += Sides[i];

                }
            }
            int Index = 1;
            while (true)
            {
                BigInteger Min = 2147483635;

                BigInteger WayPoint1 = MinTable[Index - 1];
                BigInteger WayPoint2 = Diagnol(OverSide[Index] - OverSide[Index - 1], Math.Abs(Sides[Index] - Sides[Index - 1]));
                BigInteger OneTime = Diagnol(OverSide[Index] - OverSide[0], Math.Abs(Sides[Index] - Sides[0]));

                if (OneTime > WayPoint2 + WayPoint1)
                {
                    Min = WayPoint1 + WayPoint2;
                }
                else
                {
                    Min = OneTime;
                }
                MinTable[Index] = Min;
                Index++;
                if (MinTable[Mounts - 1] != 0)
                {
                    break;
                }
            }
            Console.WriteLine(MinTable[Mounts - 1]);
            BigInteger Diagnol(BigInteger Fst, BigInteger Scd)
            {
                return (Fst * Fst + Scd * Scd);
            }

        }
        public static void B20221223_C()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            int[] PsyTable = new int[Case]; int[] InfoTable = new int[Case]; int[] MathTable = new int[Case];
            string[] FstTable = Reader.ReadLine().Split(" "); string[] ScdTable = Reader.ReadLine().Split(" "); string[] ThdTable = Reader.ReadLine().Split(" ");
            for (int i = 0; i < Case; i++)
            {
                PsyTable[i] = int.Parse(FstTable[i]); InfoTable[i] = int.Parse(ScdTable[i]); MathTable[i] = int.Parse(ThdTable[i]);
            }
            Array.Sort(PsyTable); Array.Sort(ScdTable); Array.Sort(ThdTable);
            if(Case % 2 == 1)
            {

            }
            else
            {

            }
        }
        public static void B20221223_D()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string Input = Reader.ReadLine();
            string Grampan = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = Input.Length;
            long Answer = 0;
            int MasterIndex = 0;
            for (int i = 0; i < length; i++)
            {
                if (Input[i] == 'A')
                {
                    long Temp = Grampin(i);
                    if(Temp == -1)
                    {
                        i = MasterIndex - 1;
                    }
                    else
                    {
                        Answer += Temp;
                        i = MasterIndex - 1;
                    }
                }
            }
            Console.WriteLine(Answer);
            long Grampin(int Index)
            {
                int ACount = 0;
                int ZCount = 0;
                char Previous = '5';
                int AIndex = 0;
                int ZIndex = 0;
                bool NahTrigger = false;
                while (Index + AIndex < length)
                {
                    if (Input[Index + AIndex] != 'A')
                    {
                        break;
                    }
                    ACount++;
                    AIndex++;
                }
                int StandardIndex = 0;

                for (int i = 1; i <= 24; i++)
                {
                    if(Index+ AIndex+StandardIndex >= length)
                    {
                        NahTrigger = true;
                        break;
                    }
                    if (Input[Index+AIndex+StandardIndex] != Grampan[i])
                    {
                        if(Input[Index + AIndex + StandardIndex] == Previous)
                        {
                            i--;
                            StandardIndex++;
                            continue;
                        }
                        else
                        {
                            if (i == 24 && Input[Index + AIndex + StandardIndex] == 'Z') 
                            {
                                break;
                            }
                            NahTrigger = true;
                            break;
                        }
                    }
                    else
                    {
                        Previous = Grampan[i];
                        StandardIndex++;
                        if(i == 24)
                        {
                            i--;
                        }
                    }
                }
                if (NahTrigger)
                {
                    MasterIndex = Index + StandardIndex + AIndex + ZIndex;
                    return -1;
                }
                while (Index + StandardIndex + AIndex+ ZIndex < length)
                {
                    if (Input[Index + AIndex + StandardIndex+ZIndex] != 'Z')
                    {
                        break;
                    }
                    ZCount++;
                    ZIndex++;
                }
                if(ZCount == 0)
                {
                    MasterIndex = Index + StandardIndex + AIndex + ZIndex;
                    return -1;
                }
                MasterIndex = Index + StandardIndex + AIndex + ZIndex;
                return ZCount * ACount;


            }
        }           
        public static void B20221224_0()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
        }
        public static void B20221224_A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            long Domain = long.Parse(Reader.ReadLine());
            string[] Condition = Reader.ReadLine().Split(" ");
            long Fst = long.Parse(Condition[0]) * Domain + long.Parse(Condition[1]);
            long Scd = long.Parse(Condition[2]) * Domain + long.Parse(Condition[3]);
            if(Fst == Scd)
            {
                Console.Write("Yes ");
                Console.Write(Scd);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        public static void B20221224_B()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            string[] Condition = Reader.ReadLine().Split(" ");
            double B = double.Parse(Condition[0]);
            double C = double.Parse(Condition[1]);
            double Temp = B + Math.Sqrt(B * B + 4 * C);
            string STR = string.Format("{0:0.0000000#}", Temp / 2);
            Console.WriteLine(STR);
        }
        public static void B20221224_G()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();

            double temp = 0.2156;
            double Min = 0.5 - temp;
            double Max = 0.5 + temp;
            for (int i = 0; i < 100; i++)
            {
                int Trigger = 0; //1은 균등분포 2는 정규분포

                for (int j = 0; j < 5000; j++)
                {
                    double Inpt = double.Parse(Reader.ReadLine());
                    if (Trigger == 0)
                    {
                        if (Inpt < Max && Inpt > Min)
                        {
                            Trigger = 1;
                        }
                        if (Inpt > 1 || Inpt < 0)
                        {
                            Trigger = 2;
                        }
                    }

                }
                if (Trigger == 1)
                {
                    SB.AppendLine("A");
                }
                else
                {
                    SB.AppendLine("B");
                }
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B1911()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            bool[] MarkedTable = new bool[Case];
            for (int i = 0; i < Case; i++)
            {
                string[] Inpt = Reader.ReadLine().Split();
                string TRoot = Inpt[0];
                if (Inpt[1] == ".")
                {
                    if (Inpt[2] == ".")
                    {
                    }
                    else
                    {
                        Dict.Add(TRoot, "0" + Inpt[2]);
                    }
                }
                else
                {
                    if (Inpt[2] == ".")
                    {
                        Dict.Add(TRoot, Inpt[1]);
                    }
                    else
                    {
                        Dict.Add(TRoot, Inpt[1] + Inpt[2]);
                    }
                }

            }

            Stack<string> Stacks = new Stack<string>();
            Stacks.Push("A"); PreOrderTraverse(); SB.AppendLine(""); Stacks.Clear();
            Stacks.Push("A"); InOrderTraverse(); SB.AppendLine(""); Stacks.Clear(); Array.Fill(MarkedTable, false);
            Stacks.Push("A"); PostOrderTraverse(); SB.AppendLine("");

            Console.WriteLine(SB.ToString());
            void PreOrderTraverse()
            {

                if (Stacks.Count == 0)
                {
                    return;
                }
                string Temp = Stacks.Pop();
                SB.Append(Temp);
                if (Dict.TryGetValue(Temp, out string asdf))
                {
                    string Temp2 = Dict[Temp];
                    if (Temp2[0] == '0')
                    {
                        Stacks.Push(Temp2[1].ToString());
                    }
                    else
                    {
                        if (Temp2.Length == 1)
                        {
                            Stacks.Push(Temp2);
                        }
                        else
                        {
                            Stacks.Push(Temp2[1].ToString());
                            Stacks.Push(Temp2[0].ToString());

                        }
                    }
                }
                PreOrderTraverse();
            }
            void InOrderTraverse()
            {
                if (Stacks.Count == 0)
                {
                    return;
                }
                string Temp = Stacks.Pop();
                int Index = Temp.ToCharArray()[0] - 'A';
                if (Dict.TryGetValue(Temp, out string asdf))
                {
                    string Temp2 = Dict[Temp];
                    if (Temp2[0] == '0')
                    {
                        SB.Append(Temp);
                        MarkedTable[Index] = true;
                        Stacks.Push(Temp2[1].ToString());
                    }
                    else
                    {
                        if (Temp2.Length == 1)
                        {
                            int Temp2Index = Temp2.ToCharArray()[0] - 'A';
                            if (MarkedTable[Temp2Index])
                            {
                                SB.Append(Temp);
                                MarkedTable[Index] = true;
                            }
                            else
                            {
                                Stacks.Push(Temp);
                                Stacks.Push(Temp2);
                            }
                        }
                        else
                        {
                            int LeftIndex = Temp2[0] - 'A';
                            if (MarkedTable[LeftIndex])
                            {
                                SB.Append(Temp);
                                MarkedTable[Index] = true;
                            }
                            else
                            {
                                Stacks.Push(Temp2[1].ToString());
                                Stacks.Push(Temp);
                                Stacks.Push(Temp2[0].ToString());
                            }
                        }
                    }
                }
                else
                {
                    SB.Append(Temp);
                    MarkedTable[Index] = true;
                }

                InOrderTraverse();
            }
            void PostOrderTraverse()
            {
                if (Stacks.Count == 0)
                {
                    return;
                }
                string Temp = Stacks.Pop();
                int Index = Temp.ToCharArray()[0] - 'A';
                if (Dict.TryGetValue(Temp, out string asdf))
                {
                    string Temp2 = Dict[Temp];
                    if (Temp2[0] == '0')
                    {
                        int RightIndex = Temp2[1] - 'A';
                        if (MarkedTable[RightIndex])
                        {
                            SB.Append(Temp);
                            MarkedTable[Index] = true;
                        }
                        else
                        {
                            Stacks.Push(Temp);
                            Stacks.Push(Temp2[1].ToString());
                        }
                    }
                    else
                    {
                        if (Temp2.Length == 1)
                        {
                            int Temp2Index = Temp2.ToCharArray()[0] - 'A';
                            if (MarkedTable[Temp2Index])
                            {
                                SB.Append(Temp);
                                MarkedTable[Index] = true;
                            }
                            else
                            {
                                Stacks.Push(Temp);
                                Stacks.Push(Temp2);
                            }
                        }
                        else
                        {
                            int LeftIndex = Temp2[0] - 'A';
                            if (MarkedTable[LeftIndex])
                            {
                                SB.Append(Temp);
                                MarkedTable[Index] = true;
                            }
                            else
                            {
                                Stacks.Push(Temp);
                                Stacks.Push(Temp2[1].ToString());
                                Stacks.Push(Temp2[0].ToString());
                            }
                        }
                    }
                }
                else
                {
                    SB.Append(Temp);
                    MarkedTable[Index] = true;
                }
                PostOrderTraverse();
            }
        }
        public static void B9465()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            for (int i = 0; i < Case; i++)
            {
                int Sides = int.Parse(Reader.ReadLine());
                if (Sides == 1)
                {
                    int Fst = int.Parse(Reader.ReadLine());
                    int Scd = int.Parse(Reader.ReadLine());
                    SB.AppendLine(Math.Max(Fst, Scd).ToString());
                }
                else
                {
                    int[,] Table = new int[Sides, 2];
                    for (int j = 0; j < 2; j++)
                    {
                        string[] Inpts = Reader.ReadLine().Split(" ");
                        for (int k = 0; k < Sides; k++)
                        {
                            Table[k, j] = int.Parse(Inpts[k]);
                        }
                    }
                    int[,] AnswerTable = new int[Sides, 2];
                    int Max = 0; AnswerTable[0, 0] = Table[0, 0]; AnswerTable[0, 1] = Table[0, 1]; AnswerTable[1, 0] = Table[1, 0]; AnswerTable[1, 1] = Table[1, 1];
                    int Index = 0;
                    while (Index < Sides - 2)
                    {
                        AnswerTable[Index + 1, 0] = Math.Max(AnswerTable[Index, 1] + Table[Index + 1, 0], AnswerTable[Index + 1, 0]);
                        AnswerTable[Index + 1, 1] = Math.Max(AnswerTable[Index, 0] + Table[Index + 1, 1], AnswerTable[Index + 1, 1]);
                        AnswerTable[Index + 2, 0] = Math.Max(AnswerTable[Index, 1] + Table[Index + 2, 0], AnswerTable[Index + 2, 0]);
                        AnswerTable[Index + 2, 1] = Math.Max(AnswerTable[Index, 0] + Table[Index + 2, 1], AnswerTable[Index + 2, 1]);
                        Index++;
                    }
                    AnswerTable[Index + 1, 0] = Math.Max(AnswerTable[Index, 1] + Table[Index + 1, 0], AnswerTable[Index + 1, 0]);
                    AnswerTable[Index + 1, 1] = Math.Max(AnswerTable[Index, 0] + Table[Index + 1, 1], AnswerTable[Index + 1, 1]);
                    SB.AppendLine(Math.Max(AnswerTable[Index + 1, 0], AnswerTable[Index + 1, 1]).ToString());
                }

            }
            Console.WriteLine(SB.ToString());
        }
        public static void B11660()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            string[] Condition = Reader.ReadLine().Split();
            int Side = int.Parse(Condition[0]); int Case = int.Parse(Condition[1]);
            int[][] InputTable = new int[Side][];
            int[,] WidthPrefixTable = new int[Side, Side]; int[,] HeightPrefixTable = new int[Side, Side];
            InputTable[0] = Array.ConvertAll(Reader.ReadLine().Split(" "), int.Parse);
            WidthPrefixTable[0, 0] = InputTable[0][0];
            HeightPrefixTable[0, 0] = InputTable[0][0];
            for (int j = 1; j < Side; j++)
            {
                WidthPrefixTable[0, j] = WidthPrefixTable[0, j - 1] + InputTable[0][j];
                HeightPrefixTable[0, j] = InputTable[0][j];
            }
            for (int i = 1; i < Side; i++)
            {
                InputTable[i] = Array.ConvertAll(Reader.ReadLine().Split(" "), int.Parse);
                WidthPrefixTable[i, 0] = InputTable[i][0];
                HeightPrefixTable[i, 0] = InputTable[i][0] + HeightPrefixTable[i - 1, 0];
                for (int j = 1; j < Side; j++)
                {
                    WidthPrefixTable[i, j] = WidthPrefixTable[i, j - 1] + InputTable[i][j];
                    HeightPrefixTable[i, j] = HeightPrefixTable[i - 1, j] + InputTable[i][j];
                }
            }
            for (int i = 0; i < Case; i++)
            {
                int[] Inputs = Array.ConvertAll(Reader.ReadLine().Split(" "), int.Parse);
                int Height = Inputs[2] - Inputs[0]; int Width = Inputs[3] - Inputs[1];
                if (Height > Width)
                {
                    int StartHeight = Inputs[0] - 1; int EndHeight = Inputs[2] - 1;
                    int Start = Inputs[1] - 1; int End = Inputs[3] - 1;
                    long Sum = 0;
                    if (StartHeight == 0)
                    {
                        for (int j = Start; j <= End; j++)
                        {
                            Sum += HeightPrefixTable[EndHeight, j];
                        }
                    }
                    else
                    {
                        for (int j = Start; j <= End; j++)
                        {
                            Sum += HeightPrefixTable[EndHeight, j] - HeightPrefixTable[StartHeight - 1, j];
                        }
                    }
                    SB.AppendLine(Sum.ToString());
                }
                else
                {
                    int StartWidth = Inputs[1] - 1; int EndWidth = Inputs[3] - 1;
                    int Start = Inputs[0] - 1; int End = Inputs[2] - 1;
                    long Sum = 0;
                    if (StartWidth == 0)
                    {
                        for (int j = Start; j <= End; j++)
                        {
                            Sum += WidthPrefixTable[j, EndWidth];
                        }
                    }
                    else
                    {
                        for (int j = Start; j <= End; j++)
                        {
                            Sum += WidthPrefixTable[j, EndWidth] - WidthPrefixTable[j, StartWidth - 1];
                        }
                    }
                    SB.AppendLine(Sum.ToString());
                }
            }
            Console.WriteLine(SB.ToString());

        }

        public static void B20221230_A()
        {
            int Input = int.Parse(Console.ReadLine());
            int[] Special = new int[] { 6, 15, 35, 77, 143, 221, 323, 437, 667, 899, 1147, 1517, 1763, 2021, 2491, 3127, 3599, 4087, 4757, 5183, 5767, 6557, 7387, 8633, 9797, 10403 };
            int Len = Special.Length;
            for (int i = 0; i < Len; i++)
            {
                if (Input < Special[i])
                {
                    Console.WriteLine(Special[i]);
                    break;
                }
            }
        }
        public static void B20221231_A()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            StringBuilder SB = new StringBuilder();
            int Case = int.Parse(Reader.ReadLine());
            if (true)
            {
                /*
      bool[] Table = new bool[5001];
      bool[] AnswerTable = new bool[5001];
      for (int i = 2; i <= 5000; i++)
      {
          if (Table[i])
          {
              continue;
          }
          int Temp = i - 1;
          int Sum = 0;
          while(Temp >= 1)
          {
              if(i % Temp == 0)
              {
                  Sum += Temp;
              }
              Temp--;
          }
          if(Sum > i)
          {
              for (int j = i; j <= 5000; j += i)
              {
                  Table[j] = true;
              }
              AnswerTable[i] = true;
              SB.AppendLine(i.ToString());
          }
      }
      */
            }
            //List<int> Table = new List<int>() { 12, 18, 20, 30, 42, 56, 66, 70, 78, 88, 102, 104, 114, 138, 174, 186, 196, 222, 246, 258, 272, 282, 304, 308, 318, 354, 364, 366, 368, 402, 426, 438, 464, 474, 476, 498, 532, 534, 550, 572, 582, 606, 618, 642, 644, 650, 654, 678, 748, 762, 786, 812, 822, 834, 836, 868, 894, 906, 942, 945, 978, 992, 1002, 1036, 1038, 1074, 1086, 1146, 1148, 1158, 1182, 1184, 1194, 1204, 1266, 1312, 1316, 1338, 1362, 1374, 1376, 1398, 1430, 1434, 1446, 1484, 1504, 1506, 1542, 1575, 1578, 1614, 1626, 1652, 1662, 1686, 1696, 1698, 1708, 1758, 1842, 1866, 1870, 1876, 1878, 1888, 1902, 1952, 1986, 1988, 2002, 2022, 2044, 2082, 2090, 2094, 2118, 2154, 2202, 2205, 2210, 2212, 2238, 2274, 2298, 2324, 2334, 2382, 2406, 2454, 2470, 2492, 2514, 2526, 2530, 2584, 2586, 2598, 2634, 2658, 2694, 2716, 2742, 2766, 2778, 2802, 2828, 2874, 2884, 2922, 2946, 2990, 2994, 2996, 3018, 3052, 3054, 3126, 3128, 3138, 3164, 3190, 3230, 3246, 3282, 3342, 3378, 3410, 3414, 3426, 3462, 3465, 3496, 3522, 3556, 3558, 3594, 3606, 3642, 3668, 3678, 3702, 3714, 3770, 3786, 3836, 3846, 3858, 3882, 3892, 3918, 3944, 3954, 3966, 4030, 4038, 4062, 4070, 4095, 4098, 4146, 4172, 4206, 4216, 4228, 4254, 4288, 4314, 4362, 4396, 4398, 4408, 4434, 4458, 4506, 4510, 4542, 4544, 4564, 4566, 4614, 4638, 4672, 4676, 4712, 4722, 4730, 4782, 4844, 4854, 4866, 4926, 4938, 4962, 4974 };
            for (int i = 0; i < Case; i++)
            {
                int Input = int.Parse(Reader.ReadLine());
                SB.AppendLine("BOJ 2022");
                 SB.AppendLine("Good Bye");
            }
            Console.WriteLine(SB.ToString());
        }
        public static void B20221231_B()
        {
            using var Reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int Case = int.Parse(Reader.ReadLine());
            double[] Table = Array.ConvertAll(Reader.ReadLine().Split(" "), double.Parse);
            Array.Sort(Table);
            double Max = 0;
            int Index = 0;
            while(Index <= Case-1)
            {
                int Count = Case - Index;
                int MidIndex = (Count + 1) / 2 - 1;
                Max = Math.Max(Max, Table[Index + MidIndex]);
                if(Index == Case - 1)
                {
                    break;
                }
                else
                {
                    Table[Index + 1] = ((Index + 1) * Table[Index] + Table[Index+1]) / (Index + 2);
                }
                Index++;
            }
            string Answer = string.Format("{0:0.0000000}", Max);
            Console.WriteLine(Answer);
        }
        public static void B20221231_C()
        {

        }
        public class B1107_C
        {
            public List<int> Table = new List<int>();
            public int[] AllowButtons;
            public int Len;
            public int Error;
            public int Goal;
            public int Count;
            public int Min;

            public int Press0()
            {
                return Goal + 1;
            }
            public int Press1()
            {
                Min = 5000000;
                for (int a = 0; a < Len; a++)
                {
                    int A = AllowButtons[a];
                    int Teleport = A;
                    int Gap = Math.Abs(Goal - Teleport);
                    if (Gap < Min)
                    {
                        Min = Gap;
                    }
                }
                return Min + 1;
            }
            public int Press2()
            {
                Min = 5000000;
                for (int b = 0; b < Len; b++)
                {
                    int B = AllowButtons[b];
                    for (int a = 0; a < Len; a++)
                    {
                        int A = AllowButtons[a];
                        int Teleport = B * 10 + A;
                        int Gap = Math.Abs(Goal - Teleport);
                        if (Gap < Min)
                        {
                            Min = Gap;
                        }
                    }
                }

                return Min + 2;
            }
            public int Press3()
            {
                Min = 5000000;
                for (int c = 0; c < Len; c++)
                {
                    int C = AllowButtons[c];
                    for (int b = 0; b < Len; b++)
                    {
                        int B = AllowButtons[b];
                        for (int a = 0; a < Len; a++)
                        {
                            int A = AllowButtons[a];
                            int Teleport = C * 100 + B * 10 + A;
                            int Gap = Math.Abs(Goal - Teleport);
                            if (Gap < Min)
                            {
                                Min = Gap;
                            }
                        }
                    }
                }

                return Min + 3;
            }
            public int Press4()
            {
                Min = 5000000;
                for (int d = 0; d < Len; d++)
                {
                    int D = AllowButtons[d];
                    for (int c = 0; c < Len; c++)
                    {
                        int C = AllowButtons[c];
                        for (int b = 0; b < Len; b++)
                        {
                            int B = AllowButtons[b];
                            for (int a = 0; a < Len; a++)
                            {
                                int A = AllowButtons[a];
                                int Teleport = D * 1000 + C * 100 + B * 10 + A;
                                int Gap = Math.Abs(Goal - Teleport);
                                if (Gap < Min)
                                {
                                    Min = Gap;
                                }
                            }
                        }
                    }
                }

                return Min + 4;
            }
            public int Press5()
            {
                Min = 5000000;
                for (int e = 0; e < Len; e++)
                {
                    int E = AllowButtons[e];
                    for (int d = 0; d < Len; d++)
                    {
                        int D = AllowButtons[d];
                        for (int c = 0; c < Len; c++)
                        {
                            int C = AllowButtons[c];
                            for (int b = 0; b < Len; b++)
                            {
                                int B = AllowButtons[b];
                                for (int a = 0; a < Len; a++)
                                {
                                    int A = AllowButtons[a];
                                    int Teleport = E * 10000 + D * 1000 + C * 100 + B * 10 + A;
                                    int Gap = Math.Abs(Goal - Teleport);
                                    if (Gap < Min)
                                    {
                                        Min = Gap;
                                    }
                                }
                            }
                        }
                    }
                }

                return Min + 5;
            }
            public int Press6()
            {
                Min = 5000000;
                for (int f = 0; f < Len; f++)
                {
                    int F = AllowButtons[f];
                    for (int e = 0; e < Len; e++)
                    {
                        int E = AllowButtons[e];
                        for (int d = 0; d < Len; d++)
                        {
                            int D = AllowButtons[d];
                            for (int c = 0; c < Len; c++)
                            {
                                int C = AllowButtons[c];
                                for (int b = 0; b < Len; b++)
                                {
                                    int B = AllowButtons[b];
                                    for (int a = 0; a < Len; a++)
                                    {
                                        int A = AllowButtons[a];
                                        int Teleport = F * 100000 + E * 10000 + D * 1000 + C * 100 + B * 10 + A;
                                        int Gap = Math.Abs(Goal - Teleport);
                                        if (Gap < Min)
                                        {
                                            Min = Gap;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return Min + 6;
            }

        }
        public class B9019_C
        {
            public static int B9019_D(int Inpt)
            {
                return (Inpt * 2) % 10000;
            }
            public static int B9019_S(int Inpt)
            {
                if (Inpt == 0)
                {
                    return 9999;
                }
                return Inpt - 1;
            }
            public static int B9019_L(int Inpt)
            {
                int Fst = Inpt / 1000;
                int New = Inpt * 10 % 10000;
                return Fst + New;
            }
            public static int B9019_R(int Inpt)
            {
                int Lst = Inpt % 10;
                int New = Inpt / 10;
                return Lst * 1000 + New;
            }
        }
    }
}


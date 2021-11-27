using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static public int[] matrix;
        static void Main(string[] args)
        {

            //    int variablesCount = 2;
            //    int ei = variablesCount - 1;
            //    //matrix=new int[3];
            //    string str = "";
            //    for (int i = 0; i < variablesCount; i++)
            //    {
            //        str += "0";
            //    }
            //    string end = str.Replace('0', '1');
            //    //matrix = ToArr(str);
            //    string res = str;
            //    while (str!=end)
            //    {
            //        if (str.EndsWith("1"))
            //        {
            //            for (int i = ei; i >= 0; i--)
            //            {
            //                if (str[i]=='1')
            //                {
            //                    StringBuilder somestring = new StringBuilder(str);
            //                    somestring[i] = '0';
            //                    str = somestring.ToString();
            //                }
            //                else
            //                {
            //                    StringBuilder somestring = new StringBuilder(str);
            //                    somestring[i] = '1';
            //                    str = somestring.ToString();
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            StringBuilder somestring = new StringBuilder(str);
            //            somestring[ei] = '1';
            //            str = somestring.ToString();
            //        }
            //        res += str;
            //        //matrix = ToList(str);
            //    }
            //    for (int i = 0; i < res.Length; i++)
            //    {
            //        Console.Write(res[i]);
            //    }
            //    int[,] matrix;
            //}

            //private static int[] ToArr(string str)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        matrix[i]
            //    }
            //}
            
            
                var A = new int[,] { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
                Print(A);
                var t = Trans(A);
                Print(t);
            

        }
        static T[,] Trans<T>(T[,] array)
        {
            T[,] result = new T[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[j, i] = array[i, j];
                }
            }
            return result;
        }
        static void Print<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

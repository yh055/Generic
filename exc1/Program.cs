using System;
using System.Collections.Generic;
namespace exc1
{
    class SwapList<T> : List<T>
    {
        public void swap(int i,int j)
        {
            T k = this[i];
            this[i] = this[j];
            this[j] = k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            PrintTheObj(x);
            SwapList<int> arr = new SwapList<int>() { 5, 6, 7 };
            arr.swap(0, 1);
            PrintTheObj(arr);
            PrintTheObj(arr);
        }
        static void PrintTheObj<T>(T obj)
        {
            Console.WriteLine(obj);
            Console.Read();
        }
    }
}

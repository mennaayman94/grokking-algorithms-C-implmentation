using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program();
            //int[] arr = {1, 2, 3, 4,5,6};
            int[] arr2 = { 44, 22, 89,100, 31 };
           //BinarySeach.BinarySearch(arr, 3);
           var arr= SelectionSort.SelectionSortAlgo(arr2);
            p.printArrays(arr);
            Console.WriteLine(p.FindFactorialOfNum(3) + "Factorial");
            p.printFibonacciSeries1(10);
        }
        public int FindFactorialOfNum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num* FindFactorialOfNum(num - 1);
            }
        }
        public void printFibonacciSeries1(int numberOfseries)
        {
            int val1 = 0;
            int val2 = 1;
            int val3;
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            for (int i=2; i<numberOfseries; i++)
            {
                val3 = val1 + val2;
                Console.WriteLine(val3);
                val1 = val2;
                val2 = val3;
            }
        }
       public void printArrays(int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+"sorted");
            }
        }
        
    }
    

    
    
}

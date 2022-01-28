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

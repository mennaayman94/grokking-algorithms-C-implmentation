using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public static  class SelectionSort
    {
        public static int[] SelectionSortAlgo(int[] arr)
        {
            int smallestNum;
            int temNum;
            for (var i=0; i<arr.Length; i++)
            {
                smallestNum = i;
                for (var j=i+1; j <arr.Length; j++)
                {
                    if (arr[j] < arr[smallestNum])
                    {
                        smallestNum = j;
                    }
                }
                temNum = arr[smallestNum];
                arr[smallestNum] = arr[i];
                arr[i] = temNum;
            }
            return arr;
        }   
    }
}

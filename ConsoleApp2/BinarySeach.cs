using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public static  class BinarySeach
    {
        public static int BinarySearch(int[] arr, int num)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (max + min) / 2;
                if (num == arr[mid])
                {
                    Console.WriteLine("number is" + arr[mid]);
                    return mid;
                }
                else if (num < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            Console.WriteLine("Number Not found");
            return 0;
        }
    }
}

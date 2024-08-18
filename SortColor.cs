using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int[] arr = {2,0,2,1,1,0};
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;
            while (mid <= high) {
            {
                if (arr[mid] == 0)
                {
                    int temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    mid++;
                    low++;
                }
                else if (arr[mid]==2)
                    { 
                    int temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
                else
                {
                    mid++;
                }

                }
            }
            foreach(int x in arr)
            {
                Console.WriteLine(x);

            }
            Console.ReadLine();
        }
      

    }
}

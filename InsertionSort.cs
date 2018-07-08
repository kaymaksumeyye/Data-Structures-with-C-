using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 33, 44, 21, 83, 56, 18 };
            dizi = InsertionSort(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static int [] InsertionSort(int [] dizi)
        {
            int temp;
            for(int i = 1; i < dizi.Length; i++)
            {
                for(int j=i; j > 0; j--)

                {
                    if (dizi[j-1] > dizi[j])
                    {
                        temp = dizi[j-1]; 
                        dizi[j-1] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi;
        }
    }
}

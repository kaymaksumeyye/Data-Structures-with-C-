using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 3, 2, 5, 1, 8 };
            int [] sirali= BubbleSort(dizi);

            foreach (var item in sirali)
            {
                Console.WriteLine(item);
            }
        }
        static int [] BubbleSort(int[] dizi)
        {
            int temp;
            for (int j = 0; j < dizi.Length; j++)
            {
                for (int i = 0; i < dizi.Length - j - 1; i++)
                {
                    if (dizi[i] < dizi[i + 1])
                    {
                        temp = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = temp;
                    }
                }
            }
            return dizi;
        }
    }
}

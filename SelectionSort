using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siralanacak = { 10, 5, 8, 6,  3 };
            int [] sirali = SelectionSort(siralanacak);
            foreach (var item in sirali)
            {
                Console.Write(item + "   ");
            }

        }
        static int [] SelectionSort(int [] siralanacak)
        {
            int enKucuk, degisecekIndis=0, temp;
            for (var j = 0; j < siralanacak.Length-1; j++)
            {
                enKucuk = siralanacak[j];
                degisecekIndis = j;
                for(var i = j + 1; i < siralanacak.Length; i++)
                {
                    if (enKucuk > siralanacak[i])
                    {
                        enKucuk = siralanacak[i];
                        degisecekIndis = i;
                    }
                }
                temp = siralanacak[j];
                siralanacak[j] = enKucuk;
                siralanacak[degisecekIndis] = temp;
            }
            return siralanacak;
        }
    }
}

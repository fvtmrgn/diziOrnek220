using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnek220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin eleman sayısını girin:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] B = new int[n];

    
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dizinin {i + 1}. elemanını girin:");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            int e = 1 , a ;
            for (a = 2; a < B.Length; a++)
            {
                if (Math.Abs(B[0] - B[a]) < Math.Abs(B[0] - B[e])) e = a;
            }

            Console.WriteLine("İlk Sayıya En Yakın Sayı = " + B[e]);
            Console.Write("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}

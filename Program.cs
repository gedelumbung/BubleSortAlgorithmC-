/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 25/06/2011
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace algoritma_buble_sort
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Masukkan banyak elemen array = ");
			int n = Convert.ToInt32(Console.ReadLine());
            int[] array_sort = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemen ke-" + (i + 1) + " = ");
                array_sort[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = 0; k <= n - 2; k++)
                {
                    if (array_sort[k] < array_sort[k + 1])
                    {
                       	int temp = array_sort[k];
                        array_sort[k] = array_sort[k + 1];
                        array_sort[k + 1] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Diurutkan secara Descending");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array_sort[i]);
            }
            Console.ReadLine();
		}
	}
}
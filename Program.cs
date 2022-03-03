using System;
using System.Numerics;
using static System.Math;

namespace acm
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Console.Title = "Ikki nuqta orasidagi masofani N aniqlikgacha chiqarib beradi.";

            Console.Write(" kiritgan soningiz usha aniqlikgacha chiqarib beradi N = ");

            int N= int.Parse(Console.ReadLine());

            Console.WriteLine("Ketma-ket 4 ta sonni kiriting space orqali  x1,y1,x2,y2 !!! ");

            string[] nums = Console.ReadLine().Split();
            
            decimal x1 = decimal.Parse(nums[0]);
            decimal y1 = decimal.Parse(nums[1]);
            decimal x2 = decimal.Parse(nums[2]);
            decimal y2 = decimal.Parse(nums[3]);

            decimal x5 = ((decimal)Sqrt((double) ((x2-x1) * (x2 - x1) + (y2 - y1) * ( y2 - y1 ) )));

             var t=(decimal)x5;


            Console.WriteLine($"Natija va butundan keyingi qiymatga e'tibor bering!!!   => { Math.Round(t, N)}");
        }

    }
}
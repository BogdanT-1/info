using System;

namespace ConsoleApp53
{
    class Program
    {
        public static string bcd(int a)
        {
                       
            switch(a)
            {
                case 0: return "0000"; 
                case 1: return "0001"; 
                case 2: return "0010"; 
                case 3: return "0011"; 
                case 4: return "0100"; 
                case 5: return "0101"; 
                case 6: return "0110"; 
                case 7: return "0111"; 
                case 8: return "1000"; 
                case 9: return "1001"; 


            }
            return 0.ToString();
        }

        static void Main(string[] args)
        {
            int[] v = { 0, 3, 0, 5 };
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            int[] vs = new int[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                vs[i] = 9 - v[i];
            }
            vs[v.Length - 1] += 1;
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(vs[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(bcd(vs[i]) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

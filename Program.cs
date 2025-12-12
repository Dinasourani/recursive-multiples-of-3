using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void MultiplesOf3(int n)
        {

            if (n <= 0)
                return;


            if (n % 3 != 0)
            {
                MultiplesOf3(n - 1);
            }
            else
            {

                MultiplesOf3(n - 3);


                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("عدد N را وارد کنید: ");
            int N = int.Parse(Console.ReadLine());

            MultiplesOf3(N - 1);
            Console.ReadKey();
        }
    }
}

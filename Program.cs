using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_project
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Please enter the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (int x= n1; x<=n2 ;x++)
            {


                int sum = 0;
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                        sum += i;
                }
                if (sum == x)
                    Console.WriteLine(x);




               
            }
            Console.ReadKey();
        }
      
    }
}

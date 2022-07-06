using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Dejalma
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Contador do 1 ao 100 de números pares");

            int num1, num2;

            num1 = 2;
            num2 = 100;

            for (; num1 <= num2; num1 = +2)
            {
                Console.WriteLine(num1++);
            }

            Console.ReadKey();
        }
	}
}

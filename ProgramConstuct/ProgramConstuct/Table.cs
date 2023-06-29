using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstuct
{
   public class Table
   {
        public void tableMethod()
        {
            const int i = 2;
            int p = 1;
            for (p = 1; p <= 10; p++)
            {
                Console.WriteLine($"2 X {p} = {i*p}");
            }
        }

        public void factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter the number to find the factorial ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            if(num == 0)
            {
                Console.WriteLine($"Factorial of {num} is 0");
            }else if(num < 0)
            {
                Console.WriteLine($"Factorial of {num} is not possible");
            }
            else
            {
                while (num != 0)
                {
                    fact = fact * num;
                    num--;
                }
                Console.WriteLine($"Factorial of {temp} is {fact}");
            }    
        }
   }
}

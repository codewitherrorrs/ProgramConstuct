using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstuct
{
    public class Programming
    {
        public void checkEqual()
        {
            Console.WriteLine("Enter the 1st Value : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Value : ");
            int second = int.Parse(Console.ReadLine());
            if(first == second)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Different");
            }
        }

        public void eligibleVote()
        {
            Console.WriteLine("Enter the Age : ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible for Vote");
            }
            else
            {
                Console.WriteLine("You are not Eligible for Vote");
            }
        }

        public void evenOdd()
        {
            Console.WriteLine("Enter the Number to find out even and odd number : ");
            int number = int.Parse(Console.ReadLine());
            if(number == 0)
            {
                Console.WriteLine("Number is not valid");
            }
            else if(number % 2 == 0)
            {
                Console.WriteLine($"It is a even number : {number}");
            }
            else
            {
                Console.WriteLine($"It's not an even number : {number}");
            }
        }
    }
}

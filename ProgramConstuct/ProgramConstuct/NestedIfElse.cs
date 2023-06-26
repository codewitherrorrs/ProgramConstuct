using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstuct
{
    public class NestedIfElse
    {
        public void foodChoice()
        {
            Console.WriteLine("Enter the Choice Press Button  1.Apple 2.Banana 3.Orange");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine($"Your Choice is {choice} and Fruit name is 'Apple'");
            }else if(choice == 2)
            {
                Console.WriteLine($"Your Choice is {choice} and Fruit name is 'Banana'");
            }else if(choice == 3)
            {
                Console.WriteLine($"Your Choice is {choice} and Fruit name is 'Orange'");
            }
            else
            {
                Console.WriteLine("Invalid Choice Entered");
            }
        }
    }
}

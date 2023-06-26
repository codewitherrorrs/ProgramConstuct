using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstuct
{
    public class SwitchCaseDemo
    {
        public void add(int a , int b)
        {
            Console.WriteLine($"The Addition is : {a+b}");
        }

        public void sub(int a, int b)
        {
            Console.WriteLine($"The Subtraction is : {a - b}");
        }

        public void mul(int a, int b)
        {
            Console.WriteLine($"The Multiplication is : {a * b}");
        }

        public void div(int a, int b)
        {
            Console.WriteLine($"The Division is : {a / b}");
        }
    }
}

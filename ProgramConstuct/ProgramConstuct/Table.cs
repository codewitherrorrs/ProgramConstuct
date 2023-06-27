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
   }
}

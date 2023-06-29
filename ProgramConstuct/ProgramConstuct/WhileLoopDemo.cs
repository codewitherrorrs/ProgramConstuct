using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstuct
{
    public class WhileLoopDemo
    {
        public void flipCoin()
        {
            Random random= new Random();
            
            int head , tail ;
            head = tail = 0;
            
           for(int i = 0; i < 20; i++)
            {
                int num = random.Next(2);
                if (num == 0)
                {
                    head++;

                }
                else
                {
                    tail++;
                }
            }
           if(head > tail)
            {
                Console.WriteLine($"Head is the Winner : {head}");
                Console.WriteLine($"Tail is the Loser : {tail}");
            }
            else
            {
                Console.WriteLine($"Tail is the Winner : {tail}");
                Console.WriteLine($"Head is the Loser : {head}");
            }
        }
    }
}

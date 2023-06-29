using ProgramConstuct;

namespace ProgramConstruct
{
    public class Program 
    { 
        public static void Main(string[] args)
        {
            WhileLoopDemo wd = new WhileLoopDemo();
            //wd.flipCoin();
            wd.reverseWord();
            //WeekDay Program
        /*    while (true)
            {
                Console.WriteLine("Enter the week number to get Day ");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Today is Monday");
                        break;
                    case 2:
                        Console.WriteLine("Today is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Today is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Today is Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Today is Friday");
                        break;
                    case 6:
                        Console.WriteLine("Today is Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Today is Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid Input Please Place Number Between 1 to 7 to get Day Name");
                        break;
                }
            } */

            //Table tb = new Table();
            //tb.tableMethod();
            //tb.factorial();

            //Programming p1 = new Programming();
           // p1.checkEqual();
           // p1.eligibleVote();
            //p1.evenOdd();

          /*  NestedIfElse nf = new NestedIfElse();
            nf.foodChoice(); 

            SwitchCaseDemo sc = new SwitchCaseDemo();
            int n = 1;
            while(n != 0) 
            {
                Console.WriteLine(" Enter the Choice\n Press 1 : Addition\n Press 2 : Subtraction\n Press 3 : Multiplication\n Press 4 : Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the 1st Value : ");
                        int first = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Value : ");
                        int second = int.Parse(Console.ReadLine());
                        sc.add(first, second);
                        break;
                    case 2:
                        Console.WriteLine("Enter the 1st Value : ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Value : ");
                        int b = int.Parse(Console.ReadLine());
                        sc.sub(a, b);
                        break;
                    case 3:
                        Console.WriteLine("Enter the 1st Value : ");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Value : ");
                        int y = int.Parse(Console.ReadLine());
                        sc.mul(x, y);
                        break;
                    case 4:
                        Console.WriteLine("Enter the 1st Value : ");
                        int i = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Value : ");
                        int j = int.Parse(Console.ReadLine());
                        sc.div(i, j);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                } 
            }  */
        }
    }
}
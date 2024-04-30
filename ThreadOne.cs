using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ThreadOne
    {
        public static void ThreadForMethodOne()
        {
            Console.WriteLine("1.ThreadOne ThreadForMethodOne starting--------------");
            Thread.Sleep(5000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("1.ThreadOne ThreadForMethodOne executing " + i);
            }
            Console.WriteLine("1.ThreadOne ThreadForMethodOne exiting--------------");
            Thread.Sleep(5000);
        }
        public static void ThreadForMethodTwo()
        {
            Console.WriteLine("2.ThreadOne ThreadForMethodTwo starting--------------");
            Thread.Sleep(5000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("2.ThreadOne ThreadForMethodTwo executing " + i);

            }
            Console.WriteLine("2.ThreadOne ThreadForMethodTwo exiting--------------");
            Thread.Sleep(5000);
        }
        public static void ThreadForMethodThree()
        {
            Console.WriteLine("3.ThreadOne ThreadForMethodThree starting--------------");
            Thread.Sleep(5000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("3.ThreadOne ThreadForMethodThree executing " + i);
            }
            Console.WriteLine("3.ThreadOne ThreadForMethodThree exiting--------------");
            Thread.Sleep(5000);
        }
    }
}

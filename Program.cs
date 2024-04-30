using System.Diagnostics;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            /* new ProgramOne().Method1();
             new ProgramOne().Method2();
             new ProgramOne().Method3();
             new ProgramOne().Method4();
             //int i = 5;
             
             Console.WriteLine("hi there".ToProperCase());*/
            /*int i = 9;
            int sum = 0;
            try
            {
                sum = i / 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("this is an error " + ex);
            }
            finally
            {
                Console.WriteLine("finally it is resolved");
            }*/
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Main Thread starting-------------------------");
            Thread.Sleep(5000);
            ThreadStart ob = ThreadOne.ThreadForMethodOne;
            //Thread t1 = new Thread(ThreadOne.ThreadForMethodOne);
            Thread t1=new Thread(ob);
            Thread t2 = new Thread(ThreadOne.ThreadForMethodTwo);
            Thread t3 = new Thread(ThreadOne.ThreadForMethodThree);
            t1.Start();
            t2.Start();
            t3.Start();
            //t1.Join();
            //t2.Join();
            //t3.Join();
            
            Console.WriteLine("Main Thread exiting-------------------------");
            Thread.Sleep(5000);
            sw.Stop();
            ProgramThree obj3=new ProgramThree(78,"yourName",98);
            Console.WriteLine($"{obj3.Name}--{obj3.Id}");
            Console.WriteLine(5.Factorial());
            Console.WriteLine(95.Square());
            Console.WriteLine("quick brown fox jumped".ToProperCase());


        }
    }
  }
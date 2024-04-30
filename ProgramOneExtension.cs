using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ProgramOneExtension
    {
        public static void Method3(this ProgramOne p)
        {
            Console.WriteLine("This is Method3 from ProgramOneExtension");
        }
        public static void Method4(this ProgramOne p)
        {
            Console.WriteLine("This is Method4 from ProgramOneExtension");
        }
        public static long Factorial(this Int32 x)
        {
            return x==1?1:x==2?2:x*Factorial(x-1);
        }
        public static long Square(this Int32 x)
        {
            return x == 1 ? 1 : x == 0 ? 0 : x * x;
        }
        public static string ToProperCase(this string s)
        {
            string newstr = null;
            s=s.ToLower();
            string[] s1 = s.Split(' ');
            foreach(string str in s1)
            {
                char[] ch=str.ToCharArray();
                ch[0] = char.ToUpper(ch[0]);
                newstr += new string(ch);
                newstr += " ";
            }
            return newstr.TrimEnd();
        }
    }
}

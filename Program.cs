using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDay1 = DateTime.Now;
            
            Console.WriteLine("Current Day and Month is : " );
            Console.WriteLine(currentDay1.ToString("dddd, MMMM"));
            Console.ReadKey();
        }
    }
}

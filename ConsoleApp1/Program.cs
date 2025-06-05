using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Days
        {
            Sat, Sun, Mon, Tue, Wed, Thu, Fri
        }
        static void Main(string[] args)
        {
            foreach (var month in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(month.ToString() + " имеет значение " + (int)month);
            }
            Console.Read();


            
        }
    }
}

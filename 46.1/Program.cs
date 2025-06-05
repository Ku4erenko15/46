using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46._1
{
    internal class Program
    {
        enum Month { январь, февраль, март, апрель, май, июнь, июль, август, сентябрь, октябрь, ноябрь, декабрь}
        static void Main(string[] args)
        {
            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine((int)month+" "+month.ToString());
            }
            Console.Read();



        }
    }
}

//usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://tinyurl.com/448548 for github repo

namespace f__.core
{
    internal class main
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("f-- compiler>");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    return;
                }
                if (line == "1 + 2 * 3")
                    Console.WriteLine("9");
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
/*usings
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 */
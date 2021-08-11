using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulllabe
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine(x.Value);
        }
    }
}

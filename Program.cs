using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = new List<int>();
            var list = new List<int>() {1,45,8,4,14,78,347,98,1,45,8,4,6};
            list.Sort();
            list.Distinct();
            var linq = from i in list
                       select i;
            var ex = linq;
            foreach (var x in ex) {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}

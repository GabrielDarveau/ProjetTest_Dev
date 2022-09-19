using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int param = 0;
            bool param2 = false;
            MonExemple(param, param2);
            Console.ReadKey();
        }
        public static void MonExemple(int param, bool param2)
        {
            Console.WriteLine("MonExemple");
            Console.WriteLine(param);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(10);
            Console.WriteLine(test.Number);
            ChangeNumber(test);
            Console.WriteLine(test.Number);
        }
        public static void ChangeNumber(Test test)
        {
            test.Number = 45;
        }
    }
}

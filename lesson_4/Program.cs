using Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_GUI
{
    class Program
    {
        // hello
        static void Main(string[] args)
        {
            var list = Utilities.ConfigEmailDependencies("Mock").GetAll();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

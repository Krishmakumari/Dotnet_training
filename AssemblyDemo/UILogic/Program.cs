using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic= new SomeLogic();
            int numResult= logic.AddMe(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {numResult}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    //+= - add method to invokation list
    //-= - remove method from the invokation list
    //multicast delegate - must have return type void, Can invoke multiple methods, 
    public delegate void GreetMsg(string msg);

    //unicast delegate - References only one method at a time, must have any return type
    public delegate int Calculation(int num1, int num2);
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat" + userName);
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam" + userName);
        }

    }
    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine(" " + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat" + userName);
        }
    }
    public class DelegateDemo
    {
        
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);
            GreetInTamil("Alok");

        }
  
    }
}

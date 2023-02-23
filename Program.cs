using System;

/// <summary>
/// /// Overloaded methods may have the same or different return types, but they must have different parameters. 
////// order of parameter is must be different like int string and string int and vice versa.
/// </summary>
namespace MethodOverloadingPOVForInterview
{
    public class Manufacturing
    {
        public void Work(int a)
        {
            Console.WriteLine("print the work:" + a);
        }
        
        public void Work(string a)
        {
            Console.WriteLine("print the work:" + a);
        }

        public void Work(int b, int c)
        {
            Console.WriteLine("print the work:" + c + "and b" + b);
        }

        public void Work(int b, string c)
        {
            Console.WriteLine("print the work:" + c + "and b" + b);
        }

        public void Work(string b, int c)
        {
            Console.WriteLine("print the work:" + c + "and b" + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manufacturing obj = new Manufacturing();
            obj.Work(10);
            obj.Work(10,12);
        }
    }
}

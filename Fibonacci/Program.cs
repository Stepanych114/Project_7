using System;
namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 35; i++) Console.Write(Fib(i)+" ");
        }
        static int Fib(int n)
        {
            return (n < 2) ? n : Fib(n - 1) + Fib(n - 2);
        }
    }
}

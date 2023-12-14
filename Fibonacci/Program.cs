using System;
namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первые 6 чисел Фибоначчи:"+Fib(1) + " " + Fib(2) + " " + Fib(3) + " " + Fib(4) + " " + Fib(5) + " " + Fib(6)) ;
        }
        static int Fib(int n)
        {
            return (n < 2) ? n : Fib(n - 1) + Fib(n - 2);
        }
    }
}

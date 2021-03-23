using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;  
            int i, j;
            for (i = 2; i <= 100; i++) {  
                for (j = 2; j <= 100; j++) {  
                    if (i != j && i % j == 0) {  
                        isPrime = false;  
                        break;  
                    }  
                }  
                if (isPrime) {  
                    Console.WriteLine($"{i} is a prime number");  
                }  
                isPrime = true;  
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 15; // replace with the number you want to start from
        
        while (num >= 0)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
            num--;
        }
    }
}
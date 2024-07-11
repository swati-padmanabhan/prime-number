using System;

public class Program
{
    static void CheckPrime(int num)
    {
  int flag = 0;
  
        if (num <= 1)
            flag = 0;

        int sqrtNum = (int)Math.Sqrt(num);
  
        for (int i = 2; i <= sqrtNum; i++) 
  {
            if (num % i == 0)
    flag = 1;
        }
  
  if (flag == 0)
   Console.WriteLine("number is a prime number.");
  else
   Console.WriteLine("number is not a prime number.");
    }

    public static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        CheckPrime(number);
    }
}
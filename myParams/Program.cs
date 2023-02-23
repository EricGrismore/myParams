using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("How many integer numbers do you want to generate?");
        int starter = int.Parse(Console.ReadLine());


        Random r = new Random();
        int[] numbers = new int[starter];
        for (int i = 0;i < numbers.Length; i++)
        {
            numbers[i] = r.Next(1, 10);
        }
        for (int a = 0; a < numbers.Length; a++)
        {
            Console.WriteLine(numbers[a]);
        }

        Console.WriteLine($"Total of the numbers array={Add(numbers)}");


        Console.WriteLine($"Product of the numbers array={Multiply(numbers)}");

    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }


    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}

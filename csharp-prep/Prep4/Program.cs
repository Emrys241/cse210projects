using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");
        int input;
        do
        {string inputStr = Console.ReadLine();
        if (!int.TryParse(inputStr, out input))
            {Console.WriteLine("Invalid input. Please enter a number.");
            continue;
            }
            numbers.Add(input);
        } 
        while(input != 0);
        Console.WriteLine("The numbers you entered are:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + ",");
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
    
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
        
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number != min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min is: {min}");
        }
    }
}
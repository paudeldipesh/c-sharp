using System;

class Program
{
    // Program demonstrating basic C# features
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y})");
        }
    }

    static void Main()
    {
        int x = 12 * 5;
        Console.WriteLine(x);
        
        Console.WriteLine(FeetToInches(30));
        
        int number = 7;
        if (number > 5)
        {
            Console.WriteLine($"{number} is greater than 5.");
        }
        else
        {
            Console.WriteLine($"{number} is not greater than 5.");
        }
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
        
        int counter = 100;
        while (counter <= 103)
        {
            Console.WriteLine(counter);
            counter++;
        }
        
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine($"Exception: {exception.Message}");
        }

        Day today = Day.Wednesday;
        Console.WriteLine($"Today is {today}");

        dynamic anything = "Hello";
        anything = 10;

        int? nullableInt = null;

        var person = (Name: "Dipesh Paudel", Age: 30);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        Point p1 = new Point(10, 20);
        p1.Display();
    }
    
    static string FeetToInches(int feet)
    {
        int inches = feet * 12;
        return $"{feet} feet is equal to {inches} inches.";
    }
}

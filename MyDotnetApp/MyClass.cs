using System;

namespace MyDotnetApp
{
    public class MyClass
    {
        // A simple property
        public string Name { get; set; }

        // Constructor
        public MyClass(string name)
        {
            Name = name;
        }

        // A method that performs a simple operation
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // A method to display the name
        public void DisplayName()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }
}

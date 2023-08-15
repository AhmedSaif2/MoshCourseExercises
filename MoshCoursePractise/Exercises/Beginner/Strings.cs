using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourses.Exercises.Beginner
{
    internal class Strings
    {
        // Exercise 1: determine whether a list of numbers is consecutive or not
        public static void Exercise1()
        {
            Console.WriteLine("Enter a sequence of numbers sepertaed by hyphen: ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            bool flag = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                int a = Convert.ToInt32(numbers[i - 1]), b = Convert.ToInt32(numbers[i]);
                if (b - a != 1)
                {
                    Console.WriteLine("Not Consecutive!");
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Consecutive!");
        }
        // Exercise 2: determine if a sequence of numbers has dublicates
        public static void Exercise2()
        {
            Console.WriteLine("Enter a sequence of numbers sepertaed by hyphen or press Enter: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            var numbers = input.Split('-');
            for (int i = 0; i < numbers.Length; i++)
            {
                var a = Convert.ToInt32(numbers[i]);
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var b = Convert.ToInt32(numbers[j]);
                    if (a == b)
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }
        }
        // Exercise 3: determine if the user enters a valid time in 24 hour format
        public static void Exercise3()
        {
            Console.WriteLine("Enter a time in 24 hour format:");
            var input = Console.ReadLine();
            var time = input.Split(':');
            int hours = Convert.ToInt32(time[0]), minutes = Convert.ToInt32(time[1]);
            if (hours >= 0 && hours <= 24 && minutes >= 0 && minutes <= 60)
            {
                Console.WriteLine("Valid Time!");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
        // Exercise 4: Transform a text to Pascal Case
        public static void Exercise4()
        {
            Console.WriteLine("Enter Text: ");
            var input = Console.ReadLine();
            var array = input.Split(' ');
            var pascalcase = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                pascalcase.Append(char.ToUpper(array[i][0]))
                    .Append(array[i].Substring(1).ToLower())
                    .Append(" ");
            }
            Console.WriteLine(pascalcase);
        }

    }
}

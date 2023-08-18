using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Beginner
{
    public class Loops
    {
        // Exercise 1: Count the number of numbers divisible by 3 between 1 and 100
        public static void Exercise1()
        {
            int count = 0, start = 1, end = 100;
            for (int i = start; i < end; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        // Exercise 2: Add all numbers till user enters ok and display their sum
        public static void Exercise2()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or ok to exit: ");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
        }
        // Exercise 3: Generate a random number and let user get it
        public static void Exercise3()
        {
            Random random = new Random();
            var number = random.Next(0, 10);
            const int Guesses = 4;
            bool win = false;
            Console.WriteLine(number);
            for (int i = 0; i < Guesses; i++)
            {
                Console.WriteLine("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You Won!");
                    win = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Number!");
                }
            }
            if (!win)
            {
                Console.WriteLine("You lost :(");
            }
        }
        //Exercise 4: display the maximum number in a series of numbers seperated by a comma.
        public static void Exercise4()
        {
            Console.WriteLine("Enter a series of numbers seperated by a comma: ");
            var input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int max = 0;
            foreach (var number in numbers)
            {
                max = Math.Max(Convert.ToInt32(number), max);
            }
            Console.WriteLine(max);
        }
    }
}

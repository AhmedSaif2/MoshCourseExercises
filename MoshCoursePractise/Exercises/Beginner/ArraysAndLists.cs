using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Beginner
{
    public class ArraysAndLists
    {
        //Exercise 1: Display people who liked your post
        public static void Exercise1()
        {
            Console.WriteLine("Enter names of people who liked your post: ");
            var list = new List<string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name.Equals(""))
                {
                    break;
                }
                list.Add(name);
            }
            if (list.Count == 1)
            {
                Console.WriteLine("{0} likes your post", list[0]);
            }
            else if (list.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", list[0], list[1]);
            }
            else if (list.Count >= 3)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", list[0], list[1], list.Count - 2);
            }
        }
        //Exercise 2: Reverse A name
        public static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            var arr = name.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);
            Console.WriteLine("Reversed name: {0}", rev);
        }
        /*
         * Exercise 3:
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
         * display an error message and ask the user to re-try. Once the user successfully enters 5 unique 
         * numbers, sort them and display the result on the console.
         */
        public static void Exercise3()
        {
            var list = new List<int>();
            const int Count = 5;
            Console.WriteLine("Enter {0} unique numbers: ", Count);
            for (int i = 0; i < Count; i++)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                while (list.IndexOf(number) != -1)
                {
                    Console.WriteLine("Number is not unique, Try Again: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                list.Add(number);
            }
            list.Sort();
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
        /*
         * Exercise 4: Display unique numbers user has entered
         */
        public static void Exercise4()
        {
            var list = new List<int>();
            Console.WriteLine("Enter a number or type exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("exit"))
                {
                    break;
                }
                list.Add(Convert.ToInt32(input));
            }
            var unique = new List<int>();
            foreach (var number in list)
            {
                if (!unique.Contains(number))
                {
                    unique.Add(number);
                }
            }
            Console.WriteLine("Unique numbers: ");
            foreach (var number in unique)
            {
                Console.Write(number + " ");
            }
        }
    }
}

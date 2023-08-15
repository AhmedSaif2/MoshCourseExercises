using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse.Exercises.Beginner
{
    internal class Conditionals
    {
        // Exercise 1: check if an input is between 1 and 10
        public static void Exercise1()
        {
            const int min=1, max=10;
            Console.WriteLine("Enter A number between {0} and {1}",min,max);
            var number=Convert.ToInt32(Console.ReadLine());
            if (number >= 1&&number<=10)
            {
                Console.WriteLine("Valid number!");
            }
            else
            {
                Console.Write("Invalid number!");
            }
        }
        // Exercise 2: Determine max between two numbers
        public static void Exercise2()
        {
            Console.WriteLine("Enter two numbers");
            var x=Convert.ToInt32(Console.ReadLine());
            var y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max: {0}",Math.Max(x,y));
        }
        // Exercise 3: tell if the image is landscape or portrait based on width and height
        public static void Exercise3()
        {
            Console.WriteLine("Enter the height of an image: ");
            var height=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of an image: ");
            var width=Convert.ToInt32(Console.ReadLine());
            if (height>width)
            {
                Console.WriteLine("The image is a portrait.");
            }
            else
            {
                Console.WriteLine("The image is a landscape.");
            }
        }
        // Exercise 4: Display a message based on the speed of a car
        public static void Exercise4()
        {
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK!");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("Demerit Points = {0}", demeritPoints);
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Beginner
{
    public class FilesAndDirectories
    {
        //Exercise 1: Display the number of words in a given file
        public static void Exercise1()
        {
            var path = "temp.txt";
            var words = File.ReadAllText(path).Split(' ');
            Console.WriteLine(words.Length);
        }
        //Exercise 2: Display the longest word in a file
        public static void Exercise2()
        {
            var path = "temp.txt";
            var words = File.ReadAllText(path).Split(' ');
            int maxWordIndex = 0, maxWord = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > maxWord)
                {
                    maxWordIndex = i;
                    maxWord = words[i].Length;
                }
            }
            Console.WriteLine(words[maxWordIndex]);
        }
    }
}

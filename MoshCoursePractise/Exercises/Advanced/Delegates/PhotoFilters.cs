using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Advanced.Delegates
{
    public class PhotoFilters
    {
        public static void AddBrightness(Photo photo)
        {
            Console.WriteLine("Adding Brightness...");
        }
        public static void SmoothePhoto(Photo photo)
        {
            Console.WriteLine("Smoothing Photo...");
        }
    }
}

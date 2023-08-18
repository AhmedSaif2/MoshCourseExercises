using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Advanced.Delegates
{
    public class PhotoProcesser
    {
        public PhotoProcesser()
        {

        }
        public void ProcessPhoto(Photo photo, Action<Photo> photoFilters)
        {
            photoFilters(photo);
            photo.Save();
        }
    }
}

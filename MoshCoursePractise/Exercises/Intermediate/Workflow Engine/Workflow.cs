using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Intermediate
{
    public class Workflow
    {
        private readonly IList<IActivity> activities;
        public Workflow() 
        { 
            activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }
        public void Execute()
        {
            foreach (var activity in activities)
            {
                activity.Run();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Intermediate
{
    public class Post
    {
        private string Title;
        private string Description;
        private int votes;
        private DateTime TimeCreated;
        public Post(string title,string description)
        {
            Title = title;
            Description = description;
            votes = 0;
            TimeCreated = DateTime.Now;
        }
        public void UpVote()
        {
            votes++;
        }
        public void DownVote() 
        {
            votes--;
        }
        public int GetVotes()
        {
            return votes;
        }
    }
}

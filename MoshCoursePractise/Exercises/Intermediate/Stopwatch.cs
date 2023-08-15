using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse.Exercises.Intermediate
{
    internal class Stopwatch
    {
        private DateTime _time;
        bool _isRunning;
        public Stopwatch()
        {
            _isRunning = false;
        }
        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException();
            }
            _time = DateTime.Now;
            _isRunning = true; 
        }
        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidCastException();
            }
            _isRunning = false;
            displayDuration();
        }
        private void displayDuration()
        {
            Console.WriteLine("Time: {0}",DateTime.Now-_time);
        }
    }
}

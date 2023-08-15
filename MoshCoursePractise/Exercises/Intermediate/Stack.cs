using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse.Exercises.Intermediate
{
    internal class Stack
    {
        private List<object> _stack;
        public Stack() 
        {  
            _stack = new List<object>();
        }
        public void push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            _stack.Add(obj);
        }
        public object pop()
        {
            if ( _stack.Count == 0 ) 
            {
                throw new InvalidOperationException();
            }
            object item = _stack.Last();
            _stack.Remove(_stack.Last());
            Console.WriteLine(item);
            return item;
        }
        public void clear()
        {
            _stack.Clear();
        }
        
    }
}

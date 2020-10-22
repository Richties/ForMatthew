using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesApp
{
    class Employee
    {
        string position;
        int priority;
        public Employee()
        {

        }

        public Employee(string position, int priority)
        {
            this.position = position;
            this.priority = priority;
        }

        public string Position { get => position; set => position = value; }
        public int Priority { get => priority; set => priority = value; }
    }
}

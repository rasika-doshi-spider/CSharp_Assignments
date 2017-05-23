using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class ChildClass : BaseClass
    {
       public ChildClass()
        {
            Console.WriteLine("Child Constructor");
        }

        public new void Display()
        {
            Console.WriteLine("I am the child class");
        }

        public void BaseDisplay()
        {
            base.Display();
        }
    }
}

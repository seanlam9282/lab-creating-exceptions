using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_creating_exceptions
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() 
        {
            Console.WriteLine("Valid radius.");
        }

        public InvalidRadiusException(double radius) 
        {
            Console.WriteLine("Invalid radius.");
        }
    }
}

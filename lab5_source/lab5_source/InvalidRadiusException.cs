using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab5_source
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() 
            :base("This won't ever run but the radius is greater than zero")
        {
        }

        public InvalidRadiusException(double radius)
            :base("Error value " + radius.ToString() + " is not valid. Radius must be greater than zero")
        {
        }
    }
}

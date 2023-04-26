using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections.Exceptions
{
    internal class NotfoundException : Exception
    {
        public NotfoundException(string message) : base(message)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace tryCatchProject
{
    public class negativeException : Exception
    {
        public negativeException()
            : base() { }
        public negativeException(string message)
            : base(message) { }
    }
}

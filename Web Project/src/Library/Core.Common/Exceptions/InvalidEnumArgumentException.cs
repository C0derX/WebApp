using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Exceptions
{
    public class InvalidEnumArgumentException : Exception
    {
        public InvalidEnumArgumentException(string message) : base(message)
        {

        }
    }
}

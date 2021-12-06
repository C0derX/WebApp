using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Exceptions
{
    public class InvalidStateTransitionException:CustomException
    {
        public InvalidStateTransitionException(string message="Requested transition state is invalid."):base(message)
        {

        }
    }
}

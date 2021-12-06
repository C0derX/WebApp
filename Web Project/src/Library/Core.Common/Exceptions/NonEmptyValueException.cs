using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Exceptions
{
    public class NonEmptyValueException : CustomException
    {
        public NonEmptyValueException(string message = "Value must be provided.") : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Exceptions
{
    public class DuplicateItemException : CustomException
    {
        public DuplicateItemException(string message = "Item already exists.") : base(message)
        {

        }
    }
}

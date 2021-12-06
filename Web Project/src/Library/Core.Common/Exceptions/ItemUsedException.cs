using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Exceptions
{
    public class ItemUsedException : CustomException
    {
        public ItemUsedException(string message = "Specified item has already been used.") : base(message)
        {

        }
    }
}

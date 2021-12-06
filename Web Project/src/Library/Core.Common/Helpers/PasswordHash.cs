using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Helpers
{
    public interface PasswordHash
    {
        string CreateHash(string password);
        bool ValidatePassword(string password, string correct_hash);
    }
}

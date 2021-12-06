using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Core.Common.Library.Interface
{
    public interface Cryptography
    {
        string Encrypt(string plainText);

        string Decrypt(string cipherText);
    }
}

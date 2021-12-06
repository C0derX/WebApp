using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Service.Services.Interface
{
    public interface RandomKeyGeneratorService
    {
        string getRandomAlphanumericKey(int size = 15);
    }
}

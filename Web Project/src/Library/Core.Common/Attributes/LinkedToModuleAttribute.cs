using Core.Common.Enums;
using System;

namespace Core.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LinkedToModuleAttribute : Attribute
    {
        public ModuleKey PaidForModule { get; private set; }

        public LinkedToModuleAttribute(ModuleKey paidForModule)
        {
            PaidForModule = paidForModule;
        }
    }
}

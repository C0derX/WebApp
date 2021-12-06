using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Common.Enums
{
    public enum Permissions : short
    {
        NotSet = 0, //error condition

        //Here is an example of very detailed control over something
        [Display(GroupName = "Action", Name = "Read", Description = "Can view datas")]
        Read = 0x10,
        [Display(GroupName = "Action", Name = "Create", Description = "Can insert new data")]
        Create = 0x11,
        [Display(GroupName = "Action", Name = "Update", Description = "Can update existing data")]
        Update = 0x12,
        [Display(GroupName = "Action", Name = "Delete", Description = "Can delete a data")]
        Delete = 0x13,

    }
}

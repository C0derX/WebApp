﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Dto
{
    public class DeleteDto
    {
        public long Id { get; set; }
        public long modified_by { get; set; }
    }
}

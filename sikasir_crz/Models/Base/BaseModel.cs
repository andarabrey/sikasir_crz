﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sikasir_crz.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

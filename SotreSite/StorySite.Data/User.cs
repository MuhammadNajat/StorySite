﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}

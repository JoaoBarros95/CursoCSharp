﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeration.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }
}

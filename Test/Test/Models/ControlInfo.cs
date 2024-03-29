﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class ControlInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public int? Parent { get; set; }
        public List<Dependency> Dependencies { get; set; }
        public ControlInfo[] Children { get; set; }
    }
}

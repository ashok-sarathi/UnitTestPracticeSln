﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEnties
{
    public class Student
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
    }
}

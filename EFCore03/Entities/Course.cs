﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> students { get; set; }
    }
}

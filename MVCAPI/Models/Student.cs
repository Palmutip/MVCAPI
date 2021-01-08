using System;
using System.Collections.Generic;

namespace MVCAPI.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int Grade { get; set; }
    }
}

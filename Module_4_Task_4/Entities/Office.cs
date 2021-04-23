﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Task_4.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

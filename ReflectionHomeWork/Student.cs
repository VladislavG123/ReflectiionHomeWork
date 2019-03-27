﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWork
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public DateTime BirthDay { get; set; }
        public string Group { get; set; }

        public string GetAllInfo()
        {
            return $"{FullName} {country} {city} {BirthDay.ToString()} {Group}";
        }
    }
}
